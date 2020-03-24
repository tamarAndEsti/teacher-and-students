--create database Esti_Tamar
use Esti_Tamar
create table subjects
(
subjectId int identity primary key,
subjectName varchar(30)
--parent
)
create table users
(
userId int identity primary key,
userFirstName varchar(30),
userLastName varchar(30),
userPassword varchar(30),
userEmail varchar(30),
userStatus int
)
create table questionOrAnswer
(
id int identity primary key,
subjectId int,
userId int,
txt varchar(max),
finish bit,--לשאול
listingDate datetime,
parentId int,
foreign key(subjectId) references subjects(subjectId),
foreign key(userId) references users(userId),
foreign key(id) references questionOrAnswer(id)
)
create table joinedFile
(
fileId int identity primary key,
joinedTo int,
filePath varchar(100),
foreign key(joinedTo) references questionOrAnswer(id)
)
alter table questionOrAnswer(
