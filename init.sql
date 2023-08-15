go

CREATE TABLE [dbo].[specializations]
  (
     [idspecialization]   [INT] IDENTITY(1, 1) NOT NULL,
     [specializationname] [VARCHAR](100) NOT NULL,
     CONSTRAINT [PK_Specializations] PRIMARY KEY CLUSTERED ( [idspecialization]
     ASC )WITH (pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key =
     OFF, allow_row_locks = on, allow_page_locks = on,
     optimize_for_sequential_key = OFF) ON [PRIMARY]
  )
ON [PRIMARY]

go

CREATE TABLE [dbo].[doctors]
  (
     [iddoctor]         [INT] IDENTITY(1, 1) NOT NULL,
     [fullname]         [VARCHAR](100) NOT NULL,
     [passportnumber]   [VARCHAR](10) NOT NULL,
     [phonenumber]      [VARCHAR](15) NOT NULL,
     [gender]           [VARCHAR](1) NOT NULL,
     [specializationid] [INT] NOT NULL,
     [userid]           [INT] NOT NULL,
     CONSTRAINT [PK_Doctors] PRIMARY KEY CLUSTERED ( [iddoctor] ASC )WITH (
     pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF,
     allow_row_locks = on, allow_page_locks = on, optimize_for_sequential_key =
     OFF) ON [PRIMARY]
  )
ON [PRIMARY]

go

CREATE TABLE [dbo].[patients]
  (
     [idpatient]       [INT] IDENTITY(1, 1) NOT NULL,
     [fullname]        [VARCHAR](100) NOT NULL,
     [passportnumber]  [VARCHAR](10) NOT NULL,
     [insurancenumber] [VARCHAR](16) NOT NULL,
     [phonenumber]     [VARCHAR](15) NOT NULL,
     [gender]          [VARCHAR](1) NOT NULL,
     [userid]          [INT] NOT NULL,
     CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED ( [idpatient] ASC )WITH (
     pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF,
     allow_row_locks = on, allow_page_locks = on, optimize_for_sequential_key =
     OFF) ON [PRIMARY]
  )
ON [PRIMARY]

go

CREATE TABLE [dbo].[appointmentscontent]
  (
     [idappointmentcontent] [INT] IDENTITY(1, 1) NOT NULL,
     [recommendations]      [VARCHAR](400) NULL,
     [complaints]           [VARCHAR](300) NULL,
     CONSTRAINT [PK_AppointmentsContent] PRIMARY KEY CLUSTERED (
     [idappointmentcontent] ASC )WITH (pad_index = OFF, statistics_norecompute =
     OFF, ignore_dup_key = OFF, allow_row_locks = on, allow_page_locks = on,
     optimize_for_sequential_key = OFF) ON [PRIMARY]
  )
ON [PRIMARY]

go

CREATE TABLE [dbo].[appointmentstatus]
  (
     [idappointmentstatus] [INT] IDENTITY(1, 1) NOT NULL,
     [statusname]          [VARCHAR](50) NOT NULL,
     CONSTRAINT [PK_AppointmentStatus] PRIMARY KEY CLUSTERED (
     [idappointmentstatus] ASC )WITH (pad_index = OFF, statistics_norecompute =
     OFF, ignore_dup_key = OFF, allow_row_locks = on, allow_page_locks = on,
     optimize_for_sequential_key = OFF) ON [PRIMARY]
  )
ON [PRIMARY]

go

CREATE TABLE [dbo].[appointments]
  (
     [idappointment]        [INT] IDENTITY(1, 1) NOT NULL,
     [patientid]            [INT] NOT NULL,
     [doctorid]             [INT] NOT NULL,
     [datetimeofappointmet] [DATETIME] NOT NULL,
     [appoinmentcontentid]  [INT] NULL,
     [appointmentstatusid]  [INT] NULL,
     CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED ( [idappointment] ASC )
     WITH (pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF,
     allow_row_locks = on, allow_page_locks = on, optimize_for_sequential_key =
     OFF) ON [PRIMARY]
  )
ON [PRIMARY]

go

CREATE TABLE [dbo].[receptionsts]
  (
     [idreceptionist] [INT] IDENTITY(1, 1) NOT NULL,
     [fullname]       [VARCHAR](100) NOT NULL,
     [phonenumber]    [VARCHAR](15) NOT NULL,
     [userid]         [INT] NOT NULL,
     [passportnumber] [VARCHAR](10) NOT NULL,
     CONSTRAINT [PK_Receptionsts] PRIMARY KEY CLUSTERED ( [idreceptionist] ASC )
     WITH (pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF,
     allow_row_locks = on, allow_page_locks = on, optimize_for_sequential_key =
     OFF) ON [PRIMARY]
  )
ON [PRIMARY]

go

CREATE TABLE [dbo].[users]
  (
     [iduser]   [INT] IDENTITY(1, 1) NOT NULL,
     [login]    [VARCHAR](30) NOT NULL,
     [password] [VARCHAR](500) NOT NULL,
     [active]   [BIT] NOT NULL,
     CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ( [iduser] ASC )WITH (pad_index
     = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, allow_row_locks
     = on, allow_page_locks = on, optimize_for_sequential_key = OFF) ON
     [PRIMARY]
  )
ON [PRIMARY] 
