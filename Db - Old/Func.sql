-- Func.sql
CREATE FUNCTION TotalVendasPlanta(@plantaID INT)
RETURNS INT AS
BEGIN
    DECLARE @total INT;
    SELECT @total = SUM(Quantidade) FROM Vendas WHERE PlantaID = @plantaID;
    RETURN @total;
END;