use AquaLine
go

alter table ClientsOrders
add constraint CHK_PaymentMethod CHECK (PaymentMethod ='Cash' or PaymentMethod ='Credit' or PaymentMethod= 'Cheque')