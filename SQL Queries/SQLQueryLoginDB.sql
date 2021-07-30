use master
go
if exists (select name from sys.databases where name = 'loginDB')
begin
drop database login;
end
else
create database login
containment=none 
go
use loginDB
go

--Erstellen der Tabelle "userdata"

create table userdata
(
login varchar(50) constraint pk_login primary key,
passwort varchar(50),
vorname varchar(50),
nachname varchar(50),
email varchar(50),
typ varchar(50) constraint fk_typ foreign key (typ) references berechtigungen(typ)
);

--Einfügen von Daten in die Tabelle "userdata"

begin transaction
insert into userdata values('user1', 'pass1', 'Jürgen', 'Steinert', 'j.steinert@gmail.com', 'admin');
insert into userdata values('user2', 'pass2', 'Markus', 'Pocher', 'm.pocher@gmail.com', 'user');
insert into userdata values('user3', 'pass3', 'Erwin', 'Mahler', 'e.mahler@gmail.com', 'user');
commit;

--Erstellen der Tabelle "berechtigungen"

create table berechtigungen
(
typ varchar(50) constraint pk_typ primary key,
lesen bit,
schreiben bit,
benutzerverwaltung bit,
);

--Einfügen von Daten in die Tabelle "berechtigungen"

begin transaction
insert into berechtigungen values('admin', 1, 1, 1);
insert into berechtigungen values('user', 1, 1, 0);
commit;

--Hilfsabfragen

select * from userdata;
select * from berechtigungen;