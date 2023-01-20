create DATABASE Trainerdbase;

create table TrainerDetails(
    user_id varchar(200) PRIMARY KEY,
    Name VARCHAR(MAX),
    Age int ,
    Gender VARCHAR(MAX),
    EmailID VARCHAR(MAX),
    PhoneNumber VARCHAR(10),
    Location VARCHAR(30)
); 

alter table TrainerDetails
add [Password] VARCHAR(200);

create table Education_Details(
 user_id VARCHAR(200) PRIMARY Key,
 institutionName VARCHAR(20),
 Degree VARCHAR(10),
 Specialization VARCHAR(20),
 PassingYear VARCHAR(MAX),
 CONSTRAINT [FK-education] FOREIGN Key(user_id) REFERENCES TrainerDetails(user_id) ON DELETE CASCADE ON UPDATE CASCADE
);


select *  from TrainerDetails
create table Skills_Details(
    user_id VARCHAR(200) PRIMARY Key,
    Skill1 VARCHAR(10),
    Skill2 VARCHAR(10),
    Skill3 VARCHAR(10),
   
    CONSTRAINT [FK-skill] FOREIGN KEY(user_id) REFERENCES TrainerDetails(user_id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Company_Detail(
    user_id VARCHAR(200) PRIMARY  KEY,
    CompanyName varchar(25),
    Experience VARCHAR(25),
    Position VARCHAR(25),
    Constraint [Fk_CompanyDetails] FOREIGN KEY(user_id) REFERENCES TrainerDetails(user_id) ON DELETE CASCADE ON UPDATE CASCADE
);

select * from TrainerDetails

