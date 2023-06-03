-- Index.sql
CREATE INDEX IDX_Utilizador_Username ON MarketPlants.Utilizador (Username);
CREATE INDEX IDX_Artigo_ID_Vendedor ON MarketPlants.Artigo (ID_Vendedor);
CREATE INDEX IDX_Planta_NomeCientifico ON MarketPlants.Planta (NomeCientifico);
CREATE INDEX IDX_Catalogo_ID_Vendedor ON MarketPlants.Catalogo (ID_Vendedor);
CREATE INDEX idx_Planta_NomeComum ON MarketPlants.Planta (NomeComum);
