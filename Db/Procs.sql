-- Procs.sql
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

    -- Verificar se o utilizador j� existe
    IF EXISTS (
        SELECT 1
        FROM MarketPlants.Utilizador
        WHERE Username = @Username
    )
    BEGIN
        RAISERROR ('J� existe um utilizador com o mesmo nome de utilizador.', 16, 1);
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
        RAISERROR ('O cliente com o ID fornecido n�o existe.', 16, 1);
        RETURN;
    END;

    -- Verificar se a planta existe na tabela Planta
    IF NOT EXISTS (
        SELECT 1
        FROM MarketPlants.Planta
        WHERE ID_Artigo = @plantaID
    )
    BEGIN
        RAISERROR ('A planta com o ID fornecido n�o existe.', 16, 1);
        RETURN;
    END;

    -- Verificar se a quantidade � maior que zero
    IF @quantidade <= 0
    BEGIN
        RAISERROR ('A quantidade deve ser maior que zero.', 16, 1);
        RETURN;
    END;

    -- Obter o pr�ximo ID de carrinho
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
    -- Verificar se a planta j� est� nos favoritos do utilizador
    IF EXISTS (
        SELECT 1
        FROM MarketPlants.Favoritos
        WHERE Username = @Username
          AND NomeComum = @NomeComum
    )
    BEGIN
        -- A planta j� est� nos favoritos, n�o � necess�rio adicionar novamente
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
    -- Verificar se a planta j� existe pelo nome cient�fico
    IF EXISTS (
        SELECT 1
        FROM MarketPlants.Planta
        WHERE NomeCientifico = @NomeCientifico
    )
    BEGIN
        -- A planta j� existe, n�o � necess�rio adicionar novamente
        RETURN;
    END;

    -- Inserir a nova planta na tabela Planta
    INSERT INTO MarketPlants.Planta (NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas)
    VALUES (@NomeCientifico, @NomeComum, @Reino, @Familia, @Ambiente, @Caracteristicas);
END;
