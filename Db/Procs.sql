-- Procs.sql
CREATE PROCEDURE InsertVenda
    @clienteID INT,
    @plantaID INT,
    @quantidade INT
AS
BEGIN
    INSERT INTO Vendas(ClienteID, PlantaID, Quantidade, DataVenda)
    VALUES(@clienteID, @plantaID, @quantidade, GETDATE());
END;