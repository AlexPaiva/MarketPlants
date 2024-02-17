-- Queries.sql
SELECT * FROM Vendas WHERE ClienteID = 1;

Use MarketPlants
Go
SELECT * FROM MarketPlants.Comprador
SELECT * FROM MarketPlants.Vendedor
SELECT * FROM MarketPlants.Utilizador
SELECT * FROM MarketPlants.Empresa
SELECT * FROM MarketPlants.Pessoa
SELECT * FROM MarketPlants.Artigo
UPDATE MarketPlants.Pessoa
SET NrTelefone = '910921641'
WHERE Username = 'alex';

SELECT * FROM MarketPlants.Flor
SELECT * FROM MarketPlants.Planta
SELECT * FROM MarketPlants.Fruto

SELECT P.NomeCientifico, F.NomeCientifico
FROM MarketPlants.Planta AS P
LEFT JOIN MarketPlants.Flor AS F ON P.NomeCientifico = F.NomeCientificoPlanta
WHERE F.NomeCientifico IS NOT NULL

EXEC GetPlantDetails @CommonName = 'Swiss Cheese Plant'

-- Get flowers with fruits
SELECT F.NomeCientifico, Fr.NomeCientifico
FROM MarketPlants.Flor AS F
LEFT JOIN MarketPlants.Fruto AS Fr ON F.NomeCientifico = Fr.NomeCientificoFlor
WHERE Fr.NomeCientifico IS NOT NULL