create database Chapoo
go

create table tafel
(

	id int not null,
	aantalPersonen int not null,
	isBezet boolean,

	constraint Tafel_PK primary key (id)
)

create table gerecht
(
	id int not null primary key,
	naam string not null,
	prijs double not null,
	categorie int,

	constraint Gerecht_PK primary key (id)
)

create table gebruiler
(
	id int not null primary key,
	gebruikersnaam string not null,
	wachtwoord not null,
	functie int,

	constraint Gebruiker_PK primary key (id)
)

create table bestelling
(
	id int not null primary key,
	gebruiker int foreign key references gebruiker (id),
	tafel int foreign key references tafel (id),
	status int not null,

	constraint Bestelling_PK primary key (id)
)

create table inhoudBestelling
(
	id int not null,
	idBestelling int foreign key references bestelling (id),
	idGerecht int foreign key references gerecht (id),
	
	constraint inhoudBestelling_PK primary key (id),
	constraint BestellingId_PK primary key (idBestelling),
	constraint GerechtId_PK primary key (idGerecht)
)
