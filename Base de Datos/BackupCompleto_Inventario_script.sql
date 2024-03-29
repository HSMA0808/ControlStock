USE [master]
GO
/****** Object:  Database [Inventario]    Script Date: 3/31/2020 2:22:10 p. m. ******/
CREATE DATABASE [Inventario]
GO

USE [Inventario]
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Articulos]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[idarticulo] [int] IDENTITY(10000,1) NOT NULL,
	[idproveedor] [int] NULL,
	[nombre_articulo] [nvarchar](50) NULL,
	[cantidad] [int] NULL,
	[marca] [nvarchar](30) NULL,
	[descripcion] [nvarchar](100) NULL,
 CONSTRAINT [PK__Articulo__BCE2F8F7C5A8E6B6] PRIMARY KEY CLUSTERED 
(
	[idarticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[iddepartamento] [int] IDENTITY(1000,10) NOT NULL,
	[idempleado] [int] NULL,
	[nombredepto] [nvarchar](50) NULL,
 CONSTRAINT [PK__Departam__AA1019ECC530AE69] PRIMARY KEY CLUSTERED 
(
	[iddepartamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Devolucion_entrada]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Devolucion_entrada](
	[iddevolucionentrada] [int] IDENTITY(1000000,1) NOT NULL,
	[numentrada] [int] NULL,
	[idusuario] [int] NULL,
	[fecha] [datetime] NULL,
	[cant_articulos] [int] NULL,
	[descripcion] [nvarchar](100) NULL,
 CONSTRAINT [PK__Devoluci__65799F88EF8A1154] PRIMARY KEY CLUSTERED 
(
	[iddevolucionentrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Devolucion_salida]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Devolucion_salida](
	[iddevolucionsalida] [int] IDENTITY(100000,1) NOT NULL,
	[numsalida] [int] NULL,
	[idusuario] [int] NULL,
	[fecha] [datetime] NULL,
	[cant_articulos] [int] NULL,
	[descripcion] [nvarchar](100) NULL,
 CONSTRAINT [PK__Devoluci__548581E184BF17B0] PRIMARY KEY CLUSTERED 
(
	[iddevolucionsalida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[idempleado] [int] IDENTITY(100,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellido] [nvarchar](50) NULL,
	[sexo] [char](1) NULL,
	[cedula] [nvarchar](13) NULL,
	[email] [nvarchar](75) NULL,
	[direccion] [nvarchar](100) NULL,
	[telefono] [nvarchar](14) NULL,
	[cargo] [nvarchar](30) NULL,
 CONSTRAINT [PK__Empleado__EE7D5EF627B4D1D0] PRIMARY KEY CLUSTERED 
(
	[idempleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EntradaDetail]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntradaDetail](
	[Numentrada] [int] NULL,
	[idarticulo] [int] NULL,
	[cantidad] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Entradas]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entradas](
	[identrada] [int] IDENTITY(100000,1) NOT NULL,
	[idusuario] [int] NULL,
	[idproveedor] [int] NULL,
	[Conduce] [nvarchar](50) NULL,
	[fecha] [datetime] NULL,
	[cant_total] [int] NULL,
	[estado] [varchar](10) NULL,
 CONSTRAINT [PK__Entradas__7CB3F90DEA9ED23C] PRIMARY KEY CLUSTERED 
(
	[identrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[idproveedor] [int] IDENTITY(100,1) NOT NULL,
	[rnc] [nvarchar](15) NULL,
	[nombre] [nvarchar](75) NULL,
	[Direccion] [nvarchar](100) NULL,
	[Tel1] [nvarchar](14) NULL,
	[tel2] [nvarchar](14) NULL,
	[email] [nvarchar](75) NULL,
 CONSTRAINT [PK__Proveedo__2DCD485D5BA7DABA] PRIMARY KEY CLUSTERED 
(
	[idproveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SalidaDetail]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalidaDetail](
	[numsalida] [int] NULL,
	[idarticulo] [int] NULL,
	[cantidad] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Salidas]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Salidas](
	[idsalida] [int] IDENTITY(1000000,1) NOT NULL,
	[idusuario] [int] NULL,
	[iddepartamento] [int] NULL,
	[fecha] [datetime] NULL,
	[cant_total] [int] NULL,
	[estado] [varchar](10) NULL,
 CONSTRAINT [PK__Salidas__C78AFF205ED6C18B] PRIMARY KEY CLUSTERED 
(
	[idsalida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[idempleado] [int] NULL,
	[nm_user] [nvarchar](15) NULL,
	[pass_word] [nvarchar](15) NULL,
	[categoria] [nvarchar](10) NULL,
 CONSTRAINT [PK__Usuarios__080A97438B501312] PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Articulos] ON 

INSERT [dbo].[Articulos] ([idarticulo], [idproveedor], [nombre_articulo], [cantidad], [marca], [descripcion]) VALUES (10000, 100, N'Tijeras 6 pilgadas', 90, N'Cortex', N'Tijeras pequeñas para cortar papel')
INSERT [dbo].[Articulos] ([idarticulo], [idproveedor], [nombre_articulo], [cantidad], [marca], [descripcion]) VALUES (10001, 100, N'Remas de Papel', 95, N'Paper Class', N'Remas de Papel para las impresoras')
INSERT [dbo].[Articulos] ([idarticulo], [idproveedor], [nombre_articulo], [cantidad], [marca], [descripcion]) VALUES (10002, 100, N'Cartuchos de Tinta', 50, N'HP', N'Cartuchos de tinta para las impresoras')
INSERT [dbo].[Articulos] ([idarticulo], [idproveedor], [nombre_articulo], [cantidad], [marca], [descripcion]) VALUES (10003, 100, N'Grapadoras Caster', 150, N'Caster', N'Grapadoras para documentos y hojas')
SET IDENTITY_INSERT [dbo].[Articulos] OFF
SET IDENTITY_INSERT [dbo].[Departamentos] ON 

INSERT [dbo].[Departamentos] ([iddepartamento], [idempleado], [nombredepto]) VALUES (1000, 100, N'Sistemas')
INSERT [dbo].[Departamentos] ([iddepartamento], [idempleado], [nombredepto]) VALUES (1010, 103, N'Contabilidad')
SET IDENTITY_INSERT [dbo].[Departamentos] OFF
SET IDENTITY_INSERT [dbo].[Devolucion_entrada] ON 

INSERT [dbo].[Devolucion_entrada] ([iddevolucionentrada], [numentrada], [idusuario], [fecha], [cant_articulos], [descripcion]) VALUES (1000000, 100000, 1, CAST(0x0000AB8F00000000 AS DateTime), 40, N'Prueba 1')
SET IDENTITY_INSERT [dbo].[Devolucion_entrada] OFF
SET IDENTITY_INSERT [dbo].[Devolucion_salida] ON 

INSERT [dbo].[Devolucion_salida] ([iddevolucionsalida], [numsalida], [idusuario], [fecha], [cant_articulos], [descripcion]) VALUES (100000, 1000000, 1, CAST(0x0000AB8F00000000 AS DateTime), 15, N'Prueba 2')
SET IDENTITY_INSERT [dbo].[Devolucion_salida] OFF
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([idempleado], [nombre], [apellido], [sexo], [cedula], [email], [direccion], [telefono], [cargo]) VALUES (100, N'Hector Samuel', N'Medina Acosta', N'M', N'40200689137', N'hsma0808@gmail.com', N'Santo Domingo', N'8096547654', N'Supervisor')
INSERT [dbo].[Empleados] ([idempleado], [nombre], [apellido], [sexo], [cedula], [email], [direccion], [telefono], [cargo]) VALUES (101, N'Manuel', N'Jimenez', N'M', N'40987567432', N'manueljj@gmail.cim', N'Prados de San Luis, Santo Domingo Este', N'8093456789', N'Tecnico')
INSERT [dbo].[Empleados] ([idempleado], [nombre], [apellido], [sexo], [cedula], [email], [direccion], [telefono], [cargo]) VALUES (102, N'Pedro', N'Rodriguez', N'M', N'40987567432', N'PedroR@gmail.com', N'San Isidro, Santo Domingo Este', N'8093456765', N'Tecnico')
INSERT [dbo].[Empleados] ([idempleado], [nombre], [apellido], [sexo], [cedula], [email], [direccion], [telefono], [cargo]) VALUES (103, N'Maria', N'Gutierrez', N'F', N'00166543565', N'MariaG@gmail.com', N'San Carlos, Santo Domingo', N'8096544432', N'Contadora')
INSERT [dbo].[Empleados] ([idempleado], [nombre], [apellido], [sexo], [cedula], [email], [direccion], [telefono], [cargo]) VALUES (104, N'Saul', N'Zorrilla', N'M', N'40298789765', N'S_zorrilla@gmail.com', N'Resp. Villa Carmen, Santo Domingo Este', N'809777666', N'Operario')
INSERT [dbo].[Empleados] ([idempleado], [nombre], [apellido], [sexo], [cedula], [email], [direccion], [telefono], [cargo]) VALUES (105, N'Eliana', N'Medina Acosta', N'F', N'40246543348', N'EAMA@gmail.com', N'Arroyo Hondo, Distrito Nacional', N'8492267854', N'Directora')
SET IDENTITY_INSERT [dbo].[Empleados] OFF
INSERT [dbo].[EntradaDetail] ([Numentrada], [idarticulo], [cantidad]) VALUES (100000, 10002, 40)
INSERT [dbo].[EntradaDetail] ([Numentrada], [idarticulo], [cantidad]) VALUES (100001, 10002, 50)
INSERT [dbo].[EntradaDetail] ([Numentrada], [idarticulo], [cantidad]) VALUES (100001, 10001, 5)
SET IDENTITY_INSERT [dbo].[Entradas] ON 

INSERT [dbo].[Entradas] ([identrada], [idusuario], [idproveedor], [Conduce], [fecha], [cant_total], [estado]) VALUES (100000, 1, 100, N'1243536156', CAST(0x0000AB8F00000000 AS DateTime), 40, N'Devuelto')
INSERT [dbo].[Entradas] ([identrada], [idusuario], [idproveedor], [Conduce], [fecha], [cant_total], [estado]) VALUES (100001, 1, 100, N'2312324453', CAST(0x0000AB8F00000000 AS DateTime), 55, N'Normal')
SET IDENTITY_INSERT [dbo].[Entradas] OFF
SET IDENTITY_INSERT [dbo].[Proveedores] ON 

INSERT [dbo].[Proveedores] ([idproveedor], [rnc], [nombre], [Direccion], [Tel1], [tel2], [email]) VALUES (100, N'00123465678', N'HM Cosmetics', N'Santo Domingo Este, Santo Domingo', N'8095554444', N'8293334444', N'HMCOSMETICS@gmail.com')
INSERT [dbo].[Proveedores] ([idproveedor], [rnc], [nombre], [Direccion], [Tel1], [tel2], [email]) VALUES (101, N'00134576431', N'Distribuidora Lebron', N'Villa Faro, Santo Domingo Este', N'8095664332', N'8297658099', N'Disleca@gmail.com')
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
INSERT [dbo].[SalidaDetail] ([numsalida], [idarticulo], [cantidad]) VALUES (1000000, 10001, 10)
INSERT [dbo].[SalidaDetail] ([numsalida], [idarticulo], [cantidad]) VALUES (1000000, 10002, 5)
INSERT [dbo].[SalidaDetail] ([numsalida], [idarticulo], [cantidad]) VALUES (1000001, 10000, 10)
INSERT [dbo].[SalidaDetail] ([numsalida], [idarticulo], [cantidad]) VALUES (1000001, 10001, 10)
INSERT [dbo].[SalidaDetail] ([numsalida], [idarticulo], [cantidad]) VALUES (1000001, 10002, 12)
SET IDENTITY_INSERT [dbo].[Salidas] ON 

INSERT [dbo].[Salidas] ([idsalida], [idusuario], [iddepartamento], [fecha], [cant_total], [estado]) VALUES (1000000, 1, 1000, CAST(0x0000AB8F00000000 AS DateTime), 15, N'Devuelto')
INSERT [dbo].[Salidas] ([idsalida], [idusuario], [iddepartamento], [fecha], [cant_total], [estado]) VALUES (1000001, 1, 1010, CAST(0x0000AB8F00000000 AS DateTime), 32, N'Normal')
SET IDENTITY_INSERT [dbo].[Salidas] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([idusuario], [idempleado], [nm_user], [pass_word], [categoria]) VALUES (1, 100, N'HSMA', N'0000', N'4')
INSERT [dbo].[Usuarios] ([idusuario], [idempleado], [nm_user], [pass_word], [categoria]) VALUES (2, 101, N'MJimenez', N'0000', N'2')
INSERT [dbo].[Usuarios] ([idusuario], [idempleado], [nm_user], [pass_word], [categoria]) VALUES (3, 102, N'PRodriguez', N'0000', N'2')
INSERT [dbo].[Usuarios] ([idusuario], [idempleado], [nm_user], [pass_word], [categoria]) VALUES (4, 103, N'MGutierrez', N'0000', N'3')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
ALTER TABLE [dbo].[Articulos]  WITH CHECK ADD  CONSTRAINT [fk_idproveedor_articulos] FOREIGN KEY([idproveedor])
REFERENCES [dbo].[Proveedores] ([idproveedor])
GO
ALTER TABLE [dbo].[Articulos] CHECK CONSTRAINT [fk_idproveedor_articulos]
GO
ALTER TABLE [dbo].[Departamentos]  WITH CHECK ADD  CONSTRAINT [fk_idempleado_departamentos] FOREIGN KEY([idempleado])
REFERENCES [dbo].[Empleados] ([idempleado])
GO
ALTER TABLE [dbo].[Departamentos] CHECK CONSTRAINT [fk_idempleado_departamentos]
GO
ALTER TABLE [dbo].[Devolucion_entrada]  WITH CHECK ADD  CONSTRAINT [fk_idusuario_devolucionentrada] FOREIGN KEY([idusuario])
REFERENCES [dbo].[Usuarios] ([idusuario])
GO
ALTER TABLE [dbo].[Devolucion_entrada] CHECK CONSTRAINT [fk_idusuario_devolucionentrada]
GO
ALTER TABLE [dbo].[Devolucion_entrada]  WITH CHECK ADD  CONSTRAINT [fk_numentrada_devolucionentrada] FOREIGN KEY([numentrada])
REFERENCES [dbo].[Entradas] ([identrada])
GO
ALTER TABLE [dbo].[Devolucion_entrada] CHECK CONSTRAINT [fk_numentrada_devolucionentrada]
GO
ALTER TABLE [dbo].[Devolucion_salida]  WITH CHECK ADD  CONSTRAINT [fk_idusuario_devolucionsalida] FOREIGN KEY([idusuario])
REFERENCES [dbo].[Usuarios] ([idusuario])
GO
ALTER TABLE [dbo].[Devolucion_salida] CHECK CONSTRAINT [fk_idusuario_devolucionsalida]
GO
ALTER TABLE [dbo].[Devolucion_salida]  WITH CHECK ADD  CONSTRAINT [fk_numsalida_devolucionsalida] FOREIGN KEY([numsalida])
REFERENCES [dbo].[Salidas] ([idsalida])
GO
ALTER TABLE [dbo].[Devolucion_salida] CHECK CONSTRAINT [fk_numsalida_devolucionsalida]
GO
ALTER TABLE [dbo].[EntradaDetail]  WITH CHECK ADD  CONSTRAINT [fk_idarticulo_entradadetail] FOREIGN KEY([idarticulo])
REFERENCES [dbo].[Articulos] ([idarticulo])
GO
ALTER TABLE [dbo].[EntradaDetail] CHECK CONSTRAINT [fk_idarticulo_entradadetail]
GO
ALTER TABLE [dbo].[EntradaDetail]  WITH CHECK ADD  CONSTRAINT [fk_numentrada_entradadetail] FOREIGN KEY([Numentrada])
REFERENCES [dbo].[Entradas] ([identrada])
GO
ALTER TABLE [dbo].[EntradaDetail] CHECK CONSTRAINT [fk_numentrada_entradadetail]
GO
ALTER TABLE [dbo].[Entradas]  WITH CHECK ADD  CONSTRAINT [fk_idproveedor_entradas] FOREIGN KEY([idproveedor])
REFERENCES [dbo].[Proveedores] ([idproveedor])
GO
ALTER TABLE [dbo].[Entradas] CHECK CONSTRAINT [fk_idproveedor_entradas]
GO
ALTER TABLE [dbo].[Entradas]  WITH CHECK ADD  CONSTRAINT [fk_idusuario_entradas] FOREIGN KEY([idusuario])
REFERENCES [dbo].[Usuarios] ([idusuario])
GO
ALTER TABLE [dbo].[Entradas] CHECK CONSTRAINT [fk_idusuario_entradas]
GO
ALTER TABLE [dbo].[SalidaDetail]  WITH CHECK ADD  CONSTRAINT [fk_idarticulo_salidadetail] FOREIGN KEY([idarticulo])
REFERENCES [dbo].[Articulos] ([idarticulo])
GO
ALTER TABLE [dbo].[SalidaDetail] CHECK CONSTRAINT [fk_idarticulo_salidadetail]
GO
ALTER TABLE [dbo].[SalidaDetail]  WITH CHECK ADD  CONSTRAINT [fk_numsalida_salidadetail] FOREIGN KEY([numsalida])
REFERENCES [dbo].[Salidas] ([idsalida])
GO
ALTER TABLE [dbo].[SalidaDetail] CHECK CONSTRAINT [fk_numsalida_salidadetail]
GO
ALTER TABLE [dbo].[Salidas]  WITH CHECK ADD  CONSTRAINT [fk_iddepartamento_salidas] FOREIGN KEY([iddepartamento])
REFERENCES [dbo].[Departamentos] ([iddepartamento])
GO
ALTER TABLE [dbo].[Salidas] CHECK CONSTRAINT [fk_iddepartamento_salidas]
GO
ALTER TABLE [dbo].[Salidas]  WITH CHECK ADD  CONSTRAINT [fk_idusuario_salidas] FOREIGN KEY([idusuario])
REFERENCES [dbo].[Usuarios] ([idusuario])
GO
ALTER TABLE [dbo].[Salidas] CHECK CONSTRAINT [fk_idusuario_salidas]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [fk_idempleado_usuarios] FOREIGN KEY([idempleado])
REFERENCES [dbo].[Empleados] ([idempleado])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [fk_idempleado_usuarios]
GO
/****** Object:  Trigger [dbo].[DevolucionarEntrada]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Mostrar_Articulos]
as
begin
select articulos.idarticulo as 'ID Articulo', proveedores.nombre as 'Proveedor', articulos.nombre_articulo, 
articulos.cantidad as 'Cantidad', articulos.marca as 'Marca', articulos.Descripcion as 'Descripcion'
from articulos join proveedores on proveedores.idproveedor = articulos.idproveedor
end

GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Departamento]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Mostrar_Departamento]
as
begin
select departamentos.iddepartamento as 'ID Departamento', empleados.nombre + ' ' + empleados.Apellido as 'Empleado', 
Departamentos.nombredepto as 'Departamento' from departamentos join Empleados on departamentos.idempleado = empleados.idempleado
end

GO
/****** Object:  StoredProcedure [dbo].[Mostrar_DevolucionEntrada]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Mostrar_DevolucionEntrada]
as
begin
select dev.iddevolucionentrada as 'ID Devolucion', dev.numentrada as 'ID Entrada', usuarios.nm_user as 'Usuario', dev.fecha as 'Fecha', 
dev.cant_articulos as 'Cantidad', dev.descripcion as 'Descripcion' from Devolucion_entrada dev join usuarios on Usuarios.idusuario = dev.idusuario;
end

GO
/****** Object:  StoredProcedure [dbo].[Mostrar_DevolucionSalida]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Mostrar_DevolucionSalida]
as
begin
select dev.iddevolucionsalida as 'ID Devolucion', dev.numsalida as 'ID Salida', usuarios.nm_user as 'Usuario', dev.fecha as 'Fecha', 
dev.cant_articulos as 'Cantidad', dev.descripcion as 'Descripcion' from Devolucion_salida dev join usuarios on Usuarios.idusuario = dev.idusuario;
end
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Entradas]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Mostrar_Entradas]
as
begin
select entradas.identrada as 'ID Entrada', usuarios.nm_user as 'Usuario', proveedores.nombre as 'Proveedor', 
entradas.conduce as 'Conduce', entradas.fecha as 'Fecha', entradas.cant_total as 'Cantidad' from entradas join usuarios
on usuarios.idusuario = entradas.idusuario join proveedores on entradas.idproveedor = proveedores.idproveedor
where entradas.estado = 'Normal';
end 

GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Salidas]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Mostrar_Salidas]
as
begin
select salidas.idsalida as 'ID Salida', usuarios.nm_user as 'Usuario', departamentos.nombredepto as 'Departamento',
empleados.nombre + ' ' + empleados.apellido as 'Supervisor', salidas.fecha as 'Fecha', salidas.cant_total as 'Cantidad' 
from salidas  join usuarios on salidas.idusuario = usuarios.idusuario join departamentos on salidas.iddepartamento = departamentos.iddepartamento 
join Empleados on Departamentos.idempleado = Empleados.idempleado where salidas.estado = 'Normal'
end

GO

create trigger [dbo].[DevolucionarEntrada] on [dbo].[Devolucion_entrada]
after insert
as
begin
declare @id int;
set @id = (select numentrada from inserted)
update Entradas set estado = 'Devuelto' where identrada = @id
end

GO
/****** Object:  Trigger [dbo].[DevolucionarSalida]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[DevolucionarSalida] on [dbo].[Devolucion_salida]
after insert
as
begin
declare @id int;
set @id = (select numsalida from inserted)
update salidas set estado = 'Devuelto' where idsalida = @id
end

GO
/****** Object:  Trigger [dbo].[Entrada_AumentarArticulo]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[Entrada_AumentarArticulo] on [dbo].[EntradaDetail]
after insert
as
begin
declare @idarticulo int;
declare @cantidad int;
set @cantidad = (select cantidad from inserted);
set @idarticulo = (select idarticulo from inserted);
update articulos set cantidad = cantidad + @cantidad where idarticulo = @idarticulo;
end

GO
/****** Object:  Trigger [dbo].[Entrada_EstadoNormal]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[Entrada_EstadoNormal] on [dbo].[Entradas]
after insert
as
begin
Declare @id int;
set @id = (select identrada from inserted)
update entradas set estado = 'Normal' where identrada = @id
end

GO
/****** Object:  Trigger [dbo].[Salida_DescontarArticulo]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[Salida_DescontarArticulo] on [dbo].[SalidaDetail]
after insert
as
begin
declare @idarticulo int;
declare @cantidad int;
set @cantidad = (select cantidad from inserted);
set @idarticulo = (select idarticulo from inserted);
update articulos set cantidad = cantidad - @cantidad where idarticulo = @idarticulo;
end

GO
/****** Object:  Trigger [dbo].[Salid_EstadoNormal]    Script Date: 3/31/2020 2:22:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[Salid_EstadoNormal] on [dbo].[Salidas]
after insert
as
begin
Declare @id int;
set @id = (select idsalida from inserted)
update salidas set estado = 'Normal' where idsalida = @id
end

GO
USE [master]
GO
ALTER DATABASE [Inventario] SET  READ_WRITE 
GO
