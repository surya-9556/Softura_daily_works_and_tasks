use pubs

create table tblMovie
(id int identity(1,1) primary key,
name varchar(20),
duration float)

select * from tblMovie

update tblMovie set name = 'x-men first class' where id = '9'

insert into tblMovie(name,duration) values('x-men',123.2)