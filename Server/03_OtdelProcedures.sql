CREATE PROCEDURE [dbo].[otdel_add_Proc]
	@nomerOtdela int,
	@nazvanieOtdela nvarchar(50)
AS
	IF EXISTS (SELECT * FROM [Otdel]
	WHERE nomerOtdela = @nomerOtdela AND nazvanieOtdela != @nazvanieOtdela)
		THROW 51000, 'Ошибка ввода! Этот номер отдела уже используется.', 1
	ELSE
	IF EXISTS (SELECT * FROM [Otdel]
	WHERE nomerOtdela != @nomerOtdela AND nazvanieOtdela = @nazvanieOtdela)
		THROW 51000, 'Ошибка ввода! Это название отдела уже присвоено другому номеру отдела.', 1
	ELSE
	IF EXISTS (SELECT * FROM [Otdel]
	WHERE nomerOtdela = @nomerOtdela AND nazvanieOtdela = @nazvanieOtdela)
		THROW 51000, 'Ошибка ввода! Такой отдел уже существует.', 1
	ELSE
		INSERT INTO Otdel VALUES (@nomerOtdela, @nazvanieOtdela)
RETURN 0

CREATE PROCEDURE [dbo].[otdel_del_Proc]
	@nomerOtdela int
AS
	IF (NOT EXISTS (SELECT nomerOtdela FROM [Otdel]
	WHERE nomerOtdela = @nomerOtdela))
		THROW 51000, 'Ошибка удаления! Такая запись не существует!', 1
	IF (NOT EXISTS
	(SELECT [Sotrudnik].nomerOtdela
	FROM [Sotrudnik] WHERE nomerOtdela = @nomerOtdela))
		DELETE FROM [Otdel] WHERE (nomerOtdela = @nomerOtdela)
	ELSE
		THROW 51000, 'Ошибка удаления! Нарушение целостности:
		есть записи в таблице [Sotrudnik],
		указывающие на запись с таким номером отдела в данной таблице ([Otdel])', 1
RETURN 0

CREATE PROCEDURE [dbo].[otdel_mod_Proc]
	@nomerOtdela int,
	@nazvanieOtdela nvarchar(255)
AS
	IF NOT EXISTS (SELECT * FROM [Otdel] WHERE nomerOtdela = @nomerOtdela)
		THROW 51000, 'Ошибка изменения! Такой записи не существует.', 1
	IF NOT EXISTS (SELECT * FROM [Otdel] 
	WHERE NOT nomerOtdela = @nomerOtdela AND nazvanieOtdela=@nazvanieOtdela)
		UPDATE Otdel SET nazvanieOtdela = @nazvanieOtdela WHERE (nomerOtdela = @nomerOtdela)
	ELSE
		THROW 51000, 'Ошибка изменения! Записываемое название отдела уже содержится в таблице под другим номером отдела', 1
RETURN 0

CREATE PROCEDURE [dbo].[otdel_show_Proc]
AS
	SELECT * FROM otdel_View
RETURN 0
