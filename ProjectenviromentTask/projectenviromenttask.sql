IF OBJECT_ID('Assignment') IS NOT NULL DROP TABLE Assignment;
IF OBJECT_ID('Employee') IS NOT NULL DROP TABLE Employee;
IF OBJECT_ID('Office') IS NOT NULL DROP TABLE Office;

create table Office(
LocCode int
,Address nvarchar(50)
,description nvarchar(50) 
primary key(LocCode));

create table Employee(
StaffID int
,GivenName nvarchar(50)
,Surname nvarchar(50)
primary key(StaffID))

create table Assignment(
LocCode int
,StaffID int
,DateAssigned date
,foreign key(StaffID)references Employee
,foreign key(LocCode)references Office
,primary key(LocCode,StaffID,DateAssigned))