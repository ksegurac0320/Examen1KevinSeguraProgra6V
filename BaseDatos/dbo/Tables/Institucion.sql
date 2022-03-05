﻿CREATE TABLE [dbo].[Institucion]
(
	Id_Institucion INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Institucion PRIMARY KEY CLUSTERED (Id_Institucion),
	Identificacion VARCHAR(250) NOT NULL, 
    Codigo VARCHAR(250) NOT NULL, 
    Nombre VARCHAR(250) NOT NULL, 
    Telefono VARCHAR(250) NOT NULL, 
    Estado BIT NOT NULL, 
)
WITH (DATA_COMPRESSION = PAGE)
GO