CREATE TABLE [dbo].[articulo]
(
	[Id] INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	[seccion] NVARCHAR (MAX) NULL,
	[nombreArticulo] NVARCHAR (50) NULL,
	[precio] MONEY NULL,
	[fecha] DATETIME NULL,
	[paisOrigen] NVARCHAR(50) NULL,
	PRIMARY KEY CLUSTERED([Id] ASC)
	);
