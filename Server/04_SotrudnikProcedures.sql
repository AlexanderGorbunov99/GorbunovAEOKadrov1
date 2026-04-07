CREATE PROCEDURE [dbo].[sotrud_add_Proc]
	@tabelNomerSotr int,
	@familiya nvarchar(50),
	@imya nvarchar(50),
	@otchestvo nvarchar(50),
	@stazhRaboty int,
	@polSotrudnika nchar(1),
	@nomerOtdela int
AS
	IF (NOT EXISTS (SELECT [Otdel].nomerOtdela FROM  [Otdel]
		WHERE nomerOtdela=@nomerOtdela))
		THROW 51000, 'Ошибка ввода номера отдела! Такого отдела не существует!', 1
	ELSE 
	IF EXISTS (SELECT * FROM [Sotrudnik]
	WHERE TabelNomerSotr = @tabelNomerSotr AND (Familiya != @familiya OR Imya != @imya 
	OR Otchestvo!=@otchestvo OR StazhRaboty!=@stazhRaboty OR PolSortudnika!=@polSotrudnika OR nomerOtdela!=@nomerOtdela))
		THROW 51000, 'Ошибка ввода! Этот табельный номер уже присвоен другому сотруднику', 1
		ELSE IF EXISTS (SELECT * FROM [Sotrudnik]
	WHERE TabelNomerSotr = @tabelNomerSotr AND Familiya = @familiya AND Imya = @imya 
	AND Otchestvo=@otchestvo AND StazhRaboty=@stazhRaboty AND PolSortudnika=@polSotrudnika AND nomerOtdela=@nomerOtdela)
		THROW 51000, 'Ошибка ввода! Такая запись уже существует.', 1
	ELSE
		INSERT INTO Sotrudnik VALUES (@tabelNomerSotr, @familiya, @imya, @otchestvo, @stazhRaboty, @polSotrudnika, @nomerOtdela)
RETURN 0

CREATE PROCEDURE [dbo].[sotrud_del_Proc]
	@TabelNomerSotr int
AS
	IF (NOT EXISTS (SELECT TabelNomerSotr FROM [Sotrudnik]
	WHERE TabelNomerSotr = @TabelNomerSotr))
		THROW 51000, 'Ошибка удаления! Такая запись не существует!', 1
	IF (NOT EXISTS
	(SELECT [Dety].TabelNomerSotr
	FROM [Dety] WHERE TabelNomerSotr = @TabelNomerSotr))
		DELETE FROM [Sotrudnik] WHERE (TabelNomerSotr = @TabelNomerSotr)
	ELSE
		THROW 51000, 'Ошибка удаления! Нарушение целостности:
		есть записи в таблице [Dety],
		указывающие на запись с таким табельным номером сотрудника в данной таблице ([Sotrudnik])', 1
RETURN 0

CREATE PROCEDURE [dbo].[sotrud_mod_Proc]
	@TabelNomerSotr int,
	@Familiya nvarchar(50),
	@Imya nvarchar(50),
	@Otchestvo nvarchar(50),
	@StazhRaboty int,
	@PolSotrudnika nchar(1),
	@nomerOtdela int
AS
	IF NOT EXISTS (SELECT * FROM [Sotrudnik] WHERE TabelNomerSotr = @TabelNomerSotr)
		THROW 51000, 'Ошибка изменения! Сотрудника с таким табельным номером не существует.', 1
	ELSE
	IF NOT EXISTS (SELECT * FROM [Otdel] WHERE nomerOtdela = @nomerOtdela)
		THROW 51000, 'Ошибка изменения! Такого номера отдела не существует.', 1
	ELSE
	IF NOT EXISTS (SELECT * FROM [Sotrudnik] 
		WHERE NOT TabelNomerSotr = @TabelNomerSotr AND Familiya=@Familiya AND Imya = @Imya AND 
		Otchestvo = @Otchestvo AND StazhRaboty = @StazhRaboty AND PolSortudnika = @PolSotrudnika)
		UPDATE Sotrudnik
	SET Familiya = @Familiya, Imya = @Imya, Otchestvo=@Otchestvo, StazhRaboty=@StazhRaboty, PolSortudnika=@PolSotrudnika,
	nomerOtdela = @nomerOtdela
		WHERE (TabelNomerSotr = @TabelNomerSotr)
	ELSE
		THROW 51000, 'Ошибка изменения! Записываемый сотрудник уже содержится в таблице под другим табельным номером', 1
RETURN 0

CREATE PROCEDURE [dbo].[sotrud_show_Proc]
AS
	SELECT * FROM Sotrudnik_View
RETURN 0
