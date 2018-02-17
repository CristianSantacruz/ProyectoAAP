-- STORE PROCEDURE PARA INSERTAR DATOS TABLA PARAMETRO
alter proc insertarDatosParametro (
	@NOMBREPARAMETRO		varchar(15),
	@VALOR					int
)
as insert into PARAMETRO(NOMBREPARAMETRO, VALOR)
	values (@NOMBREPARAMETRO, @VALOR)

exec insertarDatosParametro 'IVA',12
select *from PARAMETRO
GO


--STORE PROCEDURA PARA BUSCAR PARAMETRO
create proc buscarParametro
	@NOMBREPARAMETRO			varchar(15)

as select NOMBREPARAMETRO, VALOR
						from PARAMETRO
	where NOMBREPARAMETRO like @NOMBREPARAMETRO + '%'

exec buscarParametro'IVA'
GO


--STORE PROCEDURE PARA ACTUALIZAR DATOS DEL PARAMETRO
create proc actualizarDatosParametro (
	@NOMBREPARAMETRO		varchar(15),
	@VALOR					int
)
as
	begin
	update PARAMETRO set
	VALOR=@VALOR
	where NOMBREPARAMETRO=@NOMBREPARAMETRO
	end

exec actualizarDatosParametro'IVA',14
select *from PARAMETRO
GO


--STORE PROCEDURE PARA ELIMINAR PARÁMETRO
create proc eliminarParametro (
	@NOMBREPARAMETRO           varchar(15)
)
as delete PARAMETRO
	where NOMBREPARAMETRO=@NOMBREPARAMETRO

exec eliminarParametro 'IVA'
select *from PARAMETRO

--STORE PROCEDURE PARA MOSTRAR TABLA PARÁMETROS
create proc mostrarParametros
as select top 10 *from PARAMETRO
	order by NOMBREPARAMETRO asc

exec mostrarParametros
