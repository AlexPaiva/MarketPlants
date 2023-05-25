-- Triggers.sql
CREATE TRIGGER CheckQuantidade
BEFORE INSERT ON Vendas
FOR EACH ROW
BEGIN
    IF NEW.Quantidade <= 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Quantidade deve ser maior que 0';
    END IF;
END;