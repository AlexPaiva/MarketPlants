USE MarketPlants;

-- Adding Tipo Values
INSERT INTO MarketPlants.Tipo(Email,NIF) VALUES ('joaosa@email.com', 244455123);
INSERT INTO MarketPlants.Tipo(Email,NIF) VALUES ('pedro@email.com', 246755123);
INSERT INTO MarketPlants.Tipo(Email,NIF) VALUES ('mariaflorista@email.com', 200000333);
INSERT INTO MarketPlants.Tipo(Email,NIF) VALUES ('estufasmartins@email.com', 767349028);
INSERT INTO MarketPlants.Tipo(Email,NIF) VALUES ('josepaz@email.com', 932756398);
SELECT * FROM MarketPlants.Tipo;

-- Adding Utilizador Values
INSERT INTO MarketPlants.Utilizador(Username,Senha) VALUES ('JoaoS', 'password');
INSERT INTO MarketPlants.Utilizador(Username,Senha) VALUES ('psamaral', 'password');
INSERT INTO MarketPlants.Utilizador(Username,Senha) VALUES ('JosePaz', 'password');
INSERT INTO MarketPlants.Utilizador(Username,Senha) VALUES ('EstufasMartins', 'password');
INSERT INTO MarketPlants.Utilizador(Username,Senha) VALUES ('MariaFlorista', 'password');
SELECT * FROM MarketPlants.Utilizador;

-- Adding Pessoa Values
INSERT INTO MarketPlants.Pessoa(PrimeiroNome, UltimoNome, Morada, Genero, NrTelefone,NIF, Username,Email) VALUES ('João', 'Silva', 'Rua das Flores, 123', 'M',213456789,244455123,'JoaoS','joaosa@email.com');
INSERT INTO MarketPlants.Pessoa(PrimeiroNome, UltimoNome, Morada, Genero, NrTelefone,NIF, Username,Email) VALUES ('Pedro', 'Amaral', 'Avenida das Palmeiras, 3', 'M',939545678,246755123,'psamaral','pedro@email.com');
INSERT INTO MarketPlants.Pessoa(PrimeiroNome, UltimoNome, Morada, Genero, NrTelefone,NIF, Username,Email) VALUES ('José', 'Paz', 'Rua da Liberdade, 443', 'M',966666666,932756398,'Josepaz','josepaz@email.com');
SELECT * FROM MarketPlants.Pessoa;

-- Adding Empresa Values
INSERT INTO MarketPlants.Empresa(Nome,NIF,Email,Username,NrTelefone,Morada,Descricao) VALUES ('Maria Florista',200000333,'mariaflorista@email.com','MariaFlorista',232455122, 'Rua das Pombas, 34', 'We sell the best plants at the best prices!');
INSERT INTO MarketPlants.Empresa(Nome,NIF,Email,Username,NrTelefone,Morada,Descricao) VALUES ('Estufas Martins',767349028,'estufasmartins@email.com','EstufasMartins',254578866, 'Rua das Labaredas, 324', 'We sell the plants straight from the ground to you!');
SELECT * FROM MarketPlants.Empresa;

-- Adding Vendedores Values
INSERT INTO MarketPlants.Vendedor(Username,Rating,CondicoesDeLevantamentoEntrega) VALUES ('JoaoS',4.2,'No shipping');
INSERT INTO MarketPlants.Vendedor(Username,Rating,CondicoesDeLevantamentoEntrega) VALUES ('psamaral',4.9,'Shipping to Portugal by 3.99€');
INSERT INTO MarketPlants.Vendedor(Username,Rating,CondicoesDeLevantamentoEntrega) VALUES ('JosePaz',2.4,'No shipping');
INSERT INTO MarketPlants.Vendedor(Username,Rating,CondicoesDeLevantamentoEntrega) VALUES ('MariaFlorista',4.3,'Shipping to Portugal by 7.99€');
INSERT INTO MarketPlants.Vendedor(Username,Rating,CondicoesDeLevantamentoEntrega) VALUES ('EstufasMartins',4.1,'Shipping to Portugal by 1.00€');
SELECT * FROM MarketPlants.Vendedor;

-- Adding Compradores Values
INSERT INTO MarketPlants.Comprador(Username,DadosDePagamento) VALUES ('JoaoS','Payment data');
INSERT INTO MarketPlants.Comprador(Username,DadosDePagamento) VALUES ('psamaral','Payment data');
INSERT INTO MarketPlants.Comprador(Username,DadosDePagamento) VALUES ('JosePaz','Payment data');
INSERT INTO MarketPlants.Comprador(Username,DadosDePagamento) VALUES ('MariaFlorista','Payment data');
INSERT INTO MarketPlants.Comprador(Username,DadosDePagamento) VALUES ('EstufasMartins','Payment data');
SELECT * FROM MarketPlants.Comprador;

-- Insert data into MarketPlants.Artigo Manually
INSERT INTO MarketPlants.Artigo(ID_Vendedor) VALUES (6);
INSERT INTO MarketPlants.Artigo(ID_Vendedor) VALUES (7);
INSERT INTO MarketPlants.Artigo(ID_Vendedor) VALUES (8);
INSERT INTO MarketPlants.Artigo(ID_Vendedor) VALUES (9);
INSERT INTO MarketPlants.Artigo(ID_Vendedor) VALUES (10);
INSERT INTO MarketPlants.Artigo(ID_Vendedor) VALUES (11);
INSERT INTO MarketPlants.Artigo(ID_Vendedor) VALUES (12);
INSERT INTO MarketPlants.Artigo(ID_Vendedor) VALUES (13);
INSERT INTO MarketPlants.Artigo(ID_Vendedor) VALUES (14);
INSERT INTO MarketPlants.Artigo(ID_Vendedor) VALUES (15);
SELECT * FROM MarketPlants.Artigo;

-- Insert data into MarketPlants.Planta with a connection to Artigo
INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Monstera deliciosa', 'Swiss Cheese Plant', 'Plantae', 'Araceae', 'Indoor', 'Large, glossy leaves with unique hole patterns.', 31);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Ficus lyrata', 'Fiddle Leaf Fig', 'Plantae', 'Moraceae', 'Indoor', 'Tall, violin-shaped leaves with a lush appearance.', 32);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Sansevieria trifasciata', 'Snake Plant', 'Plantae', 'Asparagaceae', 'Indoor', 'Tall, upright leaves with yellow-edged green stripes.', 33);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Epipremnum aureum', 'Pothos', 'Plantae', 'Araceae', 'Indoor', 'Vining plant with heart-shaped leaves in various shades of green.', 34);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Spathiphyllum wallisii', 'Peace Lily', 'Plantae', 'Araceae', 'Indoor', 'Dark green leaves and white flowers, excellent air purifier.', 35);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Chlorophytum comosum', 'Spider Plant', 'Plantae', 'Asparagaceae', 'Indoor', 'Arching leaves with green and white stripes, produces plantlets.', 36);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Ficus elastica', 'Rubber Tree', 'Plantae', 'Moraceae', 'Indoor', 'Large, shiny leaves with burgundy or green coloration.', 37);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Zamioculcas zamiifolia', 'ZZ Plant', 'Plantae', 'Araceae', 'Indoor', 'Drought-tolerant plant with glossy, dark green leaves.', 38);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Dracaena marginata', 'Dragon Tree', 'Plantae', 'Asparagaceae', 'Indoor', 'Slender, upright leaves with red edges, low maintenance.', 39);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Strelitzia reginae', 'Bird of Paradise', 'Plantae', 'Strelitziaceae', 'Indoor', 'Tropical plant with large, banana-like leaves and vibrant flowers.', 40);

SELECT * FROM MarketPlants.Planta;
-- Adding Flor Values
INSERT INTO MarketPlants.Flor(NomeCientifico, NomeComum, Caracteristicas, NomeCientificoPlanta)
VALUES ('Hibiscus rosa-sinensis', 'Hibiscus', 'Large, showy flowers in various colors.', 'Monstera deliciosa');

INSERT INTO MarketPlants.Flor(NomeCientifico, NomeComum, Caracteristicas, NomeCientificoPlanta)
VALUES ('Rosa', 'Rose', 'Fragrant flowers with a wide range of colors.', 'Monstera deliciosa');
SELECT * FROM MarketPlants.Flor;

-- Adding Fruto Values
INSERT INTO MarketPlants.Fruto(NomeCientifico, NomeComum, Caracteristicas, Epoca, Replantavel, NomeCientificoFlor)
VALUES ('Malus domestica', 'Apple', 'Crisp and juicy fruit available in various cultivars.', 'Autumn', 'Yes', 'Hibiscus rosa-sinensis');

INSERT INTO MarketPlants.Fruto(NomeCientifico, NomeComum, Caracteristicas, Epoca, Replantavel, NomeCientificoFlor)
VALUES ('Citrus sinensis', 'Orange', 'Round citrus fruit with a sweet and tangy flavor.', 'Winter', 'Yes', 'Hibiscus rosa-sinensis');
SELECT * FROM MarketPlants.Fruto;

-- Adding Carrinho Values
INSERT INTO MarketPlants.Carrinho(ID_Comprador)
VALUES (1);
SELECT * FROM MarketPlants.Carrinho

-- Adding CarrinhoArtigo Values
INSERT INTO MarketPlants.CarrinhoArtigo(ID_Carrinho, ID_Artigo)
VALUES (1, 31);

INSERT INTO MarketPlants.CarrinhoArtigo(ID_Carrinho, ID_Artigo)
VALUES (1, 32);
SELECT * FROM MarketPlants.CarrinhoArtigo