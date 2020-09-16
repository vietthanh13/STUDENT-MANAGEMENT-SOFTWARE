use master
drop database SQLDBUI

go
drop table Users
drop table Major
drop table Score
drop table Semester
drop table Student
drop table Subjects
drop table Class

create database SQLDBUI
go

--Users
use SQLDBUI
go

--Users account
create table Users(
	userid int identity primary key,
	username nvarchar(100) not null unique,
	passwords nvarchar(100)not null ,
	auth nvarchar (100) not null,
	checkstatus nvarchar(100) not null,
);

go
--Major major
create table Major(
	majorid nvarchar(100) primary key,
	majorname nvarchar(100),
);

go
--Class book
create table Class(
	classid nvarchar(100) primary key,
	classname nvarchar(100)not null,
	trainsystem nvarchar(100) not null,
	yearofaddmission nvarchar(100) not null,
	wholesalenumber nvarchar(100) not null,
	majorid nvarchar(100) foreign key references Major(majorid)
);

go
--Student bill
create table Student(
	studentid int primary key,
	firstname nvarchar(100) not null,
	lastname nvarchar(100) not null,
	dayofbirth nvarchar(100) not null,
	sex nvarchar(100) not null,
	placeofbirth nvarchar(100) not null,
	userid int foreign key references Users(userid),
	classid nvarchar(100) foreign key references Class(classid)
);

go
--Subjects
create table Subjects(
	subjectid nvarchar(100) primary key,
	subjectname nvarchar(100) not null,
	credit nvarchar(100) not null,
);

go
--Score
create table Score(
	id int identity primary key,
	subjectid nvarchar(100) foreign key references Subjects(subjectid),
	studentid int foreign key references Student(studentid),
	score1 nvarchar(100),
	score2 nvarchar(100),
);

go
--Semester
create table Semester(
	id int identity primary key,
	subjectid nvarchar(100) foreign key references Subjects(subjectid),
	classid nvarchar(100) foreign key references Class(classid),
	semester nvarchar(100) not null,
	
);

go

--Insert Data
insert into Users values('giahuy17','123','admin','enable')
insert into Users values('quanghuy17','123','user','enable')
insert into Users values('vietthanh17','123','manager','enable')
insert into Users values('hoangminh17','123','user','enable')
insert into Users values('anhduy17','123','user','enable')
insert into Users values('thaibao17','123','user','enable')

insert into Major values('TI','Technology Information')
insert into Major values('B','Bank')
insert into Major values('EF','Economic Finance')

insert into Class values('17D1TH01','IT','University','2010','40','TI')
insert into Class values('17D1KT01','Economic','Colleges','2014','50','B')
insert into Class values('17D1B01','Bank','Colleges','2018','60','EF')

insert into Student values('175050032',N'Gia Huy',N'Nguyễn','1-1-1999','Male',N'Hồ Chí Minh',1,'17D1TH01')
insert into Student values('175050264',N'Quang Huy',N'Nguyễn','02-12-1999','Male',N'Hồ Chí Minh',2,'17D1KT01')
insert into Student values('175050001',N'Viết Thanh',N'Nguyễn','13-02-1998','Male',N'Hồ Chí Minh',NULL,'17D1B01')
insert into Student values('175050292',N'Hoàng Minh',N'Nguyễn','22-6-1998','Male',N'Hồ Chí Minh',4,'17D1TH01')
insert into Student values('175050251',N'Anh Duy',N'Nguyễn','30-11-1992','Male',N'Hồ Chí Minh',5,'17D1KT01')
insert into Student values('175050259',N'Thái Bảo',N'Nguyễn','24-03-1999','Male',N'Hồ Chí Minh',6,'17D1B01')

insert into Subjects values('JP01','Java Programming','3')
insert into Subjects values('ST01','Software Technology','3')
insert into Subjects values('AP01','Application Programming','3')

insert into Score values('AP01','175050032','8.0','9.0')
insert into Score values('ST01','175050264','7.0','7.5')
insert into Score values('JP01','175050001','8.0','8.5')
insert into Score values('AP01','175050292','8.2','7.2')
insert into Score values('ST01','175050251','6.0','6.3')
insert into Score values('JP01','175050259','5.0','8.5')

insert into Semester values('JP01','17D1TH01','II')
insert into Semester values('ST01','17D1KT01','IV')
insert into Semester values('AP01','17D1B01','I')


--test Data
begin
	declare @i int = 1
	while @i  < 13
	begin
		insert into Users values (N'US' + cast (@i as nvarchar(100)),N'nghuy0' + cast (@i as nvarchar(100)),N'admin',N'admin')
		set @i = @i + 1
	end
end
go

begin
	declare @i int = 1
	while @i  < 13
	begin
		insert into Major values (N'MJ' + cast (@i as nvarchar(100)),N'AT0' + cast (@i as nvarchar(100)))
		set @i = @i + 1
	end
end
go

select * from subjects
begin
	declare @i int = 1
	while @i  < 13
	begin
		insert into Subjects values (N'SJ' + cast (@i as nvarchar(100)),N'MATH0' + cast (@i as nvarchar(100)),3,cast (@i as int))
		set @i = @i + 1
	end
end
go

select * from class
begin
	declare @i int = 1
	while @i  < 13
	begin
		insert into Class values (N'CL' + cast (@i as nvarchar(100)),N'A0' + cast (@i as nvarchar(100)),'University',N'200' + cast (@i as nvarchar(100)),N'2' + cast (@i as nvarchar(100)),cast (@i as int))
		set @i = @i + 1
	end
end
go

select * from student
begin
	declare @i int = 1
	while @i  < 13
	begin
		insert into Student values (N'SD' + cast (@i as nvarchar(100)),N'GiaHuy' + cast (@i as nvarchar(100)),N'Nguyen' + cast (@i as nvarchar(100)),cast (@i as nvarchar(100)) + N'-3-1999',N'Male',N'HoChiMinh',cast (@i as int),cast (@i as int))
		set @i = @i + 1
	end
end
go
select * from score
begin
	declare @i int = 1
	while @i  < 13
	begin
		insert into Score values (cast (@i as int),cast (@i as int),cast (@i as nvarchar(100)),cast (@i as nvarchar(100)))
		set @i = @i + 1
	end
end
go

begin
	declare @i int = 1
	while @i  < 13
	begin
		insert into Semester values (cast (@i as int),cast (@i as int),N'' + cast (@i as nvarchar(100)))
		set @i = @i + 1
	end
end
go

select subjectid[SubjectID], subjectname[NameSubject], credit[Credit] from subjects
select users.userid,username,passwords,student.studentid,class.classid,firstname,lastname,sex,dayofbirth,placeofbirth,classname,major.majorid,majorname,score1,score2,subjectname,semester 
from Class,Major,Score,Semester,Student,Subjects,Users 
where users.userid = student.userid and class.majorid = major.majorid and student.classid = class.classid and score.studentid = student.studentid and score.subjectid = subjects.subjectid and semester.subjectid = subjects.subjectid and semester.classid = class.classid

select users.userid[UserID],username[Username],passwords[Password],auth[Authirities],student.studentid[StudentID],firstname[FirstName],lastname[LastName],sex[Sex],dayofbirth[DayOfBirth],placeofbirth[PlaceOfBirth]class.classid[ClassID],classname[ClassName] 
from Users,Student,Major,Class
where users.userid = student.userid and class.majorid = major.majorid and student.classid = class.classid
select subjectid, subjectname, credit from subjects
select * from subjects
select * from Users
select * from major
select * from score
select * from semester
select *From Class
select *from student
SELECT username,passwords from Users where username ='admin' and passwords = 'admin'
DELETE FROM score WHERE studentid='175050034'
DELETE FROM student WHERE userid='6'
DELETE FROM users where userid ='6'
UPDATE Users join Student, Major, Class SET username = '" + txtaddusername.Text + "', passwords = '" + txtaddpasswords.Text + "', auth = '" + txtaddauth.Text + "', firstname = N'" + txtaddfirstname.Text + "', lastname = N'" + txtaddlastname.Text + "', major = '" + txtaddmajor.Text + "', sex = '"+txtaddcbsex.Text+"', studentid = '"+ txtaddstudentid.Text+ "', dayofbirth = '" + txtadddayofbirth.Text+"' , classid = '"+txtaddclassid.Text + "', classname ='"+txtaddclassname.Text +"' , placeofbirth = '" + txtaddplaceofbirth.Text + "' 
UPDATE Table1   SET Table1.Column1 = 'name' FROM Table1 T1, Table2 T2 WHERE T1.id = T2.id and T1.id = '100'  
UPDATE Table2 SET Table2.EntityName = 'watch' FROM Table1 T1, Table2 T2 WHERE T1.id = T2.id and T1.id = '100'  COMMIT
UPDATE dbo.OrderItem
SET dbo.OrderItem.LastModifiedDate = GETDATE()
FROM dbo.OrderItem 
  INNER JOIN dbo.[Order] ON dbo.OrderItem.OrderId = dbo.[Order].Id 
WHERE dbo.[Order].OrderNumber = 542393
GO
UPDATE major SET majorid = '123', majorname = 'Banker' from major inner join class on major.majorid = class.majorid where class.majorid = '{123}'
select userid from users where username = 'hanhuy308'
select * from Users
select DISTINCT score.subjectid,subjectname,credit,score1,score2,semester,score.studentid from subjects,score,semester,class  where semester.subjectid = subjects.subjectid and semester.classid = class.classid and score.subjectid = subjects.subjectid and score.studentid = '175050032'
select DISTINCT score.subjectid,subjectname,credit,score1,score2,semester,score.studentid from subjects,score,semester,class where semester.subjectid = subjects.subjectid and semester.classid = class.classid and score.subjectid = Subjects.subjectid and score.studentid = '1750500032'
use SQLDBUI
select classid,classname,majorname from class,major where class.majorid = major.majorid
select users.userid,username,passwords,auth,studentid,firstname,lastname,dayofbirth,sex,placeofbirth,student.userid,class.classid,major.majorid,majorname from student,users,major,class where student.classid = class.classid and class.majorid = major.majorid and student.userid = users.userid
SELECT Users.userid,Users.username FROM Users WHERE Users.userid not in ( select Student.userid from Student where Student.userid is not null)
select classid,classname,majorname from class,major where class.majorid = major.majorid
UPDATE class
SET classid = 'test'
WHERE classid = 'test1'
UPDATE student
SET classid = 'test1'
WHERE classid is null
update Score set studentid = '175050033' where studentid is NULL
insert into class(classid,classname,trainsystem,yearofaddmission,wholesalenumber,majorid) values ('17D1TH01','Tech','University','2017','15','T')

