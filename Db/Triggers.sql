-- Triggers.sql
--Triggerverificar se username é duplicado
CREATE TRIGGER CheckDuplicateUsername
ON Users
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT Username
        FROM Users
        GROUP BY Username
        HAVING COUNT(*) > 1
    )
    BEGIN
        RAISERROR ('Dois usuários com o mesmo nome não são permitidos.', 16, 1)
        ROLLBACK TRANSACTION
    END
END;

--trigger verificar duplicate plant
CREATE TRIGGER CheckDuplicatePlant
ON Plants
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT NomeCientifico
        FROM Plants
        GROUP BY NomeCientifico
        HAVING COUNT(*) > 1
    )
    BEGIN
        RAISERROR ('Já existe uma planta com o mesmo nome científico.', 16, 1)
        ROLLBACK TRANSACTION
    END
END;

--trigger verificar favorites
CREATE TRIGGER CheckFavoritePlant
ON Favorites
AFTER INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM Favorites f
        INNER JOIN Plants p ON f.PlantID = p.PlantID
        WHERE f.UserID = (SELECT UserID FROM inserted)
          AND p.PlantID = (SELECT PlantID FROM inserted)
    )
    BEGIN
        RAISERROR ('Esta planta já está nos favoritos.',

--verificar planta cart ja tem
CREATE TRIGGER CheckDuplicatePlantInCart
ON CartItems
AFTER INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM CartItems ci
        INNER JOIN Plants p ON ci.PlantID = p.PlantID
        WHERE ci.CartID = (SELECT CartID FROM inserted)
          AND p.PlantID = (SELECT PlantID FROM inserted)
    )
    BEGIN
        RAISERROR ('Esta planta já foi adicionada ao carrinho de compras.', 16, 1)
        ROLLBACK TRANSACTION
    END
END;