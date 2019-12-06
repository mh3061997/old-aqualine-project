use AquaLine
go
create proc getmostordereditem
as
begin
select Product_Name ,Sum(Quantity)
from Includes_Clientorder_Item
group by Product_Name
order by Sum(Quantity) DESC
end
go