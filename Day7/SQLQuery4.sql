use pubs

--1
select au_lname,au_fname from authors
--2
select title from titles order by title desc

--8
select title from titles where title like '%and%'
--7
select price from titles where title like '%s'

--9
select pub_name,fname from publishers join employee on
publishers.pub_id = employee.pub_id

--12
select pub_name,fname from publishers join employee on
publishers.pub_id = employee.pub_id
where pub_name='Algodata Infosystems'

--3
select  distinct title_id,count(*) as Number_of_titles from titleauthor group by title_id
--4
select distinct au_fname,au_lname, title from authors,titles

--5
select * from titles
select pub_name,avg(advance) AveRage from titles, publishers group by pub_name

--6
select pub_name,au_fname as FIrstN, au_lname as Lastn, title, qty*price as SaleAmount from 
authors, publishers p join titles t on p.pub_id=t.pub_id join sales s on t.title_id=s.title_id
--11
select pub_name,au_fname from authors,publishers where pub_name='Algodata Infosystems'
--10
