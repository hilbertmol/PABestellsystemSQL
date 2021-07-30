use managementDB
go

--Erstellen einer Tabelle "bestellungen"

create table bestellungen
(
	bestellungsnr int constraint pk_bestellungen primary key,
	kundennr int,
	produktnr int,
	datum datetime
);

--Erstellen einer Tabelle "kunden"

create table kunden
(
	kundennr int constraint pk_kunden primary key,
	vorname varchar(50),
	nachname varchar(50),
	email varchar(50),
	telefon varchar(50),
	strasse varchar(50),
	hausnr int,
	plz varchar(5),
	ort varchar(50),
);

--Erstellen einer Tabelle "produkte"

create table produkte
(
	produktnr int constraint pk_produkte primary key,
	produktname varchar(50),
	preis numeric(7,2),
	beschreibung varchar(50),
	hersteller varchar(50),
	kategorie varchar(50),
	stueckzahl int
);

--Einfügen von Fremdschlüsseln in der Tabelle "bestellungen": fk_kundennr und fk_produktnr

alter table bestellungen add constraint fk_kundennr foreign key (kundennr) references kunden(kundennr);
alter table bestellungen add constraint fk_produktnr foreign key (produktnr) references produkte(produktnr);

--Select all from kunden

create procedure [dbo].[GetAllFromKunden]
as
begin
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	set nocount on;
	select * 
	from dbo.kunden 
end
go

--select from kunden, nach kundenname

set ansi_nulls on
go
set quoted_identifier on
go

create procedure [dbo].[GetByKName]
	@kname varchar(10)
as
begin
	set nocount on;
	select * 
	from dbo.kunden 
	where nachname = @kname;
end
go

--Insert into kunden

set ansi_nulls on
go
set quoted_identifier on
go

create procedure [dbo].[InsertKunde]
	@kundennr int, @vorname varchar(50), @nachname varchar(50), @email varchar(50), @telefon varchar(50), 
	@strasse varchar(50), @hausnr int, @plz varchar(5), @ort varchar(50)
as
begin
	set nocount on;
	insert into kunden VALUES (@kundennr, @vorname, @nachname, @email, @telefon, 
	@strasse, @hausnr, @plz, @ort);
end
go


insert into kunden VALUES (1, 'George', 'Ward', 'g.ward@gmail.com', '015212334022', 'Herdweg', 12, '70174', 'Stuttgart');
insert into kunden VALUES (2, 'Markus', 'Nehring', 'm.nehring@gmx.de', '015012334004', 'Rosenbergstr.', 102, '78043', 'Mannheim');
insert into kunden VALUES (3, 'Tobias', 'Müller', 'm.nehring@gmx.de', '017088721124', 'Schönhauser Allee', 44, '78043', 'Berlin');
insert into kunden VALUES (4, 'David', 'Moritz', 'd.moritz@gmx.de', '017088721009', 'Lindenstr.', 89, '50674', 'Köln');
insert into kunden VALUES (5, 'Martin', 'Wolf', 'm.wolf@yahoo.com', '012012257296', 'Blumenstr.', 47, '80469', 'München');

--select from bestellungen

set ansi_nulls on
go
set quoted_identifier on
go

create procedure [dbo].[GetByBNr]
	@bnr int
as
begin
	set nocount on;
	select * 
	from dbo.buchungen
	where buchungsnr = @bnr;
end
go

--Insert into bestellungen

create procedure [dbo].[InsertBestellung]
	@bestellungsnr int, @kundennr int, @produktnr int, @datum datetime
as
begin
	set nocount on;
	insert into buchungen VALUES (@bestellungsnr, @kundennr, @produktnr, @datum);
end
go

insert into bestellungen VALUES (1, 1, 5, '20.05.2021 14:14:56');
insert into bestellungen VALUES (2, 2, 1, '23.05.2021 10:14:00');
insert into bestellungen VALUES (3, 2, 2, '6.05.2021 12:14:00');
insert into bestellungen VALUES (4, 3, 5, '23.01.2021 10:09:00');
insert into bestellungen VALUES (5, 4, 1, '8.04.2021 12:56:00');

--select from produkte

set ansi_nulls on
go
set quoted_identifier on
go

create procedure [dbo].[GetByPNr]
	@pnr int
as
begin
	set nocount on;
	select * 
	from dbo.produkte
	where produktnr = @pnr;
end
go

--Insert into produkte

create procedure [dbo].[InsertProdukt]
	@produktnr int, @produktname varchar(50), @preis numeric(7,2), 	@beschreibung varchar(50),
	@hersteller varchar(50), @kategorie varchar(50), @stueckzahl int
as
begin
	set nocount on;
	insert into produkte VALUES (@produktnr, @produktname, @preis, @beschreibung,
	@hersteller, @kategorie, @stueckzahl);
end
go

insert into produkte VALUES (1, 'Samsung Galaxy A44', 1000.99, 'Smartphone 128GB / Dual-SIM / Farbe: schwarz', 'Samsung', 'Smartphone', 20);
insert into produkte VALUES (2, 'Samsung Galaxy A50', 500.00, 'Smartphone 128GB / Dual-SIM / Farbe: weiß', 'Samsung', 'Smartphone', 55);
insert into produkte VALUES (3, 'Apple iPhone SE', 1000.99, 'Smartphone 64GB / 4,7 Zoll / Farbe: schwarz', 'Apple', 'Smartphone', 15);
insert into produkte VALUES (4, 'Lenovo Ideapad', 1500.00, 'Notebook 15"FHD / 16GB, 512GB SSD / Farbe: schwarz', 'Lenovo', 'Notebook', 44);
insert into produkte VALUES (5, 'LG OLED 456XX22', 1800.00, 'Smart-TV 75" / 4K UHD / Farbe: schwarz', 'LG', 'TV', 10);

alter table produkte add pfad varchar(100)
alter table produkte add image image

create proc [dbo].[ShowAll]
as
begin
	select b.bestellungsnr, b.datum, k.kundennr, k.vorname, k.nachname, p.produktnr, p.produktname, p.preis, p.hersteller, p.kategorie
	from kunden k inner join bestellungen b
	on k.kundennr = b.kundennr inner join produkte p
	on b.produktnr = p.produktnr;
end;
go

create proc [dbo].[SumAll]
@summe numeric(7,2) output
as
begin
set @summe = (select sum(p.preis)
				from bestellungen b inner join produkte p
				on b.produktnr = p.produktnr);
end;
go

create proc [dbo].[CalculateGroupName]
as
begin
	select k.kundennr kundennr, avg(p.preis) durchschnitt, sum(p.preis) summe, 
	max(p.preis) max, min(p.preis) min, sum(p.stueckzahl) stückzahl
	from kunden k inner join bestellungen b
	on k.kundennr = b.kundennr inner join produkte p
	on b.produktnr = p.produktnr
	group by k.kundennr;
end;
go

create proc [dbo].[CalculateGroupKNr]
as
begin
	select k.kundennr, avg(p.preis) durchschnitt, sum(p.preis) summe, 
	max(p.preis) max, min(p.preis) min, count(b.bestellungsnr) "anzahl bestellungen"
	from kunden k inner join bestellungen b
	on k.kundennr = b.kundennr inner join produkte p
	on b.produktnr = p.produktnr
	group by k.kundennr;
end;
go

create proc [dbo].[CalculateGroupHersteller]
as
begin
	select p.hersteller, avg(p.preis) durchschnitt, sum(p.preis) summe, 
	max(p.preis) max, min(p.preis) min
	from kunden k inner join bestellungen b
	on k.kundennr = b.kundennr inner join produkte p
	on b.produktnr = p.produktnr
	group by p.hersteller;
end;
go

--Hilfsabfragen:

select * from kunden;
select * from bestellungen;
select * from produkte;


