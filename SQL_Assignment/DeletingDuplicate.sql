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

