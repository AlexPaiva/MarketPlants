-- Procs.sql
--PROC 1 - Register Company (Registar uma Empresa)
Use MarketPlants
Go
CREATE PROCEDURE RegisterCompany
    @username NVARCHAR(255),
    @password NVARCHAR(255),
    @email NVARCHAR(255),
    @nif INT,
    @descricao NVARCHAR(255),
    @nrTelefone INT,
    @morada NVARCHAR(255),
    @nome NVARCHAR(255),
	@userType CHAR(1)
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM MarketPlants.Utilizador WHERE Username = @username)
        BEGIN
            THROW 51000, 'User already exists.', 1;  
        END

        IF EXISTS (SELECT 1 FROM MarketPlants.Tipo WHERE Email = @email OR NIF = @nif)
        BEGIN
            THROW 51000, 'Email or NIF already exists.', 1;  
        END

        INSERT INTO MarketPlants.Tipo (Email, NIF) VALUES (@email, @nif);
        INSERT INTO MarketPlants.Utilizador (Username, Senha) VALUES (@username, @password); -- Removed userType
        INSERT INTO MarketPlants.Empresa (Descricao, NrTelefone, Morada, Nome, Username, NIF, Email) VALUES (@descricao, @nrTelefone, @morada, @nome, @username, @nif, @email);

        IF @userType = 'C'
            INSERT INTO MarketPlants.Comprador (Username) VALUES (@username);
        ELSE IF @userType = 'V'
            INSERT INTO MarketPlants.Vendedor (Username) VALUES (@username);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
--

--Proc 2 - Plant Fetch (Buscar destalhes especificos de uma planta)
Use MarketPlants
Go
CREATE PROCEDURE GetPlantDetails
    @NomeComum NVARCHAR(255)
AS
BEGIN
    SELECT *
    FROM MarketPlants.Planta
    WHERE NomeComum = @NomeComum;
END;
--

--Proc 3 - Register Individual (Registar uma Pessoa)
USE MarketPlants
GO
CREATE PROCEDURE RegisterIndividual
    @username NVARCHAR(255),
    @password NVARCHAR(255),
    @email NVARCHAR(255),
    @nif INT,
    @primeiroNome NVARCHAR(255),
    @ultimoNome NVARCHAR(255),
    @morada NVARCHAR(255),
    @genero NVARCHAR(255),
    @nrTelefone INT,
	@userType CHAR(1)
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM MarketPlants.Utilizador WHERE Username = @username)
        BEGIN
            THROW 51000, 'User already exists.', 1;  
        END

        IF EXISTS (SELECT 1 FROM MarketPlants.Tipo WHERE Email = @email OR NIF = @nif)
        BEGIN
            THROW 51000, 'Email or NIF already exists.', 1;  
        END

        INSERT INTO MarketPlants.Tipo (Email, NIF) VALUES (@email, @nif);
        INSERT INTO MarketPlants.Utilizador (Username, Senha) VALUES (@username, @password); -- Removed userType
        INSERT INTO MarketPlants.Pessoa (PrimeiroNome, UltimoNome, Morada, Genero, NrTelefone, Username, NIF, Email) VALUES (@primeiroNome, @ultimoNome, @morada, @genero, @nrTelefone, @username, @nif, @email);

        IF @userType = 'C'
            INSERT INTO MarketPlants.Comprador (Username) VALUES (@username);
        ELSE IF @userType = 'V'
            INSERT INTO MarketPlants.Vendedor (Username) VALUES (@username);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
--