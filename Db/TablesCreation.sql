
Use MarketPlants
Go
Create schema MarketPlants
Go

CREATE TABLE MarketPlants.Tipo(
	Email NVARCHAR(255) unique not null CHECK (Email LIKE '%@%.com'),
	NIF	INT unique not null CHECK (NIF >= 000000000 AND NIF <= 999999999),
	Primary Key (Email,NIF)
);
CREATE TABLE MarketPlants.Utilizador(
	Username NVARCHAR(255) unique NOT NULL,
	Senha NVARCHAR(255) NOT NULL,
	Primary key (Username)
);
CREATE TABLE MarketPlants.Empresa(
    Descricao NVARCHAR(255),
    NrTelefone INT,
    Morada NVARCHAR(255),
    Nome NVARCHAR(255) unique,
    Username NVARCHAR(255) FOREIGN KEY references MarketPlants.Utilizador(Username),
	NIF INT PRIMARY KEY FOREIGN KEY references MarketPlants.Tipo(NIF),
	Email NVARCHAR(255) FOREIGN KEY references MarketPlants.Tipo(Email),
);

CREATE TABLE MarketPlants.Pessoa(
    PrimeiroNome NVARCHAR(255),
    UltimoNome NVARCHAR(255),
    Morada NVARCHAR(255),
    Genero NVARCHAR(255),
    NrTelefone INT,
	Username NVARCHAR(255) FOREIGN KEY references MarketPlants.Utilizador(Username),
	NIF INT PRIMARY KEY FOREIGN KEY references MarketPlants.Tipo(NIF),
	Email NVARCHAR(255) FOREIGN KEY references MarketPlants.Tipo(Email),
);


CREATE TABLE MarketPlants.Comprador(
	ID_Comprador INT IDENTITY(1,1) Primary Key not null ,
	DadosDePagamento NVARCHAR(255),
	Username NVARCHAR(255) FOREIGN KEY references MarketPlants.Utilizador(Username),

);

CREATE TABLE MarketPlants.Vendedor(
	ID_Vendedor INT IDENTITY(1,1) Primary key not null ,
	Rating int not null ,
	Username NVARCHAR(255) FOREIGN KEY references MarketPlants.Utilizador(Username),
	CondicoesDeLevantamentoEntrega NVARCHAR(255),
);

CREATE TABLE MarketPlants.EntidadeRegulamentadora(
	ID_Entidade INT IDENTITY(1,1) Primary key not null ,
	nome NVARCHAR(255) not null,
	ID_Vendedor INT FOREIGN KEY references MarketPlants.Vendedor(ID_Vendedor),
);

CREATE TABLE MarketPlants.Catalogo(
	NrArtigos INT,
	Promocao INT,
	ID_Vendedor INT IDENTITY(1,1) PRIMARY KEY FOREIGN KEY references MarketPlants.Vendedor(ID_Vendedor),
);

CREATE TABLE MarketPlants.Artigo(
	ID_Artigo INT IDENTITY(1,1) PRIMARY KEY,
	Descricao NVARCHAR(255),
	Preco INT ,
	ID_Vendedor INT FOREIGN KEY references MarketPlants.Vendedor(ID_Vendedor),
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

CREATE TABLE MarketPlants.Carrinho(
    ID_Carrinho INT IDENTITY(1,1) PRIMARY KEY,
    ID_Comprador INT FOREIGN KEY REFERENCES MarketPlants.Comprador(ID_Comprador),
    ID_Vendedor INT FOREIGN KEY REFERENCES MarketPlants.Vendedor(ID_Vendedor),
    PrecoTotal INT,
);

CREATE TABLE MarketPlants.CarrinhoArtigo(
    ID_Carrinho INT FOREIGN KEY REFERENCES MarketPlants.Carrinho(ID_Carrinho),
    ID_Artigo INT FOREIGN KEY REFERENCES MarketPlants.Artigo(ID_Artigo),
    Quantidade INT,
    Preco INT ,
);

