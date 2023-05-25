-- Views.sql
CREATE VIEW VendasView AS
SELECT V.VendaID, C.Nome AS NomeCliente, P.Nome AS NomePlanta, V.Quantidade, V.DataVenda
FROM Vendas V
JOIN Clientes C ON V.ClienteID = C.ClienteID
JOIN Plantas P ON V.PlantaID = P.PlantaID;