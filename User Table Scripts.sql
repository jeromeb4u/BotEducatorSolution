create database BotEducator
GO

use BotEducator
GO

create table Users(
[UserId] int Primary Key IDENTITY,
[UserName] varchar(50),
[EmailId] varchar(50),
[Password] varchar(50)
)
GO

insert into Users([UserName],[EmailId],[Password]) values('admin','admin@infosys.com','admin')
GO

insert into Users([UserName],[EmailId],[Password]) values('a','a@a.com','a')
GO
