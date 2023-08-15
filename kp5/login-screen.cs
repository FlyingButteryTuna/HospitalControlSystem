using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace kp5
{
  public partial class LoginScreen : Form
  {
    public static String password = "jkdadjp";
    public LoginScreen()
    {
      InitializeComponent();
      txtBoxPassword.UseSystemPasswordChar = true;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    

    private void button1_Click(object sender, EventArgs e)
    {


     Console.WriteLine(StringCipher.Encrypt((string)"test123", password));
      Console.WriteLine(StringCipher.Decrypt("DnwHhhOOWPLxpnQZuUA1p9Q9R/At2Y1orNG0wL6yxJXyuLomDIhmmtWjLSaJb+PrxVDOd9TrC4yh4D2yiJPERd+IwoVpZfMlB+bCgXhZG1QWivibcGfsvQVsM5ApIER2", password));
      Console.WriteLine(StringCipher.Decrypt("Gx4CmalXEg2cMQBELmj0yKmhkOHw0Vgb837I+7uAv0xBcLAST04eZqkYalYYwlShnaR3wl4YR2qSWNjWRAJgtorIqFnQJy1pvhpPaTwCPS9Ppw+TOtu8TB5/YTL/XJ/X", password));


     String connectionString = @"Data Source=LAPTOP-VNLO7LAE;Initial Catalog=kp;Integrated Security=True";
      SqlConnection sqlConnection = new SqlConnection(connectionString);
      String query = "Select * from Users Where Login = '" + txtBoxLogin.Text.Trim() + "'";

      SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
      DataTable users = new DataTable();
      sda.Fill(users);
      if (users.Rows.Count == 1) {
        if (StringCipher.Decrypt(users.Rows[0]["Password"].ToString(), password) != txtBoxPassword.Text)
        {
          MessageBox.Show("Неверные данные");
        }
        query = "Select * from Receptionsts where UserId = " + users.Rows[0]["IdUser"];
        sda = new SqlDataAdapter(query, sqlConnection);
        DataTable tmp = new DataTable();
        sda.Fill(tmp);
        if (tmp.Rows.Count == 1) {
          if (users.Rows[0]["Active"].ToString() == "True")
          {
            FrontDeskWorker receptionistWindow = new FrontDeskWorker(tmp.Rows[0], sqlConnection, this);
            this.Hide();
            receptionistWindow.Show();
          }
          else {
            deactivated_account deacWin = new deactivated_account(this);
            deacWin.Show();
            this.Hide();
          }
          
        }
        else {
          query = "Select * from Doctors where UserId = " + users.Rows[0]["IdUser"];
          sda = new SqlDataAdapter(query, sqlConnection);
          tmp = new DataTable();
          sda.Fill(tmp);
          if (tmp.Rows.Count == 1){
            if (users.Rows[0]["Active"].ToString() == "True")
            {
              doctors_change_recs docWin = new doctors_change_recs(tmp.Rows[0], sqlConnection, this);
              this.Hide();
              docWin.Show();
            }
            else
            {
              deactivated_account deacWin = new deactivated_account(this);
              deacWin.Show();
              this.Hide();
            }
          }
          else {
            if (users.Rows[0]["Active"].ToString() == "True")
            {
              query = "Select * from Patients where UserId = " + users.Rows[0]["IdUser"];
              sda = new SqlDataAdapter(query, sqlConnection);
              tmp = new DataTable();
              sda.Fill(tmp);
              PatientAppoointments patientWindow = new PatientAppoointments(tmp.Rows[0], sqlConnection, this);
              patientWindow.Show();
              this.Hide();
            }
            else
            {
              deactivated_account deacWin = new deactivated_account(this);
              deacWin.Show();
              this.Hide();
            }
          }
        }
      }
      else {
        MessageBox.Show("Неверные данные.");
      }
    }

    private void checkBoxPsw_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxPsw.Checked)
      {
        txtBoxPassword.UseSystemPasswordChar = false;
      }
      else {
        txtBoxPassword.UseSystemPasswordChar = true;
      }
    }
  }

  
    public static class StringCipher
    {
      private const int Keysize = 256;
      private const int DerivationIterations = 1000;

      public static string Encrypt(string plainText, string passPhrase)
      {

        var saltStringBytes = Generate256BitsOfRandomEntropy();
        var ivStringBytes = Generate256BitsOfRandomEntropy();
        var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
        using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
        {
          var keyBytes = password.GetBytes(Keysize / 8);
          using (var symmetricKey = new RijndaelManaged())
          {
            symmetricKey.BlockSize = 256;
            symmetricKey.Mode = CipherMode.CBC;
            symmetricKey.Padding = PaddingMode.PKCS7;
            using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
            {
              using (var memoryStream = new MemoryStream())
              {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                  cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                  cryptoStream.FlushFinalBlock();
                
                  var cipherTextBytes = saltStringBytes;
                  cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                  cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                  memoryStream.Close();
                  cryptoStream.Close();
                  return Convert.ToBase64String(cipherTextBytes);
                }
              }
            }
          }
        }
      }

      public static string Decrypt(string cipherText, string passPhrase)
      {

        var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
        var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
        var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
        var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

        using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
        {
          var keyBytes = password.GetBytes(Keysize / 8);
          using (var symmetricKey = new RijndaelManaged())
          {
            symmetricKey.BlockSize = 256;
            symmetricKey.Mode = CipherMode.CBC;
            symmetricKey.Padding = PaddingMode.PKCS7;
            using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
            {
              using (var memoryStream = new MemoryStream(cipherTextBytes))
              {
                using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                {
                  var plainTextBytes = new byte[cipherTextBytes.Length];
                  var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                  memoryStream.Close();
                  cryptoStream.Close();
                  return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                }
              }
            }
          }
        }
      }

      private static byte[] Generate256BitsOfRandomEntropy()
      {
        var randomBytes = new byte[32];
        using (var rngCsp = new RNGCryptoServiceProvider())
        {
          rngCsp.GetBytes(randomBytes);
        }
        return randomBytes;
      }
    }
  
}
