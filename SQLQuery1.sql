CREATE DATABASE Quiz_Management_System
USE Quiz_Management_System

---------------------------------------------TABLES---------------------------------------------
CREATE TABLE Subjects(
Id int identity PRIMARY KEY,
[Name] nvarchar(max) not null
)

CREATE TABLE Questions(
Id int identity PRIMARY KEY,
Subject_id int references Subjects(Id),
[Content] nvarchar(max) not null,
Answer1 nvarchar(max) not null,
Answer2 nvarchar(max) not null,
Answer3 nvarchar(max) not null,
Answer4 nvarchar(max) not null,
CorrectAnswer nvarchar(max) not null
)

insert into Questions values
(1,'sual4', 'cavab1', 'cavab2', 'cavab3', 'cavab4', 'cavab3')

CREATE TABLE Lecture(
Id int identity primary key,
[Data] varbinary(max),
Extension char(4),
[FileName] nvarchar(max),
Subject_id int references Subjects(Id)
)

CREATE TABLE Groups(
Id int identity PRIMARY KEY,
Group_no nvarchar(max) not null,
Specialty nvarchar(max) not null
)

CREATE TABLE Students(
Id int identity PRIMARY KEY,
Group_id int not null references Groups(Id),
[Name] nvarchar(20) not null,
Surname nvarchar(30) not null,
Age int

)

ALTER TABLE Students
ADD Email nvarchar(50);

ALTER TABLE Students
ADD [Password] nvarchar(50);


CREATE TABLE SubjectStudent(
Id int identity,
Student_id int not null references Students(Id),
Subject_id int not null references Subjects(Id),
Score int not null
)


CREATE TABLE Teachers(
Id int IDENTITY PRIMARY KEY,
[Name] nvarchar(40) not null,
Surname nvarchar(70) not null,
Number int not null,
Email nvarchar(100) UNIQUE not null,
[Password] nvarchar(max) not null
)


----------------------CHECK QUERIES------------------------------
SELECT * FROM Subjects

SELECT sub.Name Subject_name, que.Content, que.Answer1, que.Answer2, que.Answer3, que.Answer4, que.CorrectAnswer  FROM Subjects sub
inner join Questions que
on que.Subject_id = sub.Id



SELECT * FROM Groups
SELECT gr.Group_no, gr.Specialty, stu.Name, stu.Surname, stu.Age FROM Groups gr
INNER JOIN Students stu
on stu.Group_id=gr.Id

SELECT sub.Name Subject_name, stu.Name Student_name, stu.Surname Student_surname, stu.Age Student_age, gr.Group_no, ss.Score FROM Subjects sub
INNER JOIN SubjectStudent ss
on ss.Subject_id = sub.Id
INNER JOIN Students stu
on stu.Id = ss.Student_id
inner join Groups gr
on gr.Id = stu.Group_id


SELECT * FROM Lecture
select * from Subjects


SELECT stu.Name, stu.Surname, stu.Email, g.Group_no, sub.Name Subject, ss.Score FROM SubjectStudent ss 
INNER JOIN Students stu 
ON ss.Student_id=stu.Id 
INNER JOIN Groups g 
ON stu.Group_id=g.Id 
INNER JOIN Subjects sub 
ON ss.Subject_id=sub.Id


INSERT INTO SubjectStudent(Score) VALUES(10) 
SELECT stu.Name, stu.Surname, stu.Email, g.Group_no, sub.Name Subject, ss.Score FROM SubjectStudent ss 
INNER JOIN Students stu 
ON ss.Student_id=stu.Id 
INNER JOIN Groups g 
ON stu.Group_id=g.Id 
INNER JOIN Subjects sub 
ON ss.Subject_id=sub.Id
WHERE stu.Email LIKE 'neliyeva222@naa.edu.az%'



INSERT INTO SubjectStudent(Score) VALUES(10) 
SELECT stu.Name, stu.Surname, stu.Email, g.Group_no, sub.Name Subject, ss.Score FROM SubjectStudent ss 
INNER JOIN Students stu 
ON ss.Student_id=stu.Id 
INNER JOIN Groups g 
ON stu.Group_id=g.Id 
INNER JOIN Subjects sub 
ON ss.Subject_id=sub.Id
WHERE stu.Email LIKE 'neliyeva222@naa.edu.az%'



INSERT INTO SubjectStudent(Student_id, Subject_id, Score) VALUES(
(SELECT Students.Id from Students where Students.Email like 'neliyeva222@naa.edu.az%'), (SELECT Subjects.Id FROM Subjects WHERE Subjects.Name LIKE 'Sistem muhendisliyi%'), 10) 




SELECT stu.Name, stu.Surname, stu.Email, g.Group_no, sub.Name Subject, ss.Score FROM SubjectStudent ss 
INNER JOIN Students stu 
ON ss.Student_id=stu.Id 
INNER JOIN Groups g 
ON stu.Group_id=g.Id 
INNER JOIN Subjects sub 
ON ss.Subject_id=sub.Id


SELECT * FROM Subjects