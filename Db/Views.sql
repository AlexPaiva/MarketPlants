-- Views.sql
USE MarketPlants
GO
--View 1 - Para listar as plantas na Home Page
CREATE OR ALTER VIEW vw_PlantaHome
AS
SELECT 
    P.NomeComum AS [Common Name], 
    P.NomeCientifico AS [Scientific Name], 
    CONCAT(P.Reino, ' ', P.Familia) AS [Classification],
    P.Ambiente AS [Environment], 
    P.Caracteristicas AS [Characteristics],
    ISNULL(F.NomeCientifico, 'No info') AS [Fruit Scientific Name],
    ISNULL(F.NomeComum, 'No info') AS [Fruit Common Name],
    ISNULL(F.Caracteristicas, 'No info') AS [Fruit Characteristics],
    ISNULL(Fl.NomeCientifico, 'No info') AS [Flower Scientific Name],
    ISNULL(Fl.NomeComum, 'No info') AS [Flower Common Name],
    ISNULL(Fl.Caracteristicas, 'No info') AS [Flower Characteristics]
FROM 
    MarketPlants.Planta P
LEFT JOIN
    MarketPlants.Flor Fl ON Fl.NomeCientificoPlanta = P.NomeCientifico
LEFT JOIN
    MarketPlants.Fruto F ON F.NomeCientificoFlor = Fl.NomeCientifico
--
USE MarketPlants
GO
--View 2  - Para listar as plantas vendidas por um vendedor especifico
CREATE OR ALTER VIEW View_UserPlants
AS
SELECT 
    P.NomeCientifico AS 'Scientific Name', 
    P.NomeComum AS 'Common Name', 
    P.Reino AS 'Kingdom',
    P.Familia AS 'Family',
    P.Ambiente AS 'Environment',
    P.Caracteristicas AS 'Characteristics',
    COALESCE(F.NomeComum, 'No Info!') AS 'Fruit Common Name', 
    COALESCE(F.NomeCientifico, 'No Info!') AS 'Fruit Scientific Name', 
    COALESCE(F.Caracteristicas, 'No Info!') AS 'Fruit Characteristics', 
    COALESCE(Fl.NomeComum, 'No Info!') AS 'Flower Common Name', 
    COALESCE(Fl.NomeCientifico, 'No Info!') AS 'Flower Scientific Name', 
    COALESCE(Fl.Caracteristicas, 'No Info!') AS 'Flower Characteristics'
FROM MarketPlants.Utilizador AS U
JOIN MarketPlants.Vendedor AS V ON U.Username = V.Username
JOIN MarketPlants.Artigo AS A ON V.ID_Vendedor = A.ID_Vendedor
JOIN MarketPlants.Planta AS P ON A.ID_Artigo = P.ID_Artigo
LEFT JOIN MarketPlants.Fruto AS F ON P.NomeCientifico = F.NomeCientificoFlor
LEFT JOIN MarketPlants.Flor AS Fl ON P.NomeCientifico = Fl.NomeCientificoPlanta
--
--