
Use MarketPlants
Go
Create schema MarketPlants;
Go

CREATE TABLE MarketPlants.Tipo(
	Email NVARCHAR(255) unique not null CHECK (Email LIKE '%@%.%'),
	NIF	INT unique not null CHECK (NIF >= 000000000 AND NIF <= 999999999),
	Primary Key (Email,NIF)
);
CREATE TABLE MarketPlants.Utilizador(
	Username NVARCHAR(255) unique NOT NULL,
	Senha NVARCHAR(255), -- Tiramos o NOT NULL pois ao editar o perfil podemos querer manter a Senha
	Primary key (Username)
);
CREATE TABLE MarketPlants.Empresa(
    Descricao NVARCHAR(255),
    NrTelefone VARCHAR(9),
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
    NrTelefone VARCHAR(9),
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

CREATE TABLE MarketPlants.Artigo(
	ID_Artigo INT IDENTITY(1,1) PRIMARY KEY,
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

CREATE TABLE MarketPlants.Carrinho(
    ID_Carrinho INT IDENTITY(1,1) PRIMARY KEY,
    ID_Comprador INT FOREIGN KEY REFERENCES MarketPlants.Comprador(ID_Comprador),
    CONSTRAINT FK_Carrinho_Comprador FOREIGN KEY (ID_Comprador) REFERENCES MarketPlants.Comprador(ID_Comprador) ON DELETE CASCADE
);

CREATE TABLE MarketPlants.CarrinhoArtigo(
    ID_Carrinho INT FOREIGN KEY REFERENCES MarketPlants.Carrinho(ID_Carrinho),
    ID_Artigo INT FOREIGN KEY REFERENCES MarketPlants.Artigo(ID_Artigo),
    PRIMARY KEY (ID_Carrinho, ID_Artigo)
);

USE MarketPlants
GO
ALTER TABLE MarketPlants.Empresa
ADD CONSTRAINT CK_Empresa_NrTelefone CHECK (LEN(NrTelefone) = 9 AND ISNUMERIC(NrTelefone) = 1);

ALTER TABLE MarketPlants.Pessoa
ADD CONSTRAINT CK_Pessoa_NrTelefone CHECK (LEN(NrTelefone) = 9 AND ISNUMERIC(NrTelefone) = 1);