-- InsertData.sql
USE MarketPlants;

-- Adding Tipo Values
INSERT INTO MarketPlants.Tipo(Email,NIF) values ('joaosa@email.com', 244455123);
INSERT INTO MarketPlants.Tipo(Email,NIF) values ('pedro@email.com', 246755123);
INSERT INTO MarketPlants.Tipo(Email,NIF) values ('mariaflorista@email.com', 200000333);
INSERT INTO MarketPlants.Tipo(Email,NIF) values ('estufasmartins@email.com', 767349028);
INSERT INTO MarketPlants.Tipo(Email,NIF) values ('josepaz@email.com', 932756398);
select * from MarketPlants.Tipo;

-- Adding Utilizador Values
INSERT INTO MarketPlants.Utilizador(Username,Senha) values('JoaoS', 'password');
INSERT INTO MarketPlants.Utilizador(Username,Senha) values('psamaral', 'password');
INSERT INTO MarketPlants.Utilizador(Username,Senha) values('JosePaz', 'password');
INSERT INTO MarketPlants.Utilizador(Username,Senha) values('EstufasMartins', 'password');
INSERT INTO MarketPlants.Utilizador(Username,Senha) values('MariaFlorista', 'password');
select * from MarketPlants.Utilizador;

-- Adding Pessoa Values
INSERT INTO MarketPlants.Pessoa(PrimeiroNome, UltimoNome, Morada, Genero, NrTelefone,NIF, Username,Email) VALUES('João', 'Silva', 'Rua das Flores, 123', 'M',213456789,244455123,'JoaoS','joaosa@email.com');
INSERT INTO MarketPlants.Pessoa(PrimeiroNome, UltimoNome, Morada, Genero, NrTelefone,NIF, Username,Email) VALUES('Pedro', 'Amaral', 'Avenida das Palmeiras, 3', 'M',939545678,246755123,'psamaral','pedro@email.com');
INSERT INTO MarketPlants.Pessoa(PrimeiroNome, UltimoNome, Morada, Genero, NrTelefone,NIF, Username,Email) VALUES('José', 'Paz', 'Rua da Liberdade, 443', 'M',966666666,932756398,'Josepaz','josepaz@email.com');
select * from MarketPlants.Pessoa;

-- Adding Empresa Values
INSERT INTO MarketPlants.Empresa(Nome,NIF,Email,Username,NrTelefone,Morada,Descricao) values('Maria Florista',200000333,'mariaflorista@email.com','MariaFlorista',232455122, 'Rua das Pombas, 34', 'We sell the best plants at the best prices!')
INSERT INTO MarketPlants.Empresa(Nome,NIF,Email,Username,NrTelefone,Morada,Descricao) values('Estufas Martins',767349028,'estufasmartins@email.com','EstufasMartins',254578866, 'Rua das Labaredas, 324', 'We sell the plants straight from the ground to you!')
select *  from MarketPlants.Empresa

-- Adding Vendedores Values
INSERT INTO MarketPlants.Vendedor(Username,Rating,CondicoesDeLevantamentoEntrega) values('JoaoS',4.2,'No shipping')
INSERT INTO MarketPlants.Vendedor(Username,Rating,CondicoesDeLevantamentoEntrega) values('psamaral',4.9,'Shipping to Portugal by 3.99€')
INSERT INTO MarketPlants.Vendedor(Username,Rating,CondicoesDeLevantamentoEntrega) values('JosePaz',2.4,'No shipping')
INSERT INTO MarketPlants.Vendedor(Username,Rating,CondicoesDeLevantamentoEntrega) values('MariaFlorista',4.3,'Shipping to Portugal by 7.99€')
INSERT INTO MarketPlants.Vendedor(Username,Rating,CondicoesDeLevantamentoEntrega) values('EstufasMartins',4.1,'Shipping to Portugal by 1.00€')
select * from MarketPlants.Vendedor

-- Adding Compradores Values
INSERT INTO MarketPlants.Comprador(Username,DadosDePagamento) values('JoaoS','Payment data')
INSERT INTO MarketPlants.Comprador(Username,DadosDePagamento) values('psamaral','Payment data')
INSERT INTO MarketPlants.Comprador(Username,DadosDePagamento) values('JosePaz','Payment data')
INSERT INTO MarketPlants.Comprador(Username,DadosDePagamento) values('MariaFlorista','Payment data')
INSERT INTO MarketPlants.Comprador(Username,DadosDePagamento) values('EstufasMartins','Payment data')
select * from MarketPlants.Comprador

-- Adding EntidadeRegulamentadora Values
INSERT INTO MarketPlants.EntidadeRegulamentadora(nome, ID_Vendedor) VALUES ('Instituto da Conservação da Natureza e das Florestas', 1);
INSERT INTO MarketPlants.EntidadeRegulamentadora(nome, ID_Vendedor) VALUES ('Direção-Geral de Alimentação e Veterinária', 3);

SELECT * FROM MarketPlants.EntidadeRegulamentadora;

-- Adding Catalogo Values
INSERT INTO MarketPlants.Catalogo(NrArtigos, Promocao) VALUES (5, 10);
INSERT INTO MarketPlants.Catalogo(NrArtigos, Promocao) VALUES (8, 15);
INSERT INTO MarketPlants.Catalogo(NrArtigos, Promocao) VALUES (3, 12);
INSERT INTO MarketPlants.Catalogo(NrArtigos, Promocao) VALUES (10, 5);
INSERT INTO MarketPlants.Catalogo(NrArtigos, Promocao) VALUES (6, 8);

SELECT * FROM MarketPlants.Catalogo;

-- Adding Artigo Values

INSERT INTO MarketPlants.Artigo(Descricao, Preco, ID_Vendedor) VALUES ('Monstera Deliciosa', 35, 1);
INSERT INTO MarketPlants.Artigo(Descricao, Preco, ID_Vendedor) VALUES ('Fiddle Leaf Fig', 50, 1);

INSERT INTO MarketPlants.Artigo(Descricao, Preco, ID_Vendedor) VALUES ('Snake Plant', 20, 2);
INSERT INTO MarketPlants.Artigo(Descricao, Preco, ID_Vendedor) VALUES ('Pothos', 15, 2);

INSERT INTO MarketPlants.Artigo(Descricao, Preco, ID_Vendedor) VALUES ('Peace Lily', 25, 3);
INSERT INTO MarketPlants.Artigo(Descricao, Preco, ID_Vendedor) VALUES ('Spider Plant', 18, 3);

INSERT INTO MarketPlants.Artigo(Descricao, Preco, ID_Vendedor) VALUES ('Rubber Tree', 30, 4);
INSERT INTO MarketPlants.Artigo(Descricao, Preco, ID_Vendedor) VALUES ('ZZ Plant', 22, 4);

INSERT INTO MarketPlants.Artigo(Descricao, Preco, ID_Vendedor) VALUES ('Dracaena Marginata', 40, 5);
INSERT INTO MarketPlants.Artigo(Descricao, Preco, ID_Vendedor) VALUES ('Bird of Paradise', 35, 5);

SELECT * FROM MarketPlants.Artigo;

-- Adding Planta Values
INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Monstera deliciosa', 'Swiss Cheese Plant', 'Plantae', 'Araceae', 'Indoor', 'Large, glossy leaves with unique hole patterns.', 1);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Ficus lyrata', 'Fiddle Leaf Fig', 'Plantae', 'Moraceae', 'Indoor', 'Tall, violin-shaped leaves with a lush appearance.', 2);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Sansevieria trifasciata', 'Snake Plant', 'Plantae', 'Asparagaceae', 'Indoor', 'Tall, upright leaves with yellow-edged green stripes.', 3);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Epipremnum aureum', 'Pothos', 'Plantae', 'Araceae', 'Indoor', 'Vining plant with heart-shaped leaves in various shades of green.', 4);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Spathiphyllum wallisii', 'Peace Lily', 'Plantae', 'Araceae', 'Indoor', 'Dark green leaves and white flowers, excellent air purifier.', 5);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Chlorophytum comosum', 'Spider Plant', 'Plantae', 'Asparagaceae', 'Indoor', 'Arching leaves with green and white stripes, produces plantlets.', 6);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Ficus elastica', 'Rubber Tree', 'Plantae', 'Moraceae', 'Indoor', 'Large, shiny leaves with burgundy or green coloration.', 7);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Zamioculcas zamiifolia', 'ZZ Plant', 'Plantae', 'Araceae', 'Indoor', 'Drought-tolerant plant with glossy, dark green leaves.', 8);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Dracaena marginata', 'Dragon Tree', 'Plantae', 'Asparagaceae', 'Indoor', 'Slender, upright leaves with red edges, low maintenance.', 9);

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas, ID_Artigo)
VALUES ('Strelitzia reginae', 'Bird of Paradise', 'Plantae', 'Strelitziaceae', 'Indoor', 'Tropical plant with large, banana-like leaves and vibrant flowers.', 10);

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

-- Adding Categoria Values
INSERT INTO MarketPlants.Categoria(ID_Categoria, Nome, Designacao, NomeCientificoPlanta)
VALUES (1, 'Folhagens', 'Plantas com folhas decorativas.', 'Monstera deliciosa');

INSERT INTO MarketPlants.Categoria(ID_Categoria, Nome, Designacao, NomeCientificoPlanta)
VALUES (2, 'Árvores Frutíferas', 'Plantas que produzem frutas comestíveis.', 'Monstera deliciosa');
SELECT * FROM MarketPlants.Categoria;

-- Adding Carrinho Values
INSERT INTO MarketPlants.Carrinho(ID_Comprador, ID_Vendedor, PrecoTotal)
VALUES (1, 1, 100);

INSERT INTO MarketPlants.Carrinho(ID_Comprador, ID_Vendedor, PrecoTotal)
VALUES (2, 2, 75);
SELECT * FROM MarketPlants.Carrinho;


-- Adding CarrinhoArtigo Values
INSERT INTO MarketPlants.CarrinhoArtigo(ID_Carrinho, ID_Artigo, Quantidade, Preco)
VALUES (1, 1, 2, 70);

INSERT INTO MarketPlants.CarrinhoArtigo(ID_Carrinho, ID_Artigo, Quantidade, Preco)
VALUES (2, 2, 1, 50);
SELECT * FROM MarketPlants.CarrinhoArtigo;




