-- Добавление специализации
go

DECLARE @SpecializationName VARCHAR(100) = 'Окулист'

INSERT INTO specializations
VALUES     (@SpecializationName)

-- Изменение специализации
go

DECLARE @SpecializationName VARCHAR(100) = 'Дерматолог'
DECLARE @SpecializationId INT = 1

UPDATE specializations
SET    specializationname = @SpecializationName
WHERE  idspecialization = @SpecializationId

-- Добавление статуса
go

DECLARE @StatusName VARCHAR(50) = 'Отменен'

INSERT INTO appointmentstatus
VALUES     (@StatusName)

-- Изменение статуса
go

DECLARE @StatusName VARCHAR(50) = 'Создан'
DECLARE @StatusId INT = 1

UPDATE appointmentstatus
SET    statusname = @StatusName
WHERE  idappointmentstatus = @StatusId

-- Добавление приёма
go

DECLARE @PatientId INT = (SELECT DISTINCT idpatient
           FROM   patients
           WHERE  fullname = 'Иванов Иван Пациентов'
                  AND insurancenumber = '1234567891234567'),
        @DoctorId  INT = (SELECT DISTINCT iddoctor
           FROM   doctors
           WHERE  fullname = 'Алексеев Алексей Врачевич'
                  AND phonenumber = '89457632923'),
        @StatusId  INT = (SELECT idappointmentstatus
           FROM   appointmentstatus
           WHERE  statusname = 'Создан')

EXEC Viewdoctorsschedule
  @DoctorId,
  '2017-12-01'

DECLARE @DateOfApp DATETIME = '2017-12-01 08:00'

IF EXISTS (SELECT time1
           FROM   ##tempschedule
           WHERE  Cast(@DateOfApp AS TIME) = time1)
  INSERT INTO appointments
              (patientid,
               doctorid,
               datetimeofappointmet,
               appointmentstatusid)
  VALUES     (@PatientId,
              @DoctorId,
              @DateOfApp,
              @StatusId)
ELSE
  RAISERROR('Incorrect input time',20,-1) WITH log

-- Изменение приема(дата)
go

DECLARE @DateOfApp DATETIME = '12-01-17 08:00'

UPDATE appointments
SET    datetimeofappointmet = @DateOfApp
WHERE  idappointment = (SELECT DISTINCT idappointment
                        FROM   appointments,
                               doctors
                        WHERE  doctorid = (SELECT iddoctor
                                           FROM   doctors
                                           WHERE
              fullname = 'Алексеев Алексей Врачевич'
              AND phonenumber = '89457632923')
              AND datetimeofappointmet = '12-01-2017 16:00')

-- Изменение приема(врач)
go

DECLARE @DoctorId INT = (SELECT iddoctor
   FROM   doctors
   WHERE  fullname = 'Иванов Иван Иванович'
          AND phonenumber = '89160784239')

UPDATE appointments
SET    doctorid = @DoctorId
WHERE  idappointment = (SELECT DISTINCT idappointment
                        FROM   appointments,
                               doctors
                        WHERE  doctorid = (SELECT iddoctor
                                           FROM   doctors
                                           WHERE  fullname = 'Алексеев Алексей Врачевич'
                                                  AND phonenumber =
                                                      '89457632923')
                               AND datetimeofappointmet = '12-01-2017 14:00')

-- Изменение статуса приема
go

UPDATE appointments
SET    appointmentstatusid = (SELECT idappointmentstatus
                              FROM   appointmentstatus
                              WHERE  statusname = 'Отменен')
WHERE  idappointment = (SELECT DISTINCT idappointment
                        FROM   appointments,
                               doctors
                        WHERE  doctorid = (SELECT iddoctor
                                           FROM   doctors
                                           WHERE
              fullname = 'Алексеев Алексей Врачевич'
              AND phonenumber = '89457632923')
              AND datetimeofappointmet = '12-01-2017 14:00')

-- Вывод всех приемов
go

SELECT p.fullname AS 'Patient Name',
       d.fullname AS 'Doctors Name',
       a.datetimeofappointmet,
       ap.complaints,
       ap.recommendations,
       ass.statusname
FROM   appointments AS a
       INNER JOIN patients AS p
               ON p.idpatient = a.patientid
       INNER JOIN doctors AS d
               ON d.iddoctor = a.doctorid
       INNER JOIN appointmentscontent AS ap
               ON ap.idappointmentcontent = a.appoinmentcontentid
       INNER JOIN appointmentstatus AS ass
               ON ass.idappointmentstatus = a.appointmentstatusid

-- Добавление\Изменение жалоб и рекомендаций (в таблице с аппоинтментами)
UPDATE appointments
SET    appoinmentcontentid = (SELECT appoinmentcontentid
                              FROM   appointmentscontent
                              WHERE  complaints = 'Болит горло')
WHERE  doctorid = (SELECT iddoctor
                   FROM   doctors
                   WHERE  fullname = 'Алексеев Алексей Врачевич'
                          AND phonenumber = '89457632923')
       AND datetimeofappointmet = '12-01-2017 08:00'

-- Вывод всех приемов на определенный день
go

SELECT p.fullname AS 'Patient Name',
       d.fullname AS 'Doctors Name',
       a.datetimeofappointmet,
       ap.complaints,
       ap.recommendations,
       ass.statusname
FROM   appointments AS a
       INNER JOIN patients AS p
               ON p.idpatient = a.patientid
       INNER JOIN doctors AS d
               ON d.iddoctor = a.doctorid
       INNER JOIN appointmentscontent AS ap
               ON ap.idappointmentcontent = a.appoinmentcontentid
       INNER JOIN appointmentstatus AS ass
               ON ass.idappointmentstatus = a.appointmentstatusid
WHERE  Cast(a.datetimeofappointmet AS DATE) = '2017-12-01'

-- Изменение профиля юзеров(login)
UPDATE users
SET    login = 'testNew'
WHERE  iduser = 1

-- Изменение профиля юзеров (password)
UPDATE users
SET    password = 'newpass'
WHERE  iduser = 1

-- Изменение профиля юзеров (activity status)
UPDATE users
SET    active = 0
WHERE  iduser = 1

-- Изменение данных пациента (имя)
UPDATE patients
SET    fullname = 'Андреев Андрей Андреевич'
WHERE  userid = 4

-- Изменение данных пациента (номер телефона)
UPDATE patients
SET    phonenumber = '89457632921'
WHERE  userid = 4

-- Изменение данных пациента (номер паспорта)
UPDATE patients
SET    passportnumber = '9876543210'
WHERE  userid = 4

-- Изменение данных пациента (номер страховки)
UPDATE patients
SET    insurancenumber = '9876543210987654'
WHERE  userid = 4

-- Изменение данных пациента (пол)
UPDATE patients
SET    gender = 'W'
WHERE  userid = 4

-- Изменение данных доктора (имя)
UPDATE doctors
SET    fullname = 'Алексеев Алексей Врачевич'
WHERE  userid = 3

-- Изменение данных доктора (номер телефона)
UPDATE doctors
SET    phonenumber = '89457632923'
WHERE  userid = 3

-- Изменение данных доктора (номер паспорта)
UPDATE doctors
SET    passportnumber = '9876743210'
WHERE  userid = 3

-- Изменение данных доктора (специализация)
UPDATE doctors
SET    specializationid = (SELECT idspecialization
                           FROM   specializations
                           WHERE  specializationname = 'Окулист')
WHERE  userid = 3

-- Изменение данных пациента (пол)
UPDATE doctors
SET    gender = 'W'
WHERE  userid = 3

-- Вывод всех приемов пациента
go

SELECT p.fullname AS 'Patient Name',
       d.fullname AS 'Doctors Name',
       a.datetimeofappointmet,
       ap.complaints,
       ap.recommendations,
       ass.statusname
FROM   appointments AS a
       INNER JOIN patients AS p
               ON p.idpatient = a.patientid
       INNER JOIN doctors AS d
               ON d.iddoctor = a.doctorid
       INNER JOIN appointmentscontent AS ap
               ON ap.idappointmentcontent = a.appoinmentcontentid
       INNER JOIN appointmentstatus AS ass
               ON ass.idappointmentstatus = a.appointmentstatusid
WHERE  p.idpatient = (SELECT idpatient
                      FROM   patients
                      WHERE  fullname = 'Иванов Иван Пациентов'
                             AND insurancenumber = '1234567891234567')

-- Вывод информации о врачах клиники определенной minus id fix, fix id=id
go

SELECT d.fullname,
       d.passportnumber,
       d.gender,
       s.specializationname
FROM   doctors AS d
       INNER JOIN specializations AS s
               ON s.idspecialization = d.specializationid
                  AND s.idspecialization = (SELECT idspecialization
                                            FROM   specializations
                                            WHERE
                      specializationname = 'Дерматолог')

-- Вывод рекомендаций врача, для конкретного приема patient, doctor
go

SELECT ac.recommendations
FROM   appointments AS a
       INNER JOIN doctors AS d
               ON d.iddoctor = a.doctorid
       INNER JOIN appointmentscontent AS ac
               ON ac.idappointmentcontent = a.appoinmentcontentid
WHERE  a.datetimeofappointmet = '12-01-2017 08:00'
       AND d.iddoctor = (SELECT iddoctor
                         FROM   doctors
                         WHERE
               fullname = 'Алексеев Алексей Врачевич'
               AND phonenumber = '89457632923')

-- Вывод жалоб врача, для конкретного приема
go

SELECT ac.complaints
FROM   appointments AS a
       INNER JOIN doctors AS d
               ON d.iddoctor = a.doctorid
       INNER JOIN appointmentscontent AS ac
               ON ac.idappointmentcontent = a.appoinmentcontentid
WHERE  a.datetimeofappointmet = '12-01-2017 08:00'
       AND d.iddoctor = (SELECT iddoctor
                         FROM   doctors
                         WHERE
               fullname = 'Алексеев Алексей Врачевич'
               AND phonenumber = '89457632923')

-- Вывод пациентов врача
go

SELECT DISTINCT p.fullname,
                p.passportnumber,
                p.insurancenumber,
                p.phonenumber,
                p.gender
FROM   appointments AS a
       INNER JOIN patients AS p
               ON a.patientid = p.idpatient
       INNER JOIN doctors AS d
               ON d.iddoctor = a.doctorid
                  AND d.iddoctor = (SELECT iddoctor
                                    FROM   doctors
                                    WHERE
       fullname = 'Алексеев Алексей Врачевич'
       AND phonenumber = '89457632923')

-- Вывод запланированных приемов врача
go

SELECT p.fullname AS 'Patient Name',
       d.fullname AS 'Doctor Name',
       a.datetimeofappointmet
FROM   appointments AS a
       INNER JOIN doctors AS d
               ON d.iddoctor = a.doctorid
                  AND Cast(datetimeofappointmet AS DATE) >= '2017-12-01'
                  AND appointmentstatusid != (SELECT idappointmentstatus
                                              FROM   appointmentstatus
                                              WHERE
                      statusname = 'Отменен')
                  AND d.iddoctor = (SELECT iddoctor
                                    FROM   doctors
                                    WHERE
                      fullname = 'Иванов Иван Иванович'
                      AND phonenumber = '89160784239')
       INNER JOIN patients AS p
               ON p.idpatient = a.patientid

-- Подсчет кол-ва запланированных приемов врача fix distinc name
go

SELECT d.fullname,
       d.phonenumber,
       Count(a.idappointment) AS 'Кол-во запланированных приемов'
FROM   appointments AS a
       INNER JOIN doctors AS d
               ON d.iddoctor = a.doctorid
                  AND Cast(datetimeofappointmet AS DATE) >= '2017-12-01'
                  AND appointmentstatusid != (SELECT idappointmentstatus
                                              FROM   appointmentstatus
                                              WHERE
                      statusname = 'Отменен')
                  AND d.iddoctor = (SELECT iddoctor
                                    FROM   doctors
                                    WHERE
                      fullname = 'Иванов Иван Иванович'
                      AND phonenumber = '89160784239')
GROUP  BY d.fullname,
          d.phonenumber

-- Вывод всех пациентов, записанных на прием в определенный день
go

SELECT DISTINCT p.fullname,
                p.gender,
                p.insurancenumber,
                p.passportnumber,
                p.phonenumber
FROM   patients AS p
       INNER JOIN appointments AS a
               ON p.idpatient = a.patientid
                  AND Cast(datetimeofappointmet AS DATE) = '2017-12-01'
                  AND a.appointmentstatusid != (SELECT b.idappointmentstatus
                                                FROM   appointmentstatus AS b
                                                WHERE
                      statusname = 'Отменен')

-- Вывод всех врачей у которых нет приемов в определённый день
go

SELECT DISTINCT d.fullname,
                d.passportnumber,
                d.phonenumber,
                s.specializationname
FROM   doctors AS d
       INNER JOIN appointments AS a
               ON Cast(a.datetimeofappointmet AS DATE) != '2017-12-01'
                   OR a.appointmentstatusid = (SELECT b.idappointmentstatus
                                               FROM   appointmentstatus AS b
                                               WHERE
                      statusname = 'Отменен')
       INNER JOIN specializations AS s
               ON s.idspecialization = d.specializationid
WHERE  d.iddoctor = a.doctorid

-- Представление все доктора со специализациями
go

CREATE VIEW doctors_with_spec
AS
  SELECT d.fullname,
         d.gender,
         d.passportnumber,
         d.phonenumber,
         specializationname
  FROM   doctors AS d
         INNER JOIN specializations
                 ON d.specializationid = idspecialization

-- Представление все аппоинтменты
go

CREATE VIEW appointments_full
AS
  SELECT patients.fullname AS PatientName,
         doctors.fullname  AS DoctorName,
         a.datetimeofappointmet,
         ast.statusname,
         acn.recommendations,
         acn.complaints
  FROM   doctors,
         patients,
         appointments AS a
         INNER JOIN appointmentstatus AS ast
                 ON ast.idappointmentstatus = a.appointmentstatusid
         INNER JOIN appointmentscontent AS acn
                 ON acn.idappointmentcontent = a.appoinmentcontentid
  WHERE  patients.idpatient = patientid
         AND doctorid = iddoctor

-- Регестрация врачей
go

CREATE PROCEDURE Registerdoctor (@Login            AS VARCHAR(50),
                                 @Password         AS VARCHAR(50),
                                 @FullName         AS VARCHAR(100),
                                 @PassportNumber   AS VARCHAR(10),
                                 @PhoneNumber      AS VARCHAR(15),
                                 @Gender           AS VARCHAR(1),
                                 @SpecializationId AS INT)
AS
    INSERT INTO users
    VALUES     (@Login,
                @Password,
                1)

    INSERT INTO doctors
    VALUES     (@FullName,
                @PassportNumber,
                @PhoneNumber,
                @Gender,
                @SpecializationId,
                (SELECT iduser
                 FROM   users
                 WHERE  login = @Login))

go

DECLARE @SpecId INT = (SELECT idspecialization
   FROM   specializations
   WHERE  specializationname = 'Дерматолог')

EXEC Registerdoctor
  'test3',
  'test123',
  'Иванов Иван Иванович1',
  '1234567891',
  '89160784238',
  'M',
  @SpecId

-- Регистрация пациентов
go

CREATE PROCEDURE Registerpatient (@Login           AS VARCHAR(50),
                                  @Password        AS VARCHAR(50),
                                  @FullName        AS VARCHAR(100),
                                  @PassportNumber  AS VARCHAR(10),
                                  @InsuranceNumber AS VARCHAR(16),
                                  @PhoneNumber     AS VARCHAR(15),
                                  @Gender          AS VARCHAR(1))
AS
    INSERT INTO users
    VALUES     (@Login,
                @Password,
                1)

    INSERT INTO patients
    VALUES     (@FullName,
                @PassportNumber,
                @InsuranceNumber,
                @PhoneNumber,
                @Gender,
                (SELECT iduser
                 FROM   users
                 WHERE  login = @Login))

go

EXEC Registerpatient
  'test5',
  'test1235',
  'Иванов Иван Пациентов3',
  '1234467291',
  '1734564891234567',
  '89160784229',
  'M'

-- Просмотр расписания врача
go

ALTER PROCEDURE Viewdoctorsschedule (@DoctorId AS INT,
                                     @Date     AS DATE)
AS
    IF Object_id('tempdb.dbo.##TempSchedule', 'U') IS NOT NULL
      DROP TABLE ##tempschedule

    CREATE TABLE ##tempschedule
      (
         time1 TIME
      )

    CREATE TABLE #tempschedule
      (
         time1 TIME
      )

    INSERT INTO #tempschedule
    VALUES      ('8:00')

    INSERT INTO #tempschedule
    VALUES      ('10:00')

    INSERT INTO #tempschedule
    VALUES      ('12:00')

    INSERT INTO #tempschedule
    VALUES      ('14:00')

    INSERT INTO #tempschedule
    VALUES      ('16:00')

    INSERT INTO #tempschedule
    VALUES      ('18:00')

    INSERT INTO #tempschedule
    VALUES      ('20:00')

    INSERT INTO ##tempschedule
    SELECT time1
    FROM   #tempschedule,
           doctors
    EXCEPT
    (SELECT Cast(datetimeofappointmet AS TIME)
     FROM   appointments AS a
     WHERE  doctorid = @DoctorId
            AND a.appointmentstatusid != (SELECT b.idappointmentstatus
                                          FROM   appointmentstatus AS b
                                          WHERE  statusname = 'Отменен'))

    DROP TABLE #tempschedule

go

EXEC Viewdoctorsschedule
  1,
  '2017-12-01' 
