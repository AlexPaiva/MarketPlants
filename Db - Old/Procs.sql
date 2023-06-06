-- Procs.sql
--Register Company PROC
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
		--Add the User to Comprador or Vendedor based on @userType
		IF @userType = 'C' --C for Comprador
		BEGIN
			INSERT INTO MarketPlants.Comprador (DadosDePagamento, Username)
			VALUES (NULL, @username);
		END
		ELSE IF @userType = 'V' --V for Vendedor
		BEGIN
			INSERT INTO MarketPlants.Vendedor (Rating, Username, CondicoesDeLevantamentoEntrega)
			VALUES (NULL, @username, NULL);
		END
        INSERT INTO MarketPlants.Tipo (Email, NIF) VALUES (@email, @nif);
        INSERT INTO MarketPlants.Utilizador (Username, Senha) VALUES (@username, @password);
        INSERT INTO MarketPlants.Empresa (Descricao, NrTelefone, Morada, Nome, Username, NIF, Email) VALUES (@descricao, @nrTelefone, @morada, @nome, @username, @nif, @email);
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

--Fetch 1 plants details
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
CREATE PROCEDURE CriarUtilizador
    @Username NVARCHAR(255),
    @Senha NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar se o utilizador já existe
    IF EXISTS (
        SELECT 1
        FROM MarketPlants.Utilizador
        WHERE Username = @Username
    )
    BEGIN
        RAISERROR ('Já existe um utilizador com o mesmo nome de utilizador.', 16, 1);
        RETURN;
    END;

    INSERT INTO MarketPlants.Utilizador (Username, Senha)
    VALUES (@Username, @Senha);

    DECLARE @ID_Utilizador INT;
    SET @ID_Utilizador = SCOPE_IDENTITY();

    INSERT INTO MarketPlants.Comprador (Username)
    VALUES (@Username);

    DECLARE @ID_Comprador INT;
    SET @ID_Comprador = SCOPE_IDENTITY();

    INSERT INTO MarketPlants.Vendedor (Username, Rating)
    VALUES (@Username, 0);

    DECLARE @ID_Vendedor INT;
    SET @ID_Vendedor = SCOPE_IDENTITY();
END;

-- InsertVenda
CREATE PROCEDURE AdicionarCarrinho
    @clienteID INT,
    @plantaID INT,
    @quantidade INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar se o cliente existe na tabela Pessoa ou Empresa
    IF NOT EXISTS (
        SELECT 1
        FROM MarketPlants.Pessoa
        WHERE NIF = @clienteID
    ) AND NOT EXISTS (
        SELECT 1
        FROM MarketPlants.Empresa
        WHERE NIF = @clienteID
    )
    BEGIN
        RAISERROR ('O cliente com o ID fornecido não existe.', 16, 1);
        RETURN;
    END;

    -- Verificar se a planta existe na tabela Planta
    IF NOT EXISTS (
        SELECT 1
        FROM MarketPlants.Planta
        WHERE ID_Artigo = @plantaID
    )
    BEGIN
        RAISERROR ('A planta com o ID fornecido não existe.', 16, 1);
        RETURN;
    END;

    -- Verificar se a quantidade é maior que zero
    IF @quantidade <= 0
    BEGIN
        RAISERROR ('A quantidade deve ser maior que zero.', 16, 1);
        RETURN;
    END;

    -- Obter o próximo ID de carrinho
    DECLARE @nextCarrinhoID INT;
    INSERT INTO MarketPlants.NextCarrinhoID (Dummy) VALUES (0);
    SET @nextCarrinhoID = SCOPE_IDENTITY();

    -- Inserir a venda na tabela CarrinhoArtigo
    INSERT INTO MarketPlants.CarrinhoArtigo (ID_Carrinho, ID_Artigo, Quantidade, Preco)
    VALUES (@nextCarrinhoID, @plantaID, @quantidade, 0);

    SELECT 'Venda inserida com sucesso.' AS Result;
END;
--Adicionar Planta Favoritos
CREATE PROCEDURE AdicionarPlantaFavoritos
    @Username NVARCHAR(255),
    @NomeComum NVARCHAR(255)
AS
BEGIN
    -- Verificar se a planta já está nos favoritos do utilizador
    IF EXISTS (
        SELECT 1
        FROM MarketPlants.Favoritos
        WHERE Username = @Username
          AND NomeComum = @NomeComum
    )
    BEGIN
        -- A planta já está nos favoritos, não é necessário adicionar novamente
        RETURN;
    END;

    -- Inserir a planta nos favoritos do utilizador
    INSERT INTO MarketPlants.Favoritos (Username, NomeComum)
    VALUES (@Username, @NomeComum);
END;

--Adicionar Planta
CREATE PROCEDURE AdicionarPlanta
    @NomeCientifico NVARCHAR(255),
    @NomeComum NVARCHAR(255),
    @Reino NVARCHAR(255),
    @Familia NVARCHAR(255),
    @Ambiente NVARCHAR(255),
    @Caracteristicas NVARCHAR(MAX)
AS
BEGIN
    -- Verificar se a planta já existe pelo nome científico
    IF EXISTS (
        SELECT 1
        FROM MarketPlants.Planta
        WHERE NomeCientifico = @NomeCientifico
    )
    BEGIN
        -- A planta já existe, não é necessário adicionar novamente
        RETURN;
    END;

    -- Inserir a nova planta na tabela Planta
    INSERT INTO MarketPlants.Planta (NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas)
    VALUES (@NomeCientifico, @NomeComum, @Reino, @Familia, @Ambiente, @Caracteristicas);
END;
