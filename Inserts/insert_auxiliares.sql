USE [cine]
GO
SET IDENTITY_INSERT [dbo].[localidades] ON 

INSERT [dbo].[localidades] ([id_localidad], [localidad]) VALUES (1, N'Córdoba')
INSERT [dbo].[localidades] ([id_localidad], [localidad]) VALUES (2, N'Carlos Paz')
INSERT [dbo].[localidades] ([id_localidad], [localidad]) VALUES (3, N'Villa Allende ')
INSERT [dbo].[localidades] ([id_localidad], [localidad]) VALUES (4, N'Rio Ceballos')
INSERT [dbo].[localidades] ([id_localidad], [localidad]) VALUES (5, N'Rio Primero')
INSERT [dbo].[localidades] ([id_localidad], [localidad]) VALUES (6, N'Alta Gracia')
SET IDENTITY_INSERT [dbo].[localidades] OFF
GO
SET IDENTITY_INSERT [dbo].[barrios] ON 

INSERT [dbo].[barrios] ([id_barrio], [nombre], [id_localidad]) VALUES (1, N'Poeta Lugones', 1)
INSERT [dbo].[barrios] ([id_barrio], [nombre], [id_localidad]) VALUES (2, N'Marques De Sobremonte', 1)
INSERT [dbo].[barrios] ([id_barrio], [nombre], [id_localidad]) VALUES (3, N'Alberdi', 1)
INSERT [dbo].[barrios] ([id_barrio], [nombre], [id_localidad]) VALUES (4, N'Alto Alberdi', 1)
INSERT [dbo].[barrios] ([id_barrio], [nombre], [id_localidad]) VALUES (5, N'Centro', 1)
INSERT [dbo].[barrios] ([id_barrio], [nombre], [id_localidad]) VALUES (6, N'Jardin Espinosa', 1)
INSERT [dbo].[barrios] ([id_barrio], [nombre], [id_localidad]) VALUES (7, N'San Martin', 1)
INSERT [dbo].[barrios] ([id_barrio], [nombre], [id_localidad]) VALUES (8, N'Centro', 2)
INSERT [dbo].[barrios] ([id_barrio], [nombre], [id_localidad]) VALUES (9, N'Las Malvinas', 2)
INSERT [dbo].[barrios] ([id_barrio], [nombre], [id_localidad]) VALUES (10, N'Eucalipto', 2)
INSERT [dbo].[barrios] ([id_barrio], [nombre], [id_localidad]) VALUES (11, N'Villa Suiza', 2)
INSERT [dbo].[barrios] ([id_barrio], [nombre], [id_localidad]) VALUES (12, N'Barrio Camara', 6)
INSERT [dbo].[barrios] ([id_barrio], [nombre], [id_localidad]) VALUES (13, N'Barrio Sur', 6)
INSERT [dbo].[barrios] ([id_barrio], [nombre], [id_localidad]) VALUES (14, N'Santa Maria', 6)
INSERT [dbo].[barrios] ([id_barrio], [nombre], [id_localidad]) VALUES (15, N'Agua del Peñon', 4)
INSERT [dbo].[barrios] ([id_barrio], [nombre], [id_localidad]) VALUES (16, N'Cantegril', 4)
INSERT [dbo].[barrios] ([id_barrio], [nombre], [id_localidad]) VALUES (17, N'Amuschastegui', 4)
SET IDENTITY_INSERT [dbo].[barrios] OFF
GO
SET IDENTITY_INSERT [dbo].[generos] ON 

INSERT [dbo].[generos] ([id_genero], [genero]) VALUES (1, N'Ciencia Ficcion')
INSERT [dbo].[generos] ([id_genero], [genero]) VALUES (2, N'Drama')
INSERT [dbo].[generos] ([id_genero], [genero]) VALUES (3, N'Accion')
INSERT [dbo].[generos] ([id_genero], [genero]) VALUES (4, N'Comedia')
INSERT [dbo].[generos] ([id_genero], [genero]) VALUES (5, N'Terror')
INSERT [dbo].[generos] ([id_genero], [genero]) VALUES (6, N'Suspenso ')
INSERT [dbo].[generos] ([id_genero], [genero]) VALUES (7, N'Comedia Romantica')
INSERT [dbo].[generos] ([id_genero], [genero]) VALUES (8, N'Documental')
INSERT [dbo].[generos] ([id_genero], [genero]) VALUES (9, N'Infantil')
SET IDENTITY_INSERT [dbo].[generos] OFF
GO
SET IDENTITY_INSERT [dbo].[peliculas] ON 

INSERT [dbo].[peliculas] ([id_pelicula], [nombre], [id_genero], [fecha_estreno], [duracion]) VALUES (1, N'Venom: Carnage liberado', 1, CAST(N'2021-09-14T00:00:00.000' AS DateTime), 97)
INSERT [dbo].[peliculas] ([id_pelicula], [nombre], [id_genero], [fecha_estreno], [duracion]) VALUES (2, N'Hallowen Kills', 5, CAST(N'2021-10-10T00:00:00.000' AS DateTime), 105)
INSERT [dbo].[peliculas] ([id_pelicula], [nombre], [id_genero], [fecha_estreno], [duracion]) VALUES (3, N'Los Locos Adams 2', 4, CAST(N'2021-10-06T00:00:00.000' AS DateTime), 94)
INSERT [dbo].[peliculas] ([id_pelicula], [nombre], [id_genero], [fecha_estreno], [duracion]) VALUES (4, N'Duna', 1, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 155)
INSERT [dbo].[peliculas] ([id_pelicula], [nombre], [id_genero], [fecha_estreno], [duracion]) VALUES (5, N'The Last Duel', 2, CAST(N'2021-10-03T00:00:00.000' AS DateTime), 153)
INSERT [dbo].[peliculas] ([id_pelicula], [nombre], [id_genero], [fecha_estreno], [duracion]) VALUES (6, N'007: Sin tiempo para morir', 3, CAST(N'2021-10-08T00:00:00.000' AS DateTime), 163)
INSERT [dbo].[peliculas] ([id_pelicula], [nombre], [id_genero], [fecha_estreno], [duracion]) VALUES (7, N'Paw Patrol: la pelicula', 9, CAST(N'2021-10-11T00:00:00.000' AS DateTime), 88)
INSERT [dbo].[peliculas] ([id_pelicula], [nombre], [id_genero], [fecha_estreno], [duracion]) VALUES (8, N'Shang-Chi y la leyenda los Diez Anillos', 1, CAST(N'2021-09-29T00:00:00.000' AS DateTime), 132)
INSERT [dbo].[peliculas] ([id_pelicula], [nombre], [id_genero], [fecha_estreno], [duracion]) VALUES (9, N'Chernobil: la pelicula', 2, CAST(N'2021-09-30T00:00:00.000' AS DateTime), 136)

SET IDENTITY_INSERT [dbo].[peliculas] OFF
GO

set dateformat dmy
insert into peliculas values ('Minions 5',4,'15/09/2020',163)
insert into peliculas values ('Buscando al papá de Nemo',9,'19/05/2021',123)
go

SET IDENTITY_INSERT [dbo].[bancos] ON 

INSERT [dbo].[bancos] ([id_banco], [nom_banco]) VALUES (1, N'Macro Visa')
INSERT [dbo].[bancos] ([id_banco], [nom_banco]) VALUES (2, N'Macro Mastercar')
INSERT [dbo].[bancos] ([id_banco], [nom_banco]) VALUES (3, N'Bancor Visa')
INSERT [dbo].[bancos] ([id_banco], [nom_banco]) VALUES (4, N' Galicia Visa ')
INSERT [dbo].[bancos] ([id_banco], [nom_banco]) VALUES (5, N'Galicia Mastercard')
INSERT [dbo].[bancos] ([id_banco], [nom_banco]) VALUES (6, N'Santander Visa')
INSERT [dbo].[bancos] ([id_banco], [nom_banco]) VALUES (7, N'Santander Mastercard')
SET IDENTITY_INSERT [dbo].[bancos] OFF
GO
SET IDENTITY_INSERT [dbo].[metodos_pago] ON 

INSERT [dbo].[metodos_pago] ([id_metodo], [nombre]) VALUES (1, N'Efectivo')
INSERT [dbo].[metodos_pago] ([id_metodo], [nombre]) VALUES (2, N'Debito')
INSERT [dbo].[metodos_pago] ([id_metodo], [nombre]) VALUES (3, N'Transferencia')
INSERT [dbo].[metodos_pago] ([id_metodo], [nombre]) VALUES (4, N'Credito')
SET IDENTITY_INSERT [dbo].[metodos_pago] OFF
GO
SET IDENTITY_INSERT [dbo].[sucursales] ON 

INSERT [dbo].[sucursales] ([id_sucursal], [nombre]) VALUES (1, N'Villa Cabrera')
INSERT [dbo].[sucursales] ([id_sucursal], [nombre]) VALUES (2, N'Nuevo Centro')
INSERT [dbo].[sucursales] ([id_sucursal], [nombre]) VALUES (3, N'Patio Olmos')
SET IDENTITY_INSERT [dbo].[sucursales] OFF
GO
SET IDENTITY_INSERT [dbo].[tipos_compra] ON 

INSERT [dbo].[tipos_compra] ([id_tipo_compra], [tipo]) VALUES (1, N'Ventanilla')
INSERT [dbo].[tipos_compra] ([id_tipo_compra], [tipo]) VALUES (2, N'Internet')
INSERT [dbo].[tipos_compra] ([id_tipo_compra], [tipo]) VALUES (3, N'Abm')
SET IDENTITY_INSERT [dbo].[tipos_compra] OFF
GO
SET IDENTITY_INSERT [dbo].[tipos_documento] ON 

INSERT [dbo].[tipos_documento] ([id_tipo_doc], [tipo_doc]) VALUES (1, N'Dni')
INSERT [dbo].[tipos_documento] ([id_tipo_doc], [tipo_doc]) VALUES (2, N'Pasaporte')
INSERT [dbo].[tipos_documento] ([id_tipo_doc], [tipo_doc]) VALUES (3, N'Libreta Civica')
INSERT [dbo].[tipos_documento] ([id_tipo_doc], [tipo_doc]) VALUES (4, N'Libreta de Enrrolamiento')
SET IDENTITY_INSERT [dbo].[tipos_documento] OFF
GO
SET IDENTITY_INSERT [dbo].[tipos_sala] ON 

INSERT [dbo].[tipos_sala] ([id_tipo_sala], [nombre], [precio]) VALUES (1, N'Sala 2D', 530.0000)
INSERT [dbo].[tipos_sala] ([id_tipo_sala], [nombre], [precio]) VALUES (2, N'Sala 3D', 780.0000)
SET IDENTITY_INSERT [dbo].[tipos_sala] OFF
GO
