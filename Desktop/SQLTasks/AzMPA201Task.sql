create database AzMPA201DB;

use AzMPA201DB;

create table department(
id int identity primary key,
[name] nvarchar(255) not null unique
);

create table employees(
id int identity primary key,
Fullname nvarchar(255) not null,
age int not null check(age>=0),
email nvarchar(255) not null unique,
salary decimal(7,2) not null check(300<= salary and salary<=2000),
DepartmentId int foreign key references Department(id)
)

--drop table employees;

insert into department (name)
values ('Department1') , ('Department2'), ('Department3')


insert into employees (Fullname,age,email,salary,DepartmentId)
values ('Emrah' , 19, 'emrahakhmedzade2202@gmail.com', 2000,1),
('A' , 20, 'aaa@gmail.com', 1000,2),
('AA' , 21, 'aa@gmail.com', 1500,2)



select * from employees

update employees set salary = 1900
where id=3

select * from employees
where salary>=500 and salary<=1500


select e.id,e.Fullname,e.age,e.email,e.salary,e.DepartmentId,d.[name] as DepartmentName 
from employees as e
left join department as d
on e.DepartmentId = d.id