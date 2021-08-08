CREATE DATABASE DefineLabsDB

USE DefineLabsDB



CREATE TABLE AUTHOR
(
AuthorID int identity(1,1) primary key,
FirstName varchar(30),
LastName varchar(30),
DateOfBirth date
)


CREATE TABLE BOOK
(
BookID int identity(1,1) primary key,
BookTitle varchar(100),
AuthorID int
)

insert into AUTHOR values ('R D','Sharma','05-01-1960')
insert into AUTHOR values ('Deepika','Yadav','07-08-1965')
insert into AUTHOR values ('Thomas','Cormen','06-3-1978')
insert into AUTHOR values ('Sanal','Thomas','08-12-1983')
insert into AUTHOR values ('Dan','hunstad','10-07-1970')
insert into AUTHOR values ('Todd','Hazen','11-5-1986')
insert into AUTHOR values ('Todd','Rasmus','06-11-1969')
insert into AUTHOR values ('Jeff','schmidtz','02-08-1956')
insert into AUTHOR values ('Anto','Thokkadam','6-04-1990')
insert into AUTHOR values ('Benny','Chan','09-06-1985')



insert into BOOK values ('Trigonometry','1')
insert into BOOK values ('AdvancedTrigonometry','1')
insert into BOOK values ('AdvancedTrigonometry','2')
insert into BOOK values ('Advanced Control Systems','6')
insert into BOOK values ('Advanced Control Systems','7')
insert into BOOK values ('Advanced Control Systems','8')
insert into BOOK values ('Electrical and Electronics Measurement','3')
insert into BOOK values ('Data Mining','4')
insert into BOOK values ('Network Theory','8')
insert into BOOK values ('Organizational Behaviour','9')
insert into BOOK values ('Data Mining','6')
insert into BOOK values ('Imperative Programming','6')
insert into BOOK values ('Network Theory','6')
insert into BOOK values ('Advanced Control Systems','2')


select * from AUTHOR
select * from BOOK


--------*********************Get Book List*********************---------------------------------

CREATE PROCEDURE GETBookList
AS
BEGIN
select BookID,BookTitle,AuthorID from BOOK
END


--------*********************Get Author List*********************---------------------------------
CREATE PROCEDURE GetAuthorList
AS
BEGIN
select AuthorID,FirstName,LastName,DateOfBirth from AUTHOR
END
--drop table BOOK
--drop table AUTHOR


--------*********************Get Author/Book Detial By ID*********************---------------------------------
CREATE PROCEDURE GETAuthorBookByID --10
(@authorID int)
AS
BEGIN
select a.AuthorID,a.FirstName,a.LastName,a.DateOfBirth,b.BookID,b.BookTitle from AUTHOR a 
LEFT OUTER JOIN BOOK b on a.AuthorID=b.AuthorID
Where a.AuthorID=@authorID
END



------------------------************------------------------
CREATE PROCEDURE GetAuthors
AS
BEGIN
select AuthorID,FirstName+ ' '+ LastName as AuthorName from AUTHOR
END
--****************************************************************--
CREATE PROCEDURE GETBookByID --1
(@bookID int)
AS
BEGIN
select BookID,BookTitle,AuthorID from Book
Where BookID=@bookID
END


select * from AUTHOR
select  * from BOOK

--------*********************Add Author*********************---------------------------------

CREATE PROCEDURE AddAuthor
(@firstName varchar(30),
@lastName varchar(30),
@dateOfBirth datetime)
AS
BEGIN
Insert into AUTHOR values(@firstName,@LastName,@DateOfBirth)
END

---------*********************Delete Author By ID*********************----------------------------------

CREATE PROCEDURE DeleteAuthorByID --9
(@AuthorID int)
AS
BEGIN
delete from AUTHOR where AuthorID=@AuthorID
END


---------*********************Edit Author By ID*********************----------------------------------

CREATE PROCEDURE UpdateAuthorByID 
(@authorID int,
@firstName varchar(30),
@lastName varchar(30),
@dateOfBirth datetime
)
AS
BEGIN
UPDATE AUTHOR set FirstName=@firstName,LastName=@lastName,DateOfBirth=@dateOfBirth where AuthorID=@AuthorID
END



---------*********************Edit Book By ID*********************----------------------------------

CREATE PROCEDURE UpdateBookByID 
(@bookID int,
@bookTitle varchar(100)
)
AS
BEGIN
UPDATE BOOK set BookTitle=@bookTitle where BookID=@bookID
END


--------*********************Add Book*********************---------------------------------

CREATE PROCEDURE AddBook
(@bookTitle varchar(100),
@AuthorID int)
AS
BEGIN
Insert into BOOK values(@bookTitle,@AuthorID)
END


select * from BOOK
-------------------------------------------------

CREATE PROCEDURE AddBook
(@BookTitle varchar(200),
@AuthorIDs varchar(30)
)
AS
BEGIN

Insert into BOOK values (@BookTitle,@AuthorID)
END

--------*********************Delete Book*********************---------------------------------

CREATE PROCEDURE DeleteBook
(@BookID int)
AS
BEGIN
Delete from BOOK where BookID=@BookID
END


