Create table Employees(
id int primary key identity,
FirstName nvarchar(20),
LastName nvarchar(20),
Salery int
)
Go
Insert into Employees values('Nikola','Nikolic','300')
Insert into Employees values('Nikola','Stankovic','350')
Insert into Employees values('Marija','Nikolic','800')
Insert into Employees values('Marija','Saric','500')
Insert into Employees values('Milica','Taskovic','500')
Insert into Employees values('Milica','Stankovic','600')
Insert into Employees values('Stevan','Sindjelic','1300')
Go