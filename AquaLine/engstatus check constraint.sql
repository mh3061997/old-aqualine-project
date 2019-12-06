use AquaLine
go

Alter Table Assignments 

 add CONSTRAINT CHK_Status CHECK (Status ='active' or status ='Done')
