use AquaLine

alter table ClientsOrders
add constraint CHK_date CHECK (IssueDate < DueDate)