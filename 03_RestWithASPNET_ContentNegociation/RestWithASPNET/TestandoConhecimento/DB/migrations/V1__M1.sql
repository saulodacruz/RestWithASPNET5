IF OBJECT_ID (N'dbo.books') IS NULL
create table Books 
(
	id int identity(1,1) primary key,
	name varchar(100)
)

IF OBJECT_ID (N'dbo.Person') IS NULL
create table Person
(
	id int identity(1,1) primary key,
	name varchar(50),
	age int,
	birthData datetime
)