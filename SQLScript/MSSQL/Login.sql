--CREATE LOGIN [posusr] WITH PASSWORD = 'posusr';

create table tuser(
username varchar(20) primary key,
password varchar(100),
userrole varchar(10)
);

insert into tuser values('kevin','kevin','manager');

select * from tuser;


--CREATE USER [posusr]
--	for login posusr
--	WITH DEFAULT_SCHEMA = dbo

--use posdb
--go
--GRANT create table TO [posusr];
--go
grant create view to [posusr];
go

grant select  to posusr;
	go
	grant showplan to posusr;
		go
--

grant view any DATABASE to posusr;
	go


	EXEC sp_addrolemember 'db_owner','posusr';
	go


	alter LOGIN [sa]
    WITH PASSWORD = N'sa';


GO
ALTER LOGIN [sa] enable;