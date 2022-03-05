-- =============================================
-- Author:        <Kevin Segura>
-- Create date: <05/03/2022>
-- Description:    <Procedimiento que elimina instituciones>
-- =============================================
CREATE PROCEDURE [dbo].[InstitucionEliminar]
	@Id_Institucion INT

AS
BEGIN
 SET NOCOUNT ON
 BEGIN TRANSACTION
 BEGIN TRY

 DELETE  FROM dbo.Institucion WHERE Id_Institucion=@Id_Institucion

 COMMIT TRANSACTION TRASA
 /*Si no hay error*/
 SELECT 0 AS CodError, ''AS MsgError
 END TRY

 /*Si hay error*/
 BEGIN CATCH
    SELECT
        ERROR_NUMBER() AS CodError,
        ERROR_MESSAGE() AS MsgError
 ROLLBACK TRANSACTION TRASA

 END CATCH


 /***/
 END