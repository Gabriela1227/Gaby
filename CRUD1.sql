create database Practica1
go
use Practica1

create table Productos1
(
Id int identity (1,1) primary key,
Nombre nvarchar (100),
Descripcion nvarchar (100),
Marca nvarchar (100),
Precio float,
Stock int
)

insert into Productos1 values ('Gaseosa','3 litros','marcacola',7.5,24),
('Chocolate','Tableta 100 gramos','iberica',12.5,36),
('Leche','Deslactosada','supervaca',3,48),
('Mazamorra','Bolsa 1 kg','standar',2.0,24),
('Harina','bolsa 1 kg','Purotrigo',3.5,24),
('Nectar','1 litro','alljugos',4.5,20),
('Aceite','1 litro','cocinero',7.5,24)

select * from Productos1
