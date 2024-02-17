USE MarketPlants
GO
--UDF 1 - Obter numero de telemovel no formato correto
CREATE FUNCTION FormatPhoneNumber(@phoneNumber VARCHAR(9))
RETURNS VARCHAR(11) AS
BEGIN
   RETURN SUBSTRING(@phoneNumber, 1, 3) + '-' + SUBSTRING(@phoneNumber, 4, 3) + '-' + SUBSTRING(@phoneNumber, 7, 3)
END
--
USE MarketPlants
GO
--UDF 2 - Obter numero de telemove no formato de base de dados
CREATE FUNCTION RemoveDashes(@str NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS
BEGIN
  RETURN REPLACE(@str, '-', '')
END
--
--
