-- =============================================
-- Author:        <Kevin Segura>
-- Create date: <05/03/2022>
-- Description:    <Procedimiento que inserta instituciones>
-- =============================================
CREATE PROCEDURE [dbo].[InstitucionInsertar]
	@Codigo VARCHAR(250), 
    @Nombre VARCHAR(250), 
    @Telefono VARCHAR(250), 
    @Estado BIT 
AS
BEGIN
 SET NOCOUNT ON
 BEGIN TRANSACTION
 BEGIN TRY

 INSERT INTO dbo.Institucion(
    Codigo,
    Nombre,
    Telefono,
    Estado
 )
 VALUES(
    @Codigo,
    @Nombre, 
    @Telefono, 
    @Estado
 )

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