-- STORE PROCEDURE PARA INSERTAR DATOS TABLA MANTENIMIENTO
alter proc insertarDatosMantenimiento (
	@IDCLIENTE						int,
	@FECHAMANTENIMIENTO				varchar(10),
	@HORAMANTENIMIENTO				varchar(8),
	@ESTADOMANTENIMIENTO			varchar(15),
	@OBSERVACIONMANTENIMIENTO		varchar(200),
	@PRECIOMANTENIMIENTO			float(5)
)
as insert into MANTENIMIENTO(IDCLIENTE, FECHAMANTENIMIENTO, HORAMANTENIMIENTO, ESTADOMANTENIMIENTO, OBSERVACIONMANTENIMIENTO, PRECIOMANTENIMIENTO)
	values (@IDCLIENTE, @FECHAMANTENIMIENTO, @HORAMANTENIMIENTO, @ESTADOMANTENIMIENTO, @OBSERVACIONMANTENIMIENTO, @PRECIOMANTENIMIENTO)

exec insertarDatosMantenimieNto 1,'12/02/2018','10:30:35','PENDIENTE','OK',25.45
select *from MANTENIMIENTO
GO


--STORE PROCEDURA PARA BUSCAR MANTENIMIENTO
alter proc buscarMantenimiento
	@IDMANTENIMIENTO			int

as select IDMANTENIMIENTO, CLIENTE.IDCLIENTE, CICLIENTE, NOMBRECLIENTE, DIRECCIONCLIENTE, TELEFONOFIJOCLIENTE, TELEFONOMOVILCLIENTE,
		FECHAMANTENIMIENTO, HORAMANTENIMIENTO, ESTADOMANTENIMIENTO, OBSERVACIONMANTENIMIENTO, PRECIOMANTENIMIENTO
		from CLIENTE INNER JOIN MANTENIMIENTO 
		ON CLIENTE.IDCLIENTE = MANTENIMIENTO.IDCLIENTE
		WHERE IDMANTENIMIENTO = @IDMANTENIMIENTO

exec buscarMantenimiento 1
GO


--STORE PROCEDURE PARA ACTUALIZAR DATOS DEL MANTENIMIENTO
create proc actualizarDatosMantenimiento (
	@IDMANTENIMIENTO				int,
	@ESTADOMANTENIMIENTO			varchar(15),
	@OBSERVACIONMANTENIMIENTO		varchar(200),
	@PRECIOMANTENIMIENTO			float(5)
)
as
	begin
	update MANTENIMIENTO set
	ESTADOMANTENIMIENTO=@ESTADOMANTENIMIENTO, OBSERVACIONMANTENIMIENTO=@OBSERVACIONMANTENIMIENTO, PRECIOMANTENIMIENTO=@PRECIOMANTENIMIENTO
	where IDMANTENIMIENTO=@IDMANTENIMIENTO
	end

exec actualizarDatosMantenimiento 1,'PENDIENTE','OK',28.5
select *from MANTENIMIENTO
GO


--STORE PROCEDURE PARA MOSTRAR TABLA MANTENIMIENTOS
alter proc mostrarMantenimientos
as select top 10 IDMANTENIMIENTO, CICLIENTE, NOMBRECLIENTE, TELEFONOFIJOCLIENTE, TELEFONOMOVILCLIENTE,
		FECHAMANTENIMIENTO, HORAMANTENIMIENTO, ESTADOMANTENIMIENTO, OBSERVACIONMANTENIMIENTO, PRECIOMANTENIMIENTO
		from CLIENTE INNER JOIN MANTENIMIENTO 
		ON CLIENTE.IDCLIENTE = MANTENIMIENTO.IDCLIENTE
		order by IDMANTENIMIENTO desc

exec mostrarMantenimientos

--STORE PROCEDURE PARA CONTAR N�MERO DE REGISTROS
alter proc contarRegistros
as select count (*) from MANTENIMIENTO

exec contarRegistros
