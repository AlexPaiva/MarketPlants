-- Views.sql
--Views para plantas no home page
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

--View plantas favoritas
CREATE VIEW vw_PlantasFavoritas AS
SELECT f.Username, p.NomeCientifico, p.NomeComum, p.Reino, p.Familia, p.Ambiente, p.Caracteristicas
FROM MarketPlants.Favoritos f
JOIN MarketPlants.Planta p ON f.NomeComum = p.NomeComum;

--View Plantas preço
CREATE VIEW vw_PlantasPreco AS
SELECT p.NomeCientifico, p.NomeComum, p.Reino, p.Familia, p.Ambiente, p.Caracteristicas, a.Preco
FROM MarketPlants.Planta p
JOIN MarketPlants.Artigo a ON p.ID_Artigo = a.ID_Artigo;

--View Plantas Categoria
CREATE VIEW vw_PlantasCategoria AS
SELECT c.Nome AS Categoria, p.NomeCientifico, p.NomeComum, p.Reino, p.Familia, p.Ambiente, p.Caracteristicas
FROM MarketPlants.Categoria c
JOIN MarketPlants.Planta p ON c.ID_Categoria = p.ID_Categoria;

--View For artigos por vendedor
SELECT * FROM MarketPlants.TodosArtigos;

CREATE FUNCTION MarketPlants.ArtigosVendidosPorVendedor (@ID_Vendedor INT)
RETURNS TABLE
AS
RETURN
    SELECT
        V.ID_Vendedor,
        V.ID_Comprador,
        A.Descricao AS DescricaoArtigo,
        PL.NomeCientifico,
        PL.NomeComum,
        PL.Reino,
        PL.Familia,
        PL.Ambiente,
        PL.Caracteristicas
    FROM
        MarketPlants.CarrinhoArtigo CA
        INNER JOIN MarketPlants.Carrinho V ON CA.ID_Carrinho = V.ID_Carrinho
        INNER JOIN MarketPlants.Artigo A ON CA.ID_Artigo = A.ID_Artigo
        INNER JOIN MarketPlants.Planta PL ON A.ID_Artigo= PL.ID_Artigo
    WHERE
        V.ID_Vendedor = @ID_Vendedor;


