create DATABASE Trainersdb;

create table User_Details(
    user_id int IDENTITY(1,1) PRIMARY KEY,
    User_Name VARCHAR(MAX),
    Age int ,
    Gender VARCHAR(5),
    Email_Id VARCHAR(MAX),
    Phonenumber VARCHAR(10),
    Location_Name VARCHAR(30)
);

create table Education_Details(
 user_id int PRIMARY Key,
 institution_name VARCHAR(20),
 Degree_Name VARCHAR(10),
 Specialization VARCHAR(20),
 CGPA FLOAT,
 Passing_Year int,
 CONSTRAINT [FK-edu] FOREIGN Key(user_id) REFERENCES User_Details(user_id) ON DELETE CASCADE ON UPDATE CASCADE
);

create table Skills(
    user_id int PRIMARY Key,
    Skill_Name1 VARCHAR(10),
    Skill_Name2 VARCHAR(10),
    Skill_Name3 VARCHAR(10),
    Skill_Name4 VARCHAR(10),
    CONSTRAINT [FK-skills] FOREIGN KEY(user_id) REFERENCES User_Details(user_id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Company(
    user_id int PRIMARY  KEY,
    Company_name varchar(25),
    Experience VARCHAR(25),
    Position VARCHAR(25),
    Constraint [Fk_Company] FOREIGN KEY(user_id) REFERENCES User_Details(user_id) ON DELETE CASCADE ON UPDATE CASCADE
);

