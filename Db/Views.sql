-- Views.sql
--View 1 - Para listar as plantas na Home Page
Use MarketPlants
Go
CREATE VIEW vw_PlantaHome
AS
SELECT 
    NomeComum AS Nome, 
    NomeCientifico AS [Nome Cientifico], 
    CONCAT(Reino, ' ', Familia) AS Classification,
    Ambiente, 
    Caracteristicas 
FROM 
    MarketPlants.Planta