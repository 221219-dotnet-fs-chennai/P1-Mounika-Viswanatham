create database Challengedb;

create table employee
(Id int not null PRIMARY KEY,
FirstName Varchar(max),
LastName Varchar(max),
SSN int,
depId Int  FOREIGN KEY REFERENCES Department(depId)
);


create table Department (
depId int PRIMARY KEY,
depname varchar(max),
deploc varchar(max)

);
-- employee_details table
Create table empDetails(
empdepId int PRIMARY KEY,
empId int FOREIGN KEY REFERENCES employee(Id),
salary float,
address1 varchar(max),
address2 varchar(max),
city varchar(20),
state varchar(20),
country varchar(20)


);

-- Insertion of values

Insert into Department 
values (102,'developer', 'Chennai'),
(103,'tester', 'Chennai'), 
(104,'trainer', 'Chennai');
insert into Department values(105,'marketing','guntur');

Insert into employee
values
(1001,'mouni','vissu',0110123,102),
(1000,'chintu','tangirala',0112203,103),
(1050,'mahi','sangu',022334,104);

insert into employee values(1004,'tina','smith',123456,105);


Insert into empDetails
values (101,1001,12000,'oldguntur','lakshmi nagar','guntur','andhrapradesh','india'),
(105,1000,12000,'oldguntur','balajinagarr','guntur','andhrapradesh','india'),
(103,1050,12000,'oldguntur','rtc colony','guntur','andhrapradesh','india')
insert into empDetails 
values (104,1004,12000,'oldguntur','rtc colony','guntur','andhrapradesh','india');



select * from department;
select * from employee;
select * from empDetails;


select FirstName as FirstName, LastName,d.depID,d.depName from employee e
inner join department d on e.depId=d.depId
where d.depname='Marketing';



select sum(salary)as totalSalaryOfMarketing from empDetails e
where e.empId in (select e.id from employee e
inner join department d on e.depId=d.depId
where d.depName='Marketing');



select Count(*) as EmployeeCount, d.depName from employee e
inner join department d on e.depId=d.depId
group by d.depName;


update empDetails
set salary =90000
from employee e
inner join empDetails ed on e.id=ed.empId
where e.FirstName like 'tina';

alter table empDetails alter column  salary float;