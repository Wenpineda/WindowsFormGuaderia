create database BDDguarderia

use BDDguarderia

create table ni�os(
idni�os int identity(1,1) NOT NULL PRIMARY KEY,
nombre varchar(50) not null,
apellido varchar(50) null,
edad int not null,
sexo varchar (50),
);

insert into ni�os values ('Juanito','Lopez',5, 'masculino');
insert into ni�os values ('Marta','Ramos',5, 'femenino');

select *from ni�os
