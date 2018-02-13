-- STORE PROCEDURE PARA INSERTAR DATOS TABLA USUARIO
alter proc insertarDatosUsuario (
	@NOMBREUSUARIO				varchar(50),
	@LOGINUSUARIO				varchar(20),
	@PASSWORDUSUARIO			varchar(10),
	@CARGOUSUARIO				varchar(15)
)
as insert into USUARIO(NOMBREUSUARIO, LOGINUSUARIO, PASSWORDUSUARIO, CARGOUSUARIO)
	values (@NOMBREUSUARIO, @LOGINUSUARIO, @PASSWORDUSUARIO, @CARGOUSUARIO)

exec insertarDatosUsuario 'cristian santacruz','cristian','123456','Administrador'
select *from USUARIO
GO


--STORE PROCEDURA PARA BUSCAR USUARIO
create proc buscarUsuario
	@NOMBREUSUARIO			varchar(50)

as select NOMBREUSUARIO, LOGINUSUARIO, PASSWORDUSUARIO, CARGOUSUARIO
						from USUARIO
	where NOMBREUSUARIO like @NOMBREUSUARIO + '%'

exec buscarUsuario'CR'
GO


--STORE PROCEDURE PARA ACTUALIZAR DATOS DEL USUARIO
create proc actualizarDatosUsuario (
	@NOMBREUSUARIO				varchar(50),
	@PASSWORDUSUARIO			varchar(10),
	@CARGOUSUARIO				varchar(15)
)
as
	begin
	update USUARIO set
	PASSWORDUSUARIO=@PASSWORDUSUARIO, CARGOUSUARIO=@CARGOUSUARIO
	where NOMBREUSUARIO=@NOMBREUSUARIO
	end

exec actualizarDatosUsuario'CRISTIAN SANTACRUZ','12345','Administrador'
select *from USUARIO
GO


--STORE PROCEDURE PARA ELIMINAR USUARIO
create proc eliminarUsuario (
	@NOMBREUSUARIO           varchar(50)
)
as delete USUARIO
	where NOMBREUSUARIO=@NOMBREUSUARIO

exec eliminarUsuario 'cristin'
select *from USUARIO

--STORE PROCEDURE PARA MOSTRAR TABLA USUARIOS
create proc mostrarUsuarios
as select top 50 *from USUARIO
	order by NOMBREUSUARIO asc

exec mostrarUsuarios
