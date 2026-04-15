 create  database Hospital
 use Hospital
 drop table Doctors
 create table Doctors(
 Id int primary key identity,
 DoctorName nvarchar(100),
 Specialization nvarchar(100),
 Phone varchar(15)
 )
 drop table Patients
 create table Patients(
 PatientsId int primary key identity,
 PatientName nvarchar(100),
 Age int,
 Gender varchar(10),
 Phone varchar (15)
 )
 insert into Doctors(DoctorName,Specialization,Phone)
 values
 (N'Dr. Leyla Əliyeva', N'Kardioloq', '+994501234567'),
(N'Dr. Rauf Həsənov', N'Cərrah', '+994552345678'),
(N'Dr. Günel Məmmədova', N'Pediatr', '+994703456789'),
(N'Dr. Elvin Qasımov', N'Nevroloq', '+994504567890'),
(N'Dr. Fidan İbrahimova', N'Dermatoloq', '+994555678901')

insert into Patients(PatientName,Age,Gender,Phone)
values
(N'Əli Vəliyev', 34, 'Male', '+994509876543'),
(N'Aysel Kərimova', 28, 'Female', '+994558765432'),
(N'Məmməd Bağırov', 45, 'Male', '+994707654321'),
(N'Nigar Orucova', 12, 'Female', '+994506543210'),
(N'Zaur Sadıqov', 52, 'Male', '+994555432109')

select DoctorName,Specialization from Doctors
select PatientName,Age from Patients
select DoctorName,Phone from Doctors
select PatientName,Gender from Patients
select PatientName,Age from Patients where age>30
select DoctorName from Doctors where Specialization=N'Kardioloq'