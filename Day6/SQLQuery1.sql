create database dbsofturatraining

use dbsofturatraining

create table tblSample(
id int,
name varchar(20)
)

select*from tblSample

sp_help tblSample

drop table tblSample

create table skill(
skill_name varchar(20) primary key,
skill_description text
)

sp_help skill

create table cities(
zip_codes char(4) primary key,
city varchar(20)
)

sp_help cities

create table employee(
id char(4) primary key,
Name varchar(20) not null,
phone varchar(15) not null,
zip char(4) references cities(zip_codes)
)

sp_help employee

create table employee_skills(
emp_id char(4) references employee(id),
skill_name varchar(20) references skill(skill_name),
skill_level float default 1,
constraint pk_empskill primary key(emp_id,skill_name)
)

sp_help employee_skills

insert into skill values('c','PLT')
insert into skill values('c++','OOPS')
insert into skill values('Java','WEB')

select * from skill