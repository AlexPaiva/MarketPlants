-- Procs.sql
Use MarketPlants
Go
--PROC 1 - Register Company (Registar uma Empresa)
CREATE OR ALTER PROCEDURE RegisterCompany
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
Use MarketPlants
Go
--Proc 2 - Plant Fetch (Buscar destalhes especificos de uma planta)
CREATE OR ALTER PROCEDURE GetPlantDetails
    @CommonName NVARCHAR(255)
AS
BEGIN
    -- Base query joining necessary tables
    WITH base AS (
        SELECT 
            P.NomeCientifico AS 'Scientific Name',
            P.NomeComum AS 'Common Name',
            P.Reino AS 'Kingdom',
            P.Familia AS 'Family',
            P.Ambiente AS 'Environment',
            P.Caracteristicas AS 'Characteristics',
            F.NomeCientifico AS 'Flower Scientific Name',
            F.NomeComum AS 'Flower Common Name',
            F.Caracteristicas AS 'Flower Characteristics',
            Fr.NomeCientifico AS 'Fruit Scientific Name',
            Fr.NomeComum AS 'Fruit Common Name',
            Fr.Caracteristicas AS 'Fruit Characteristics',
            Fr.Epoca AS 'Season'
        FROM 
            MarketPlants.Planta AS P
        LEFT JOIN 
            MarketPlants.Flor AS F ON P.NomeCientifico = F.NomeCientificoPlanta
        LEFT JOIN 
            MarketPlants.Fruto AS Fr ON F.NomeCientifico = Fr.NomeCientificoFlor
    )
    SELECT 
        [Scientific Name],
        [Common Name],
        [Kingdom],
        [Family],
        [Environment],
        [Characteristics],
        [Flower Scientific Name],
        [Flower Common Name],
        [Flower Characteristics],
        [Fruit Scientific Name],
        [Fruit Common Name],
        [Fruit Characteristics],
        [Season]
    FROM 
        base
    WHERE 
        [Common Name] = @CommonName;
END;
--
USE MarketPlants
GO
--Proc 3 - Register Individual (Registar uma Pessoa)
CREATE OR ALTER PROCEDURE RegisterIndividual
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
--
USE MarketPlants
GO
--PROC 4 - Ir buscar 'CondicoesDeLevantamentoEntrega ' do Vendedor
CREATE OR ALTER PROCEDURE GetVendedorConditions
    @username NVARCHAR(255)
AS
BEGIN
    SELECT CondicoesDeLevantamentoEntrega
    FROM MarketPlants.Vendedor v
    INNER JOIN MarketPlants.Utilizador u ON v.Username = u.Username
    WHERE u.Username = @username
END
--
USE MarketPlants
GO
--PROC 5 - Atualizar 'CondicoesDeLevantamentoEntrega' do Vendedor
CREATE OR ALTER PROCEDURE UpdateVendedorConditions
    @username NVARCHAR(255),
    @condicoes NVARCHAR(255)
AS
BEGIN
    UPDATE MarketPlants.Vendedor
    SET CondicoesDeLevantamentoEntrega = @condicoes
    FROM MarketPlants.Vendedor v
    INNER JOIN MarketPlants.Utilizador u ON v.Username = u.Username
    WHERE u.Username = @username
END
--
USE MarketPlants
GO
--PROC 6 - Verificar se Utilizador é seller
CREATE OR ALTER PROCEDURE IsUserSeller
    @username NVARCHAR(255),
    @IsSeller BIT OUTPUT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM MarketPlants.Vendedor WHERE Username = @username)
        SET @IsSeller = 1
    ELSE
        SET @IsSeller = 0
END
--
USE MarketPlants
GO
--PROC 7 - Verificar se Utilizador é Comprador (buyer)
CREATE OR ALTER PROCEDURE IsUserBuyer
    @username NVARCHAR(255),
    @IsBuyer BIT OUTPUT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM MarketPlants.Comprador WHERE Username = @username)
        SET @IsBuyer = 1
    ELSE
        SET @IsBuyer = 0
END
--
USE MarketPlants
GO
--Proc 8 - Ir buscar os dados de Pagamento do Comprador (buyer)
CREATE OR ALTER PROCEDURE GetCompradorPaymentInfo
    @username NVARCHAR(255)
AS
BEGIN
    SELECT DadosDePagamento
    FROM MarketPlants.Comprador
    WHERE Username = @username
END
--
USE MarketPlants
GO
--Proc 9 - Atualizar informações de pagamento do Comprador
CREATE OR ALTER PROCEDURE UpdateCompradorPaymentInfo
    @username NVARCHAR(255),
    @dadosDePagamento NVARCHAR(255)
AS
BEGIN
    UPDATE MarketPlants.Comprador
    SET DadosDePagamento = @dadosDePagamento
    WHERE Username = @username
END
--
USE MarketPlants
GO
--Proc 10 - Atualizar informações de perfil do utilizador
CREATE OR ALTER PROCEDURE UpdateUserData
    @username NVARCHAR(50),
    @newPassword NVARCHAR(50),
    @newEmail NVARCHAR(50),
    @newNIF NVARCHAR(50),
    @newPhone NVARCHAR(50),
    @newAddress NVARCHAR(50),
    @userType NVARCHAR(50)
AS
BEGIN
    DECLARE @oldEmail NVARCHAR(50);
    DECLARE @oldNIF NVARCHAR(50);

    -- Retrieve the current Email and NIF based on user type
    IF @userType = 'Empresa'
    BEGIN
        SELECT @oldEmail = Email, @oldNIF = NIF 
        FROM MarketPlants.Empresa
        WHERE Username = @username;
    END
    ELSE IF @userType = 'Pessoa'
    BEGIN
        SELECT @oldEmail = Email, @oldNIF = NIF 
        FROM MarketPlants.Pessoa
        WHERE Username = @username;
    END

    -- Update Tipo
    UPDATE MarketPlants.Tipo
    SET Email = @newEmail, NIF = @newNIF
    WHERE Email = @oldEmail AND NIF = @oldNIF;

    -- If new password is not empty, update it
    IF @newPassword <> ''
    BEGIN
        UPDATE MarketPlants.Utilizador
        SET Senha = @newPassword
        WHERE Username = @username;
    END

    -- Update Empresa or Pessoa, and update address and phone number
    IF @userType = 'Empresa'
    BEGIN
        UPDATE MarketPlants.Empresa
        SET Morada = @newAddress,
            NrTelefone = dbo.RemoveDashes(@newPhone),
            Email = @newEmail,
            NIF = @newNIF
        WHERE Username = @username;
    END
    ELSE IF @userType = 'Pessoa'
    BEGIN
        UPDATE MarketPlants.Pessoa
        SET Morada = @newAddress,
            NrTelefone = dbo.RemoveDashes(@newPhone),
            Email = @newEmail,
            NIF = @newNIF
        WHERE Username = @username;
    END
END;
--
USE MarketPlants
GO
--Proc 11 - Procedure de efetuar Search com partial match e dependendo dos filtros selecionados
CREATE OR ALTER PROCEDURE sp_SearchPlants
    @searchTerm NVARCHAR(255),
    @flowers BIT,
    @fruits BIT
AS
BEGIN
    SET NOCOUNT ON;

    -- Base query joining necessary tables
    WITH base AS (
        SELECT 
            P.NomeCientifico AS "Scientific Name",
            P.NomeComum AS "Common Name",
            P.Reino AS "Kingdom",
            P.Familia AS "Family",
            P.Ambiente AS "Environment",
            ISNULL(P.Caracteristicas, 'No Info!') AS "Characteristics",
            F.NomeCientifico AS "Flower Scientific Name",
            F.NomeComum AS "Flower Common Name",
            ISNULL(F.Caracteristicas, 'No Info!') AS "Flower Characteristics",
            Fr.NomeCientifico AS "Fruit Scientific Name",
            Fr.NomeComum AS "Fruit Common Name",
            ISNULL(Fr.Caracteristicas, 'No Info!') AS "Fruit Characteristics",
            ISNULL(Fr.Epoca, 'No Info!') AS "Season"
        FROM 
            MarketPlants.Planta AS P
        LEFT JOIN 
            MarketPlants.Flor AS F ON P.NomeCientifico = F.NomeCientificoPlanta
        LEFT JOIN 
            MarketPlants.Fruto AS Fr ON F.NomeCientifico = Fr.NomeCientificoFlor
    )
    SELECT 
        "Scientific Name",
        "Common Name",
        "Kingdom",
        "Family",
        "Environment",
        "Characteristics",
        "Flower Scientific Name",
        "Flower Common Name",
        "Flower Characteristics",
        "Fruit Scientific Name",
        "Fruit Common Name",
        "Fruit Characteristics",
        "Season"
    FROM 
        base
    WHERE 
        (@searchTerm = '' OR 
        "Scientific Name" LIKE '%' + @searchTerm + '%' OR 
        "Common Name" LIKE '%' + @searchTerm + '%' OR 
        "Kingdom" LIKE '%' + @searchTerm + '%' OR 
        "Family" LIKE '%' + @searchTerm + '%' OR 
        "Environment" LIKE '%' + @searchTerm + '%' OR 
        "Characteristics" LIKE '%' + @searchTerm + '%' OR 
        "Flower Scientific Name" LIKE '%' + @searchTerm + '%' OR 
        "Flower Common Name" LIKE '%' + @searchTerm + '%' OR 
        "Flower Characteristics" LIKE '%' + @searchTerm + '%' OR 
        "Fruit Scientific Name" LIKE '%' + @searchTerm + '%' OR 
        "Fruit Common Name" LIKE '%' + @searchTerm + '%' OR 
        "Fruit Characteristics" LIKE '%' + @searchTerm + '%' OR 
        "Season" LIKE '%' + @searchTerm + '%') AND 
        (@flowers = 0 OR "Flower Scientific Name" IS NOT NULL) AND 
        (@fruits = 0 OR "Fruit Scientific Name" IS NOT NULL);
END
--
USE MarketPlants
GO
-- Proc 12 - Procedure to save new plant
CREATE OR ALTER PROCEDURE procAddPlant
	@ScientificName NVARCHAR(255),
	@CommonName NVARCHAR(255),
	@Kingdom NVARCHAR(255),
	@Family NVARCHAR(255),
	@Environment NVARCHAR(255),
	@Characteristics NVARCHAR(255),
	@Username NVARCHAR(255)
AS
BEGIN
	DECLARE @ArtigoId INT, @VendedorId INT;

	SELECT @VendedorId = ID_Vendedor FROM MarketPlants.Vendedor WHERE Username = @Username;

	INSERT INTO MarketPlants.Artigo(ID_Vendedor)
	VALUES (@VendedorId);

	SET @ArtigoId = SCOPE_IDENTITY();

	IF NOT EXISTS (SELECT 1 FROM MarketPlants.Planta WHERE NomeCientifico = @ScientificName)
	BEGIN
		INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
		VALUES (@ScientificName, @CommonName, @Kingdom, @Family, @Environment, @Characteristics, @ArtigoId)
	END
END
--
USE MarketPlants
GO
-- Proc 13 - Add fruit
CREATE OR ALTER PROCEDURE procAddFruit
	@ScientificName NVARCHAR(255),
	@CommonName NVARCHAR(255),
	@Characteristics NVARCHAR(255),
	@Season NVARCHAR(255),
	@Replantable NVARCHAR(255),
	@FlowerScientificName NVARCHAR(255)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM MarketPlants.Flor WHERE NomeCientifico = @FlowerScientificName)
	BEGIN
		INSERT INTO MarketPlants.Fruto(NomeCientifico, NomeComum, Caracteristicas, Epoca, Replantavel, NomeCientificoFlor)
		VALUES (@ScientificName, @CommonName, @Characteristics, @Season, @Replantable, @FlowerScientificName)
	END
END
--
USE MarketPlants
GO
-- Proc 14 - Add Flower
CREATE OR ALTER PROCEDURE procAddFlower
	@ScientificName NVARCHAR(255),
	@CommonName NVARCHAR(255),
	@Characteristics NVARCHAR(255),
	@PlantScientificName NVARCHAR(255)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM MarketPlants.Planta WHERE NomeCientifico = @PlantScientificName)
	BEGIN
		INSERT INTO MarketPlants.Flor(NomeCientifico, NomeComum, Caracteristicas, NomeCientificoPlanta)
		VALUES (@ScientificName, @CommonName, @Characteristics, @PlantScientificName)
	END
END
--
USE MarketPlants
GO
--PROC 15 - Criar ou Verificar a existência de um carrinho
CREATE PROCEDURE CheckAndCreateCarrinho
    @username NVARCHAR(255),
    @carrinhoID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if the user has a Carrinho
    IF EXISTS (SELECT ID_Carrinho FROM MarketPlants.Carrinho WHERE ID_Comprador = (SELECT ID_Comprador FROM MarketPlants.Comprador WHERE Username = @username))
    BEGIN
        -- Carrinho exists, retrieve its ID
        SELECT @carrinhoID = ID_Carrinho FROM MarketPlants.Carrinho WHERE ID_Comprador = (SELECT ID_Comprador FROM MarketPlants.Comprador WHERE Username = @username)
    END
    ELSE
    BEGIN
        -- Carrinho doesn't exist, create a new one
        INSERT INTO MarketPlants.Carrinho (ID_Comprador)
        VALUES ((SELECT ID_Comprador FROM MarketPlants.Comprador WHERE Username = @username))

        SET @carrinhoID = SCOPE_IDENTITY()
    END
END
--
USE MarketPlants
GO
--PROC 16 - Get o Carrinho com ID
CREATE PROCEDURE GetArtigosByCarrinhoID
    @carrinhoID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT p.NomeCientifico, p.NomeComum, p.Reino, p.Familia, p.Ambiente, p.Caracteristicas
    FROM MarketPlants.Planta p
    INNER JOIN MarketPlants.Artigo a ON p.ID_Artigo = a.ID_Artigo
    INNER JOIN MarketPlants.CarrinhoArtigo ca ON a.ID_Artigo = ca.ID_Artigo
    WHERE ca.ID_Carrinho = @carrinhoID
END
--
USE MarketPlants
GO
--PROC 17 - Add Artigo ao Carrinho
CREATE OR ALTER PROCEDURE AddArtigoToCarrinho
    @username NVARCHAR(255),
    @commonName NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    -- Get the Carrinho ID
    DECLARE @carrinhoID INT;
    SELECT @carrinhoID = ID_Carrinho FROM MarketPlants.Carrinho WHERE ID_Comprador = (SELECT ID_Comprador FROM MarketPlants.Comprador WHERE Username = @username);

    -- Get the Artigo ID
    DECLARE @artigoID INT;
    SELECT @artigoID = ID_Artigo FROM MarketPlants.Artigo WHERE ID_Vendedor = (SELECT ID_Vendedor FROM MarketPlants.Vendedor WHERE Username = @username) AND ID_Artigo = (SELECT ID_Artigo FROM MarketPlants.Planta WHERE NomeComum = @commonName);

    -- Insert the Artigo into CarrinhoArtigo
    INSERT INTO MarketPlants.CarrinhoArtigo (ID_Carrinho, ID_Artigo)
    VALUES (@carrinhoID, @artigoID);
END
--
--