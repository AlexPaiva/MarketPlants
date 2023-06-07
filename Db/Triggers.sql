-- Triggers.sql
--Trigger 1 - Check username is Duplicate or not
CREATE OR ALTER TRIGGER CheckDuplicateUsername
ON MarketPlants.Utilizador
INSTEAD OF INSERT
AS
BEGIN
    -- Check if the username already exists in the table
    IF EXISTS (SELECT 1 FROM MarketPlants.Utilizador WHERE Username = (SELECT Username FROM inserted))
    BEGIN
        -- If the username exists, raise an error and roll back the transaction
        RAISERROR('A user with this username already exists. Please choose another username.', 16, 1)
        ROLLBACK TRANSACTION
    END
    ELSE
    BEGIN
        -- If the username does not exist, insert the new record
        INSERT INTO MarketPlants.Utilizador(Username, Senha)
        SELECT Username, Senha FROM inserted
    END
END
--
Use MarketPlants
Go
--Trigger2 - Check duplicate Plants
CREATE OR ALTER TRIGGER trgCheckDuplicatePlant ON MarketPlants.Planta
INSTEAD OF INSERT
AS
BEGIN
    -- If there's no duplicate scientific name
    IF NOT EXISTS (SELECT 1 FROM MarketPlants.Planta p JOIN inserted i ON p.NomeCientifico = i.NomeCientifico)
    BEGIN
        -- Proceed with the insert operation
        INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
        SELECT NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo FROM inserted
    END
    ELSE
    BEGIN
        -- Handle the error in a way that makes sense for your application
        RAISERROR ('A plant with this scientific name already exists.', 16, 1)
    END
END
--
--Trigger 3 - Check se artigo já em carrinho
--CREATE TRIGGER CheckArtigoInCarrinho
--ON MarketPlants.CarrinhoArtigo
--FOR INSERT
--AS
--BEGIN
--    IF EXISTS (
--        SELECT 1
--        FROM inserted i
--        INNER JOIN MarketPlants.CarrinhoArtigo ca ON i.ID_Artigo = ca.ID_Artigo
--        WHERE i.ID_Carrinho = ca.ID_Carrinho
--    )
--    BEGIN
--        RAISERROR ('Artigo already exists in Cart.', 16, 1)
--        ROLLBACK TRANSACTION
--    END
--END;
--select * from MarketPlants.CarrinhoArtigo
--