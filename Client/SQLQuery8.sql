USE [GorbunovAEOKadrov]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[otdel_add_Proc]
		@nomerOtdela = 1,
		@nazvanieOtdela = N'Руководство'

SELECT	@return_value as 'Return Value'

GO
