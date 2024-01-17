--create table Groups
--(
--ID int not null identity(1,1) primary key,
--Name nvarchar(10) not null unique,
--Rating int not null check(Rating between 0 and 5),
--Year int not null check(Year between 1 and 5)
--)

--create table Departments
--(
--ID int not null identity(1,1) primary key,
--Financing money not null check(Financing > 0) default(0),
--Name nvarchar(100) not null unique,
--)

--create table Faculties
--(
--ID int not null identity(1,1) primary key,
--Name nvarchar(100) not null unique,
--)

--create table Teachers
--(
--ID int not null identity(1,1) primary key,
--EmploymentDate date not null check (EmploymentDate > '01.01.1990'),
--Name nvarchar(100) not null,
--Premium money not null check(Premium > 0) default(0),
--Salary money not null check(Salary > 0),
--Surname nvarchar(max) not null
--)

insert into Groups (Name,Rating,Year)
values ('mama',4,2024)