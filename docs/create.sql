create table tafel
(

	id int not null,
	aantalPersonen int not null,
	isBezet bit,

	constraint Tafel_PK primary key (id)
)

create table gerecht
(
	id int not null,
	naam nvarchar(25) not null,
	prijs float not null,
	categorie int,

	constraint Gerecht_PK primary key (id)
)

create table gebruiker
(
	id int not null,
	gebruikersnaam nvarchar(30) not null,
	wachtwoord nvarchar(30) not null,
	functie int,

	constraint Gebruiker_PK primary key (id)
)

create table bestelling
(
	id int not null,
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
	
	constraint InhoudBestelling_PK primary key (id),
)
