CREATE DATABASE DSP
GO
USE DSP
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cargo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_cargo] [varchar](25) NULL,
	[descripcion_cargo] [varchar](100) NULL
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_categoria] [varchar](50) NULL,
	[descripcion] [varchar](400) NULL,
	[imagen_categoria] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](150) NULL,
	[email] [varchar](100) NULL,
	[contrasena] [varchar](50) NULL,
	[telefono] [varchar](9) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 03/11/2018 1:30:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DUI] [varchar](10) NULL,
	[nombres] [varchar](150) NULL,
	[email] [varchar](100) NOT NULL,
	[telefono] [varchar](9) NULL,
	[edad] [int] NULL,
	[salario] [decimal](6, 2) NULL,
	[contrasena][varchar](50) NOT NULL,
	[fecha_nac] [date] NULL,
	[id_cargo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/**   **/
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[cantidad] [int] NULL,
	[modelo] [varchar](50) NULL,
	[costo] [decimal](6, 2) NULL,
	[descripcion] [varchar](400) NULL,
	[precio_venta] [decimal](6, 2) NULL,
	[fecha_ingreso] [datetime] NULL,
	[imagen_producto] [image] NULL,
	[id_categoria] [int] NULL,
	
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_CargoEmpresa] FOREIGN KEY([id_cargo])
REFERENCES [dbo].[Cargo] ([id])
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_ProductoCategoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categoria] ([id])
ALTER DATABASE [dsp] SET  READ_WRITE 
GO



INSERT INTO Cargo(nombre_cargo,descripcion_cargo) VALUES('Administrador','El Encargado Administrar el sitio');
GO
INSERT INTO Empleado(DUI,nombres,email,telefono,edad,salario,fecha_nac,id_cargo,contrasena) VALUES (23355682-1,'Administrador','Administrador@gmail.com','78182424','18',500.00,convert(datetime,'Jul 14 2000 11:01AM'),1,'Password1');
GO
