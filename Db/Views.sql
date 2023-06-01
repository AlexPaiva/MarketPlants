-- Views.sql
CREATE VIEW MarketPlants.TodosArtigos AS
SELECT
    A.ID_Artigo,
    A.Descricao AS DescricaoArtigo,
    A.Preco,
    P.NomeCientifico,
    P.NomeComum,
    P.Reino,
    P.Familia,
    P.Ambiente,
    P.Caracteristicas
FROM
    MarketPlants.Artigo A
    INNER JOIN MarketPlants.Planta P ON A.ID_Artigo = P.ID_Artigo;
	
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


