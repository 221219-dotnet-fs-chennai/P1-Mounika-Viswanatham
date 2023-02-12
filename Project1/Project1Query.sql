create DATABASE Trainerdatabase;

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
alter table Company_Detail Drop COLUMN Position;

insert into TrainerDetails VALUES('mounika','Mounika',23,'Female','mounikav.199@gmail.com','8367506198','Chennai','Mounika@123')
insert into TrainerDetails VALUES('chintu','Rajasekhar',23,'Male','chintu@gmail.com','7896547896','USA','Chintu@123')
insert INTO TrainerDetails VALUES('uma','UmaDevi',35,'Female','uma@gmail.com','9704203481','Guntur','Umadevi@123')
insert into TrainerDetails VALUES('kishore','Kishore',32,'Male','kishore@gmail.com','9441504661','Guntur','Kishore@123')
insert into TrainerDetails VALUES('mahi','Mahesh',22,'Male','mahesh@gmail.com','9100112056','Chennai','Mahi@123')


update TrainerDetails set Age=31 where Name='Rajasekhar'
update TrainerDetails set Age=30  where Name='Mounika'
update TrainerDetails set Age=31 where Name='Mahesh'

insert into Skills_Details VALUES('mounika','Java','Dotnet','Angular')
insert into Skills_Details VALUES('chintu','Python','Java','Dotnet')
INSERT INTO Skills_Details VALUES('uma','C#','java','Python')
insert into Skills_Details VALUES('kishore','Angular','React','Java')
insert into Skills_Details VALUES('mahi','C++','Python','Java')


insert into Education_Details VALUES('mounika','VVIT','BTECH','IT','2022')
insert into Education_Details VALUES('chintu','VVIT','BTECH','IT','2022')
insert into Education_Details VALUES('uma','KVR','BTECH','ECE','2018')
insert into Education_Details VALUES('kishore','VIT','BTECH','CSE','2018')
insert into Education_Details VALUES('mahi','RVRJC','BSC','Computers','2022')


insert into Company_Detail VALUES('uma','Intellect',5)
insert into Company_Detail VALUES('kishore','TCS',5)
insert into Company_Detail VALUES('mounika','Wipro',1)
insert into Company_Detail VALUES('chintu','CTS',1)
insert into Company_Detail VALUES('mahi','NA',0)

select *  from TrainerDetails 
select * from Skills_Details 
select * from Company_Detail
select * from Education_Details 


