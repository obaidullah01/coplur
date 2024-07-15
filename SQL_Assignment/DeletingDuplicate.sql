create Schema deletedup;

create table deletedup.tab(
id int identity(101,1) primary key,
name varchar(15),
age int,
country varchar(25),
);

alter table deletedup.tab
alter column country varchar(25)

insert into deletedup.tab
values
('Obaid',15,'India'),
('Steve',75,'America'),
('Tony',45,'America');

insert into deletedup.tab
values
('Xia',95,'China');


select * from deletedup.tab;

select name,age,country,
count(*) from deletedup.tab
GROUP BY name,age,country
Having count(*)>1;

delete from deletedup.tab
where id not in(
select min(id)
from deletedup.tab
GROUP BY name,age,country
);

create table deletedup.sub(
Subject varchar(15),
age int,
Driving varchar(25),
);

insert into deletedup.sub
values
('Math',15,'No'),
('Physics',75,'yes'),
('Chemistry',75,'yes'),
('History',75,'yes'),
('Biology',45,'yes');

alter table deletedup.sub
rename column age to newage;

select * from deletedup.tab;
select * from deletedup.sub;


Select deletedup.tab.name,deletedup.tab.age,deletedup.sub.Subject,deletedup.sub.age 
from deletedup.tab inner join deletedup.sub 
on deletedup.tab.age = deletedup.sub.age


create table deletedup.tab1(
Subject varchar(15),
age int,
Driving varchar(25),
);

select * from deletedup.tab;
select * from deletedup.sub;



select id,name,country,
count(*) from  deletedup.tab
GROUP BY id,name,country;