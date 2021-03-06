USE [cine]
GO
SET IDENTITY_INSERT [dbo].[cajeros] ON 

INSERT [dbo].[cajeros] ([id_cajero], [nombre], [apellido], [fec_nac], [id_tipo_doc], [num_doc], [id_barrio], [direccion], [sueldo], [fecha_ingreso], [id_sucursal]) VALUES (1, N'Martin', N'Pedraza', CAST(N'1990-05-11T00:00:00.000' AS DateTime), 1, N'33458796', 1, N'Cayol 2213', 653214.0000, CAST(N'2015-07-30T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[cajeros] ([id_cajero], [nombre], [apellido], [fec_nac], [id_tipo_doc], [num_doc], [id_barrio], [direccion], [sueldo], [fecha_ingreso], [id_sucursal]) VALUES (2, N'Pedro', N'Lopez', CAST(N'1987-10-15T00:00:00.000' AS DateTime), 1, N'30521369', 1, N'Ismael Mota 158', 601238.0000, CAST(N'2015-01-15T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[cajeros] ([id_cajero], [nombre], [apellido], [fec_nac], [id_tipo_doc], [num_doc], [id_barrio], [direccion], [sueldo], [fecha_ingreso], [id_sucursal]) VALUES (3, N'Mariana ', N'Presti', CAST(N'1993-05-30T00:00:00.000' AS DateTime), 1, N'37454123', 2, N'Liniers 693', 594526.0000, CAST(N'2016-05-30T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[cajeros] ([id_cajero], [nombre], [apellido], [fec_nac], [id_tipo_doc], [num_doc], [id_barrio], [direccion], [sueldo], [fecha_ingreso], [id_sucursal]) VALUES (4, N'Cinthia ', N'Solsedo', CAST(N'1996-11-14T00:00:00.000' AS DateTime), 1, N'40125489', 6, N'Rosedales 4578', 553212.0000, CAST(N'2018-03-08T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[cajeros] ([id_cajero], [nombre], [apellido], [fec_nac], [id_tipo_doc], [num_doc], [id_barrio], [direccion], [sueldo], [fecha_ingreso], [id_sucursal]) VALUES (5, N'Santiago', N'Espinosa', CAST(N'1985-07-15T00:00:00.000' AS DateTime), 1, N'31245953', 4, N'Hipolito Irigoyen 4585', 602126.0000, CAST(N'2016-04-25T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[cajeros] ([id_cajero], [nombre], [apellido], [fec_nac], [id_tipo_doc], [num_doc], [id_barrio], [direccion], [sueldo], [fecha_ingreso], [id_sucursal]) VALUES (6, N'Ernesto', N'Dopulos', CAST(N'1987-04-29T00:00:00.000' AS DateTime), 1, N'33564894', 2, N'Lopez y Planes 1155', 60457.0000, CAST(N'2015-06-17T00:00:00.000' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[cajeros] OFF
GO

set dateformat dmy
INSERT into cajeros (nombre,apellido,fec_nac, id_tipo_doc, num_doc, id_barrio, direccion, sueldo, fecha_ingreso, id_sucursal) 
VALUES ('Julieta', 'Romero','25/06/1993', 1,30988100, 3, 'Sarmiento 639', 871454.0000, '30/06/2018', 3)
INSERT into cajeros (nombre,apellido,fec_nac, id_tipo_doc, num_doc, id_barrio, direccion, sueldo, fecha_ingreso, id_sucursal) 
VALUES ('Jazmin', 'Salgado','3/10/1998', 1,39868100, 7, 'Jacinto Rios 65', 748976.0000, '10/07/2016', 3)
INSERT into cajeros (nombre,apellido,fec_nac, id_tipo_doc, num_doc, id_barrio, direccion, sueldo, fecha_ingreso, id_sucursal) 
VALUES ('Federico', 'Fargo','8/11/1987', 1,36568094, 5, 'Peru 521', 488976.0000, '25/03/2020', 3)