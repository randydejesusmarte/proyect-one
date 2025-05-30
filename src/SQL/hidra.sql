USE [tecnica3]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nom_cli] [varchar](50) NULL,
	[Tel_cli] [varchar](14) NULL,
	[Dir_cli] [varchar](100) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entrada]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrada](
	[Num] [int] NOT NULL,
	[Cliente] [varchar](max) NULL,
	[Atendido] [varchar](max) NOT NULL,
	[Trabajado] [varchar](max) NULL,
	[Condicion] [varchar](max) NULL,
	[Fecha] [varchar](max) NULL,
	[Servicio] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[Idfactura] [int] NOT NULL,
	[Id_cliente] [int] NULL,
	[Nombre_producto] [varchar](max) NULL,
	[Precio] [int] NULL,
	[Cantidad] [int] NULL,
	[Monto] [int] NULL,
	[precio_total] [int] NULL,
	[Empleado] [int] NULL,
	[Fecha_del_Registro] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [nvarchar](50) NOT NULL,
	[uname] [nvarchar](50) NULL,
	[pass] [nvarchar](16) NULL,
	[business] [nvarchar](max) NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[nom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Id] [int] NOT NULL,
	[Nombre_producto] [nvarchar](50) NOT NULL,
	[Cantidad] [nvarchar](50) NOT NULL,
	[Precio] [int] NULL,
	[Descuento] [bit] NULL,
	[per_descuento] [int] NULL,
	[Ultima modificacion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Nombre_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Cliente] FOREIGN KEY([Id_cliente])
REFERENCES [dbo].[Cliente] ([Id_cliente])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Cliente]
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_cliente]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_actualizar_cliente]
	-- Add the parameters for the stored procedure here
	@Nombre varchar(50),
    @Telefono VARCHAR(14),
    @Direccion VARCHAR(100),
    @id int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Cliente set Nom_cli= @Nombre,Tel_cli= @Telefono,Dir_cli= @Direccion WHERE Id_cliente=@id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_auto_increment_FacId]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_auto_increment_FacId]
AS
BEGIN
    SELECT COUNT(distinct Idfactura) + 1 FROM [Factura]
END
GO
/****** Object:  StoredProcedure [dbo].[sp_auto_increment_Id]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_auto_increment_Id]
AS
BEGIN
    SELECT COUNT(distinct Num) + 1 FROM [Entrada]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CantEntradas]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_CantEntradas]
	-- Add the parameters for the stored procedure here
	@Num int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT into cantEntrada (Num) VALUES (@Num)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Entradas]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Entradas]
	-- Add the parameters for the stored procedure here
	@Num nvarchar(MAX) ,
	@Cliente varchar(50),
    @Atendido nvarchar(MAX),
    @Trabajado nvarchar(MAX),
    @Condicion nvarchar(MAX),
    @Fecha nvarchar(MAX),
    @Servicio nvarchar(MAX)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT into Entrada
    (
        Num,
	    Cliente,
        Atendido,
        Trabajado,
        Condicion,
        Fecha,
        Servicio
    ) VALUES
    (
        @Num,
	    @Cliente,
        @Atendido,
        @Trabajado,
        @Condicion,
        @Fecha,
        @Servicio
    )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Fill_Data_Factura]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_Fill_Data_Factura]
	-- Add the parameters for the stored procedure here
	@Idfactura int 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT 
    Idfactura as 'ID', 
    Nombre_producto as 'Productos', 
    Precio, 
    Cantidad, 
    Monto, 
    Fecha_del_Registro as 'Fecha de Registro' 
    FROM [dbo].[Factura]
    WHERE Idfactura=@Idfactura
    
END
GO
/****** Object:  StoredProcedure [dbo].[sp_get_id]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_get_id]
	-- Add the parameters for the stored procedure here
	@Nombre varchar(50),
    @Clave VARCHAR(16)

AS
BEGIN
    SELECT id,business FROM [login] 
    WHERE login.uname = @Nombre AND login.pass = @Clave
END
GO
/****** Object:  StoredProcedure [dbo].[sp_id_cliente]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[sp_id_cliente]
	-- Add the parameters for the stored procedure here
	@Nombre_cliente varchar(max)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	-- Select rows from a Table or View '[Factura]' in schema '[dbo]'
    SELECT * FROM [dbo].[Cliente]
    WHERE Nom_cli = @Nombre_cliente
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_cliente]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_insertar_cliente]
	-- Add the parameters for the stored procedure here
	@Nombre varchar(50),
    @Telefono VARCHAR(14),
    @Direccion VARCHAR(100)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT into Cliente (Nom_cli,Tel_cli,Dir_cli) VALUES (@Nombre,@Telefono,@Direccion)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_Factura]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_insertar_Factura]
	-- Add the parameters for the stored procedure here
	@Idfactura int ,
	@Id_Cliente varchar(50),
	@Nombre_producto varchar(max),
	@Precio smallmoney,
	@Cantidad int,
	@Monto smallmoney,
	@Precio_total smallmoney,
    @Empleado int,
	@Fecha_del_Registro varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT into Factura 
    (Idfactura,Id_cliente,Nombre_producto,Precio,Cantidad,Monto,precio_total,Empleado,Fecha_del_Registro) VALUES 
    (@Idfactura,@Id_Cliente,@Nombre_producto,@Precio,@Cantidad,@Monto,@Precio_total,@Empleado,@Fecha_del_Registro)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_Login]
	-- Add the parameters for the stored procedure here
	@Nombre varchar(50),
    @Clave VARCHAR(16)

AS
BEGIN
	SELECT COUNT(*) FROM [login] 
    WHERE login.uname = @Nombre AND login.pass= @Clave
END
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_cliente]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_mostrar_cliente]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Cliente
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Precio_producto_Factura]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[sp_Precio_producto_Factura]
	-- Add the parameters for the stored procedure here
	@Nombre_producto varchar(max)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	-- Select rows from a Table or View '[Factura]' in schema '[dbo]'
    SELECT * FROM [dbo].[Producto]
    WHERE Nombre_producto = @Nombre_producto
END
GO
/****** Object:  StoredProcedure [dbo].[sp_selectfor]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_selectfor]
	-- Add the parameters for the stored procedure here
	@Param1 varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Cliente where Nom_cli like '%'+@Param1+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_subtotal]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_subtotal]
	-- Add the parameters for the stored procedure here
	@idfact INT
AS
BEGIN
    -- Insert statements for procedure here
	SELECT SUM(Monto) as "subtotal" from Factura WHERE idfactura = @idfact
END
GO
/****** Object:  StoredProcedure [dbo].[sp_textrefresh]    Script Date: 28/11/2021 10:46:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_textrefresh]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	select Nom_cli from Cliente
END
GO
