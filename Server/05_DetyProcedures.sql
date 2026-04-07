CREATE PROCEDURE [dbo].[dety_add_Proc]
	@NomerSvidORozh nvarchar(15),
	@Imya nvarchar(50),
	@GodRozh int,
	@Pol nchar(1),
	@TabelNomerSotr int
AS
	IF (NOT EXISTS (SELECT [Sotrudnik].TabelNomerSotr FROM  [Sotrudnik]
		WHERE TabelNomerSotr=@TabelNomerSotr))
		THROW 51000, 'Ошибка ввода табельного номера сотрудника! Такого сотрудника не существует!', 1
	ELSE 
	IF EXISTS (SELECT * FROM [Dety]
	WHERE NomerSvidORozh = @NomerSvidORozh AND (Imya != @Imya OR GodRozh != @GodRozh 
	OR Pol!=@Pol OR TabelNomerSotr!=@TabelNomerSotr))
		THROW 51000, 'Ошибка ввода! Это номер свидетельства о рождении другого ребенка, введенного в базу данных', 1
		ELSE IF EXISTS (SELECT * FROM [Dety]
	WHERE NomerSvidORozh = @NomerSvidORozh AND Imya = @imya 
	AND GodRozh=@GodRozh AND Pol=@Pol AND TabelNomerSotr=@TabelNomerSotr)
		THROW 51000, 'Ошибка ввода! Такая запись уже существует.', 1
	ELSE
		INSERT INTO Dety VALUES (@NomerSvidORozh, @imya, @GodRozh, @Pol, @TabelNomerSotr)
RETURN 0

CREATE PROCEDURE [dbo].[dety_del_Proc]
	@NomerSvidORozh nvarchar(15)
AS
	IF (NOT EXISTS (SELECT NomerSvidORozh FROM [Dety]
	WHERE NomerSvidORozh = @NomerSvidORozh))
		THROW 51000, 'Ошибка удаления! Такая запись не существует!', 1
	ELSE
	DELETE FROM [Dety] WHERE (NomerSvidORozh = @NomerSvidORozh)
RETURN 0

CREATE PROCEDURE [dbo].[dety_mod_Proc]
	@NomerSvidORozh nvarchar(15),
	@Imya nvarchar(50),
	@GodRozh int,
	@Pol nchar(1),
	@TabelNomerSotr int
AS
	IF NOT EXISTS (SELECT * FROM [Dety] WHERE NomerSvidORozh = @NomerSvidORozh)
		THROW 51000, 'Ошибка изменения! Ребенка с таким номером свидетельства о рождении в базе данных не существует.', 1
	ELSE
	IF NOT EXISTS (SELECT * FROM [Sotrudnik] WHERE TabelNomerSotr = @TabelNomerSotr)
		THROW 51000, 'Ошибка изменения! Такого сотрудника не существует.', 1
	ELSE
	IF NOT EXISTS (SELECT * FROM [Dety] 
		WHERE NOT NomerSvidORozh = @NomerSvidORozh AND Imya = @Imya AND 
		GodRozh = @GodRozh AND Pol = @Pol AND TabelNomerSotr=@TabelNomerSotr)
		UPDATE Dety
	SET Imya = @Imya, GodRozh=@GodRozh, Pol=@Pol, TabelNomerSotr=@TabelNomerSotr
		WHERE (NomerSvidORozh = @NomerSvidORozh)
	ELSE
		THROW 51000, 'Ошибка изменения! Записываемый ребенок уже содержится в таблице под другим свидетельством о рождении', 1
RETURN 0

CREATE PROCEDURE [dbo].[dety_show_Proc]
AS
	SELECT * FROM Dety_View
RETURN 0
