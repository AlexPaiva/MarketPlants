--Calcular idade com base no ano de nascimento
CREATE FUNCTION CalculateAge (@BirthDate DATE)
RETURNS INT
AS
BEGIN
    DECLARE @Age INT
    SET @Age = DATEDIFF(YEAR, @BirthDate, GETDATE())
    RETURN @Age
END;

--Obter o nome completo
CREATE FUNCTION GetFullName (@FirstName NVARCHAR(50), @LastName NVARCHAR(50))
RETURNS NVARCHAR(100)
AS
BEGIN
    DECLARE @FullName NVARCHAR(100)
    SET @FullName = CONCAT(@FirstName, ' ', @LastName)
    RETURN @FullName
END;

--Obter numero de telemovel no formato correto
CREATE FUNCTION FormatPhoneNumber (@PhoneNumber VARCHAR(20))
RETURNS VARCHAR(20)
AS
BEGIN
    DECLARE @FormattedPhoneNumber VARCHAR(20)
    SET @FormattedPhoneNumber = CONCAT('(', LEFT(@PhoneNumber, 2), ') ', SUBSTRING(@PhoneNumber, 3, 4), '-', SUBSTRING(@PhoneNumber, 7, 4))
    RETURN @FormattedPhoneNumber
END;

