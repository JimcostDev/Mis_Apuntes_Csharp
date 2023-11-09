USE [Test]


CREATE PROCEDURE [dbo].[pa_ConsultarEquipos]
AS
BEGIN
	BEGIN TRY
		-- Consultar todos los Equipos
		SELECT [ID], [Name], [LeagueID] 
		FROM [dbo].[Team]
	END TRY
	BEGIN CATCH
		-- Manejo de errores
		PRINT ERROR_MESSAGE()
	END CATCH
END