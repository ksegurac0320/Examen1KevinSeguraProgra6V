-- =============================================
-- Author:        <Kevin Segura>
-- Create date: <05/03/2022>
-- Description:    <Procedimiento que actualiza las instituciones>
-- =============================================
CREATE PROCEDURE [dbo].[InstitucionActualizar]
	@Id_Institucion INT,
    @Codigo VARCHAR(250), 
    @Nombre VARCHAR(250), 
    @Telefono VARCHAR(250), 
    @Estado BIT
AS
BEGIN
 SET NOCOUNT ON
 BEGIN TRANSACTION
 BEGIN TRY

 UPDATE dbo.Institucion SET
    Codigo= @Codigo,
    Nombre=@Nombre,
    Telefono=@Telefono,
    Estado=@Estado

    WHERE Id_Institucion=@Id_Institucion

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