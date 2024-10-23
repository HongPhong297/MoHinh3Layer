-- T?o c? s? d? li?u StudentManagement
CREATE DATABASE StudentManagements;
GO

-- S? d?ng c? s? d? li?u v?a t?o
USE StudentManagements;
GO

-- T?o b?ng Faculty
CREATE TABLE Faculty (
    FacultyID INT PRIMARY KEY,
    FacultyName NVARCHAR(100) NOT NULL
);

-- T?o b?ng Major
CREATE TABLE Major (
    MajorID INT PRIMARY KEY,
    FacultyID INT,
    Name NVARCHAR(100) NOT NULL,
    FOREIGN KEY (FacultyID) REFERENCES Faculty(FacultyID) ON DELETE SET NULL ON UPDATE CASCADE
);

-- T?o b?ng Student
CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    AverageScore FLOAT,
    FacultyID INT,
    MajorID INT,
    Avatar NVARCHAR(255), -- ???ng d?n ?nh ho?c URL ?? l?u avatar c?a sinh vi�n
    FOREIGN KEY (FacultyID) REFERENCES Faculty(FacultyID) ON DELETE SET NULL ON UPDATE NO ACTION,
    FOREIGN KEY (MajorID) REFERENCES Major(MajorID) ON DELETE SET NULL ON UPDATE NO ACTION
);
-- Th�m d? li?u v�o b?ng Faculty
INSERT INTO Faculty (FacultyID, FacultyName) VALUES (1, N'Khoa C�ng Ngh? Th�ng Tin');
INSERT INTO Faculty (FacultyID, FacultyName) VALUES (2, N'Khoa Kinh T?');
INSERT INTO Faculty (FacultyID, FacultyName) VALUES (3, N'Khoa Ngo?i Ng?');


-- Th�m d? li?u v�o b?ng Major
INSERT INTO Major (MajorID, FacultyID, Name) VALUES (1, 1, N'Khoa H?c M�y T�nh');
INSERT INTO Major (MajorID, FacultyID, Name) VALUES (2, 1, N'K? Thu?t Ph?n M?m');
INSERT INTO Major (MajorID, FacultyID, Name) VALUES (3, 2, N'Qu?n Tr? Kinh Doanh');
INSERT INTO Major (MajorID, FacultyID, Name) VALUES (4, 2, N'K? To�n');
INSERT INTO Major (MajorID, FacultyID, Name) VALUES (5, 3, N'Ti?ng Anh Th??ng M?i');
INSERT INTO Major (MajorID, FacultyID, Name) VALUES (6, 3, N'Ng�n Ng? Anh');


-- Th�m d? li?u v�o b?ng Student
INSERT INTO Student (StudentID, FullName, AverageScore, FacultyID, MajorID, Avatar)
VALUES (1, N'Nguy?n Th�y Lan', 8.5, 1, 1, 'avatar1.jpg');

INSERT INTO Student (StudentID, FullName, AverageScore, FacultyID, MajorID, Avatar)
VALUES (2, N'Tr?n Anh Thi', 7.8, 1, 2, 'avatar2.jpg');

INSERT INTO Student (StudentID, FullName, AverageScore, FacultyID, MajorID, Avatar)
VALUES (3, N'L� Ki?u Vy', 9.0, 2, 3, 'avatar3.jpg');

INSERT INTO Student (StudentID, FullName, AverageScore, FacultyID, MajorID, Avatar)
VALUES (4, N'Ph?m Ho�ng Lan Anh', 7.5, 2, 4, 'avatar4.jpg');

INSERT INTO Student (StudentID, FullName, AverageScore, FacultyID, MajorID, Avatar)
VALUES (5, N'Ho�ng Th�y Tr�m', 8.0, 3, 6, 'avatar5.jpg');

select * from Student
select * from Major
select * from Faculty


DELETE FROM Student;
DELETE FROM Major;
DELETE FROM Faculty;

ALTER TABLE Student
ALTER COLUMN MajorID INT NULL;
