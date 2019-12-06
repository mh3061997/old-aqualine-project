use AquaLine
go

create proc getsuppliers
as
begin
select * 
from Suppliers
end
go

create proc deletesupplier @ProductName nvarchar(50)
as
begin
delete from Suppliers
where Name=@ProductName
end
go

create proc updatesupplier @supname nvarchar(50) ,@suplocation nvarchar(50),@supphonenumber nvarchar(50),@supemail nvarchar(50)
as 
begin 
update Suppliers
set  Name=@supname , Location=@suplocation , PhoneNumber=@supphonenumber, Email=@supemail
where Name=@supname
end
go

create proc insertsupplier @supname nvarchar(50) ,@suplocation nvarchar(50),@supphonenumber nvarchar(50),@supemail nvarchar(50)
as
begin
insert into Suppliers(Name,Location,PhoneNumber,Email)
values (@supname,@suplocation,@supphonenumber,@supemail)
end
go

exec getsuppliers
go

exec insertsupplier 'uksup','london','012222','uksup@gmail.com'
go

exec insertsupplier 'chinaltd','china','984220000','china_ltd_orders@yahoo.com'
go

exec insertsupplier 'egyptchemicals','cairo','01555','egypt@gmail.com'
go

exec getsuppliers
go

exec deletesupplier'uksup'
go

exec getsuppliers
go

exec updatesupplier'chinaltd','china','010','mh@hotmail.com'
go

exec getsuppliers
go
