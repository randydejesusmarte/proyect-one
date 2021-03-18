----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------

USE master
GO
IF EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'Uapa'
)
DROP DATABASE Uapa
GO

USE master
GO
IF NOT EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'Uapa'
)
CREATE DATABASE Uapa
GO

USE Uapa
GO

----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Usuarios') AND type in (N'U'))
DROP TABLE Usuarios
GO

CREATE TABLE Usuarios(
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Uname] [nvarchar](50) NULL,
	[Contraceña] [nvarchar](50) NULL,
	[Tip_Usuario] [nvarchar](50) NULL
) ON [PRIMARY]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'SP_Login') AND type in (N'U'))
DROP PROCEDURE SP_Login
GO

CREATE PROCEDURE SP_Login
	@Nombre varchar(50),
	@Contraceña varchar(16)
AS
BEGIN

	SELECT top 1 count(*) from Usuarios
	where Uname = @Nombre and Contraceña = @Contraceña 
	--select Tip_Usuario from Usuarios 
	--where Uname=@Nombre and Contraceña=@Contraceña 
	
	-- inicio inicio = new inicio();
    -- SqlCommand sexquery = new SqlCommand($"select nombre, sexo, puesto from usuarios where uname='{txtname.Text.Trim().ToLower()}';", conectar.SqlConnection);
    -- SqlDataReader sqlData = sexquery.ExecuteReader();
    -- if (sqlData.Read())
    -- {
    --      inicio.puesto = sqlData["puesto"].ToString();
    --      inicio.nombre = sqlData["nombre"].ToString();
    --      inicio.sexo = sqlData["sexo"].ToString();
    -- }
    --      inicio.Show();
    --      Hide();
	--
	select Tip_Usuario from Usuarios 
	where Uname = @Nombre and Contraceña = @Contraceña 
END
GO

----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Participantes') AND type in (N'U'))
DROP TABLE Participantes
GO

create table Participantes
(ID_Part int identity not null primary key,
Nom_part varchar (25),
Ape_part varchar (25),
Doc_part varchar (15),
Tel_part varchar (15),
Dir_part varchar (50),
Est_part BIT
)
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'SP_Insertat_act') AND type in (N'U'))
DROP PROCEDURE SP_Insertat_act
GO
go 
    create procedure SP_Insertar_act
    @id int, 
    @non varchar(25),
    @ape varchar(25),
    @doc varchar (15), 
    @tel varchar(15),
    @dir varchar(50), 
    @est BIT

as 
begin 
    if exists (select ID_part from Participantes where ID_part=@id)
        update Participantes set 
        Nom_part=@non,
        Ape_part=@ape,
        Doc_part=@doc,
        Tel_part=@tel,
        Dir_part=@dir,
        Est_part=@est 
        where ID_Part= @id

    else 
        insert into Participantes(Nom_part,Ape_part,Doc_part,Tel_part,Dir_part,Est_part)values(@non,@ape,@doc,@tel,@dir,@est)

end
GO
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Facilitadores') AND type in (N'U'))
DROP TABLE Facilitadores
GO

create table Facilitadores(
    ID_Fac int identity not null primary key,
    Nom_Fac varchar (25),
    Ape_Fac varchar (25),
    Doc_Fac  varchar (15),
    Tel_Fac varchar (15),
    Dir_Fac  varchar (50),
    Est_Fac BIT)

go 
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'SP_Indertar_act_fac') AND type in (N'U'))
DROP PROCEDURE SP_Indertar_act_fac
GO

    create procedure SP_Insertar_act_fac
    @id int, 
    @non varchar(25),
    @ape varchar(25),
    @doc varchar (15), 
    @tel varchar(15),
    @dir varchar(50), 
    @est BIT 
as 
begin 
    if exists (select ID_Fac from Facilitadores where ID_Fac = @id)
        update Facilitadores set 
        Nom_Fac = @non,
        Ape_Fac = @ape,
        Doc_Fac = @doc,
        Tel_Fac = @tel,
        Dir_Fac = @dir,
        Est_Fac = @est 
        where ID_Fac = @id

    else 

        insert into Facilitadores(
            Nom_Fac,
         Ape_Fac,
         Doc_Fac,
         Tel_Fac,
         Dir_Fac,
         Est_Fac)
         values(@non,@ape,@doc,@tel,@dir,@est)

END
GO
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Asignaturas') AND type in (N'U'))
DROP TABLE Asignaturas
GO

create table Asignaturas (
    Id_asig int identity not null primary key,
    Cla_asig varchar (7),
    Nom_Asi varchar (30),
    secion varchar (10),
    Tip_asig varchar (1),
    Est_asig BIT
)
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'SP_Act_inc_asig') AND type in (N'U'))
DROP PROCEDURE SP_Act_inc_asig
GO
go
    create procedure SP_Act_inc_asig
        @id int, 
        @cla varchar(7), 
        @non varchar(30),
        @sec varchar(10), 
        @tip varchar(1), 
        @est BIT

as 
begin 
    if exists (select * from Asignaturas where Id_asig = @id)
        update Asignaturas set 
        Cla_asig = @cla, 
        Nom_Asi = @non,
        secion = @sec,
        Tip_asig = @tip,
        Est_asig = @est 
        where Id_asig=@id

else 
    insert into Asignaturas (Cla_asig,Nom_Asi,secion,Tip_asig,Est_asig) values (@cla,@non,@sec,@tip,@est)

end
GO
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
go
    create procedure Eliminar_fac
        @id int

as 
begin 
    delete from Facilitadores where ID_Fac=@id
end
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
go
    create procedure Eliminar_par
        @id int

as 
begin 
    delete from Participantes  where ID_part=@id
end
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
go
    create procedure Eliminar_asig
        @id int

as 
begin 
    delete from Asignaturas where  Id_asig=@id
end
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------