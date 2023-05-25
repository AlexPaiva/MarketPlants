-- InsertData.sql
USE MarketPlants;

-- Adding Tipo Values
INSERT INTO MarketPlants.Tipo(Email,NIF) values ('joaosa@email.com', 244455123)
INSERT INTO MarketPlants.Tipo(Email,NIF) values ('pedro@email.com', 246755123)
INSERT INTO MarketPlants.Tipo(Email,NIF) values ('mariaflorista@email.com', 200000333)
INSERT INTO MarketPlants.Tipo(Email,NIF) values ('estufasmartins@email.com', 767349028)
INSERT INTO MarketPlants.Tipo(Email,NIF) values ('josepaz@email.com', 932756398)
select * from MarketPlants.Tipo

-- Adding Utilizador Values
INSERT INTO MarketPlants.Utilizador(Username,Senha) values('JoaoS', 'password')
INSERT INTO MarketPlants.Utilizador(Username,Senha) values('psamaral', 'password')
INSERT INTO MarketPlants.Utilizador(Username,Senha) values('JosePaz', 'password')
INSERT INTO MarketPlants.Utilizador(Username,Senha) values('EstufasMartins', 'password')
INSERT INTO MarketPlants.Utilizador(Username,Senha) values('MariaFlorista', 'password')
select * from MarketPlants.Utilizador

-- Adding Pessoa Values
INSERT INTO MarketPlants.Pessoa(PrimeiroNome, UltimoNome, Morada, Genero, NrTelefone,NIFUt, Username,Email) VALUES('João', 'Silva', 'Rua das Flores, 123', 'M',213456789,244455123,'JoaoS','joaosa@email.com');
INSERT INTO MarketPlants.Pessoa(PrimeiroNome, UltimoNome, Morada, Genero, NrTelefone,NIFUt, Username,Email) VALUES('Pedro', 'Amaral', 'Avenida das Palmeiras, 3', 'M',939545678,246755123,'psamaral','pedro@email.com');
INSERT INTO MarketPlants.Pessoa(PrimeiroNome, UltimoNome, Morada, Genero, NrTelefone,NIFUt, Username,Email) VALUES('José', 'Paz', 'Rua da Liberdade, 443', 'M',966666666,932756398,'Josepaz','josepaz@email.com');
select * from MarketPlants.Pessoa

-- Adding Empresa Values
INSERT INTO MarketPlants.Empresa(Nome,NIFUt,Email,Username,NrTelefone,Morada,Descricao) values('Maria Florista',200000333,'mariaflorista@email.com','MariaFlorista',232455122, 'Rua das Pombas, 34', 'We sell the best plants at the best prices!')
INSERT INTO MarketPlants.Empresa(Nome,NIFUt,Email,Username,NrTelefone,Morada,Descricao) values('Estufas Martins',767349028,'estufasmartins@email.com','EstufasMartins',254578866, 'Rua das Labaredas, 324', 'We sell the plants straight from the ground to you!')
select *  from MarketPlants.Empresa

-- Adding Vendedores Values
INSERT INTO MarketPlants.Vendedor(ID_Vendedor,Username,Rating,CondicoesDeLevantamentoEntrega) values(1,'JoaoS',4.2,'No shipping')
INSERT INTO MarketPlants.Vendedor(ID_Vendedor,Username,Rating,CondicoesDeLevantamentoEntrega) values(2,'psamaral',4.9,'Shipping to Portugal by 3.99€')
INSERT INTO MarketPlants.Vendedor(ID_Vendedor,Username,Rating,CondicoesDeLevantamentoEntrega) values(3,'JosePaz',2.4,'No shipping')
INSERT INTO MarketPlants.Vendedor(ID_Vendedor,Username,Rating,CondicoesDeLevantamentoEntrega) values(4,'MariaFlorista',4.3,'Shipping to Portugal by 7.99€')
INSERT INTO MarketPlants.Vendedor(ID_Vendedor,Username,Rating,CondicoesDeLevantamentoEntrega) values(5,'EstufasMartins',4.1,'Shipping to Portugal by 1.00€')
select * from MarketPlants.Vendedor

-- Adding Compradores Values
INSERT INTO MarketPlants.Comprador(ID_Comprador,Username,DadosDePagamento) values(1,'JoaoS','Payment data')
INSERT INTO MarketPlants.Comprador(ID_Comprador,Username,DadosDePagamento) values(2,'psamaral','Payment data')
INSERT INTO MarketPlants.Comprador(ID_Comprador,Username,DadosDePagamento) values(3,'JosePaz','Payment data')
INSERT INTO MarketPlants.Comprador(ID_Comprador,Username,DadosDePagamento) values(4,'MariaFlorista','Payment data')
INSERT INTO MarketPlants.Comprador(ID_Comprador,Username,DadosDePagamento) values(5,'EstufasMartins','Payment data')
select * from MarketPlants.Comprador

INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia,Ambiente,Caracteristicas) VALUES('Rosa sp.', 'Rose', 'Plantae', 'Rosaceae', 'Garden', 'Flowering shrub with thorny stems and fragrant blossoms.');
INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia,Ambiente,Caracteristicas) VALUES('Ficus benjamina', 'Weeping Fig', 'Plantae', 'Moraceae', 'Indoor', 'Indoor tree with glossy leaves and pendulous branches.');
INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia,Ambiente,Caracteristicas) VALUES('Lavandula angustifolia', 'Lavender', 'Plantae', 'Lamiaceae', 'Garden', 'Aromatic herb with purple flowers and gray-green foliage.');
INSERT INTO MarketPlants.Planta(NomeCientifico, NomeComum, Reino, Familia, Ambiente, Caracteristicas) VALUES('Spathiphyllum wallisii', 'Peace Lily', 'Plantae', 'Araceae', 'Indoor', 'Indoor plant with dark green leaves and white spathes.');
select * from MarketPlants.Planta