-- Triggers.sql
CREATE TRIGGER VerificarCredenciaisDuplicadas
ON MarketPlants.Utilizador
FOR INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM MarketPlants.Utilizador U
        INNER JOIN inserted I ON U.Username = I.Username
        WHERE EXISTS (
            SELECT 1
            FROM MarketPlants.Utilizador
            WHERE Username = I.Username AND Senha = I.Senha
        )
    )
    BEGIN
        RAISERROR ('Já existe um utilizador com as mesmas credenciais.', 16, 1);
        ROLLBACK TRANSACTION;
    END;
END;
