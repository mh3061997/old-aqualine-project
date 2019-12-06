use AquaLine
go

create proc getwarehouse
as
begin
select * 
from Warehouse
end
go

create proc deletewarehouse @branch nvarchar(50)
as
begin
delete from Warehouse
where Branch_Name=@branch
end
go

create proc updatewarehousecapacity @branchname nvarchar(50) ,@capacity int
as 
begin 
update Warehouse
set  Capacity=@capacity
where Branch_Name=@branchname
end
go

create proc insertwarehouse @branchname nvarchar(50) ,@capacity int
as
begin
insert into Warehouse(Branch_Name,Capacity)
values (@branchname,@capacity)
end
go

exec getwarehouse
go

exec deletewarehouse 'Cairo'
go

exec getwarehouse
go

exec insertwarehouse 'shobra',50
go

exec getwarehouse
go


