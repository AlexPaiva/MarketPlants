
Use MarketPlants
Go
Create schema MarketPlants
Go

CREATE TABLE MarketPlants.Tipo(
	Email NVARCHAR(255) unique not null,
	NIF	INT unique not null,
	Primary Key (Email,NIF)
);
CREATE TABLE MarketPlants.Utilizador(
	Username NVARCHAR(255) unique NOT NULL,
	Senha NVARCHAR(255) NOT NULL
	Primary key (Username)
);
CREATE TABLE MarketPlants.Empresa(
    Descricao NVARCHAR(255),
    NrTelefone INT,
    Morada NVARCHAR(255),
    Nome NVARCHAR(255) unique,
    Username NVARCHAR(255) FOREIGN KEY references MarketPlants.Utilizador(Username),
	NIFUt INT PRIMARY KEY FOREIGN KEY references MarketPlants.Tipo(nif),
	Email NVARCHAR(255) FOREIGN KEY references MarketPlants.Tipo(email),
);

CREATE TABLE MarketPlants.Pessoa(
    PrimeiroNome NVARCHAR(255),
    UltimoNome NVARCHAR(255),
    Morada NVARCHAR(255),
    Genero NVARCHAR(255),
    NrTelefone INT,
	Username NVARCHAR(255) FOREIGN KEY references MarketPlants.Utilizador(Username),
	NIFUt INT PRIMARY KEY FOREIGN KEY references MarketPlants.Tipo(nif),
	Email NVARCHAR(255) FOREIGN KEY references MarketPlants.Tipo(email),
);


CREATE TABLE MarketPlants.Comprador(
	ID_Comprador INT unique not null ,
	DadosDePagamento NVARCHAR(255),
	Username NVARCHAR(255) FOREIGN KEY references MarketPlants.Utilizador(Username),
	Primary key(ID_Comprador)
);

CREATE TABLE MarketPlants.Vendedor(
	ID_Vendedor INT unique not null ,
	Rating int ,
	Username NVARCHAR(255) FOREIGN KEY references MarketPlants.Utilizador(Username),
	CondicoesDeLevantamentoEntrega NVARCHAR(255),
	Primary key(ID_Vendedor)
);

CREATE TABLE MarketPlants.EntidadeRegulamentadora(
	ID_Entidade INT unique not null ,
	nome NVARCHAR(255),
	ID_Vendedor INT FOREIGN KEY references MarketPlants.Vendedor(ID_Vendedor),
	Primary key(ID_Entidade)
);

CREATE TABLE MarketPlants.Catalogo(
	NrArtigos INT,
	Promoção INT,
	ID_Vendedor INT PRIMARY KEY FOREIGN KEY references MarketPlants.Vendedor(ID_Vendedor),
);

CREATE TABLE MarketPlants.Artigo(
	ID_Artigo INT PRIMARY KEY,
	Descricao NVARCHAR(255),
	Preco INT ,
	ID_Vendedor INT FOREIGN KEY references MarketPlants.Vendedor(ID_Vendedor),
);

CREATE TABLE MarketPlants.Carrinho(
	NrArtigos INT,
	PreçoTotal INT,
	ID_Comprador INT PRIMARY KEY FOREIGN KEY references MarketPlants.Comprador(ID_Comprador), -- Needs to be added to the diagram
	ID_Vendedor INT FOREIGN KEY references MarketPlants.Vendedor(ID_Vendedor), -- Needs to be added to the diagram
	ID_Artigo INT FOREIGN KEY references MarketPlants.Artigo(ID_Artigo)
);

CREATE TABLE MarketPlants.Planta(
	NomeCientifico NVARCHAR(255) PRIMARY KEY,
	NomeComum NVARCHAR(255),
	Reino NVARCHAR(255),
	Familia NVARCHAR(255),
	Ambiente NVARCHAR(255),
	Caracteristicas NVARCHAR(255),
	ID_Artigo INT FOREIGN KEY references MarketPlants.Artigo(ID_Artigo)
);

CREATE TABLE MarketPlants.Flor(
	NomeCientifico NVARCHAR(255) PRIMARY KEY,
	NomeComum NVARCHAR(255),
	Caracteristicas NVARCHAR(255),
	NomeCientificoPlanta NVARCHAR(255) FOREIGN KEY references MarketPlants.Planta(NomeCientifico)
);

CREATE TABLE MarketPlants.Fruto(
	NomeCientifico NVARCHAR(255) PRIMARY KEY,
	NomeComum NVARCHAR(255),
	Caracteristicas NVARCHAR(255),
	Epoca NVARCHAR(255),
	Replantavel NVARCHAR(255),
	NomeCientificoFlor NVARCHAR(255) FOREIGN KEY references MarketPlants.Flor(NomeCientifico)
);

CREATE TABLE MarketPlants.Categoria(
	ID_Categoria INT PRIMARY KEY,
	Nome NVARCHAR(255),
	Designacao NVARCHAR(255),
	NomeCientificoPlanta NVARCHAR(255) FOREIGN KEY references MarketPlants.Planta(NomeCientifico)
);