create database Coplur;

create schema iFile;

select * from iFile.cse;

alter table iFile.cse
Drop column column7;

delete from iFile.cse
where S_No is null;