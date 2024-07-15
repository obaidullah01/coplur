create table OrderTable(
TransectionID int Identity(1023,1),
TransectionDate varchar(50),
UserId int,
Amount int,
QTY int);

Insert into OrderTable
values
('01 July 2024',1,100,10),
('01 August 2024',2,1000,9),
('01 August 2024',3,100,8),
('01 July 2024',2,1000,7),
('01 July 2024',3,100,6),
('01 September 2024',3,1000,5),
('01 September 2024',4,820,4),
('01 July 2024',5,89714,3),
('01 August 2024',6,97428,2),
('01 September 2024',8,105142,1),
('01 September 2024',9,112057,0);

create table UserInfo(
UserId int Identity(1,1),
FirstName varchar(25),
Mobnum bigint);


insert into UserInfo
values
('Harsh',5465464654),
('Drishti',867267627),
('Shailja',5425454524),
('Deeoa',545785854),
('Obaid',867825452),
('Divyansh',9755325725),
('Chandragupt',785425878),
('Aryan',978575545);

select * from OrderTable;
select * from UserInfo;


Select OrderTable.UserId,UserInfo.FirstName,count(1) as TransectionCount,sum(OrderTable.Amount) as totalAmount,sum(OrderTable.QTY) as totalQTY
from UserInfo left join OrderTable on UserInfo.UserId = OrderTable.UserId
group by OrderTable.UserId,UserInfo.FirstName
Order by (4) DESC;