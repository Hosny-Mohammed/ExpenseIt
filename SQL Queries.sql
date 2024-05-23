Create database ExpenseIt

create Table expense_report(
	ID int Primary Key Identity(1,1),
	Name_ nvarchar(150) not null,
	Expense_Type nvarchar(150) not null,
	Amount int not null,
	Department nvarchar(150) not null
);

insert into expense_report
values
('Lisa','Document printing',50,'Marketing'),
('Lisa','Gift',125,'Marketing'),
('Mike','Server',5,'IT'),
('Mike','Projector',20,'IT'),
('John','Papers',500,'Financial')

select * from expense_report