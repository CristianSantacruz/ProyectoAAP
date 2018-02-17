-- STORE PROCEDURE PARA INSERTAR DATOS TABLA PRODUCTO
create proc insertarDatosProducto (
	@CODIGOPRODUCTO				varchar(5),
	@NOMBREPRODUCTO				varchar(25),
	@DESCRIPCIONPRODUCTO		varchar(50),
	@CATEGORIAPRODUCTO			varchar(25),
	@CANTIDADPRODUCTO			int,
	@PRECIOCOMPRAPRODUCTO		float(5),
	@PRECIOVENTAPRODUCTO		float(5),
	@FECHAREGISTROPRECIOCOMPRA	varchar(10),
	@FECHAREGISTROPRECIOVENTA	varchar(10)
)
as insert into PRODUCTO(CODIGOPRODUCTO,NOMBREPRODUCTO,DESCRIPCIONPRODUCTO,CATEGORIAPRODUCTO,CANTIDADPRODUCTO,PRECIOCOMPRAPRODUCTO,
						PRECIOVENTAPRODUCTO,FECHAREGISTROPRECIOCOMPRA,FECHAREGISTROPRECIOVENTA)
	values (@CODIGOPRODUCTO,@NOMBREPRODUCTO,@DESCRIPCIONPRODUCTO,@CATEGORIAPRODUCTO,@CANTIDADPRODUCTO,@PRECIOCOMPRAPRODUCTO,
			@PRECIOVENTAPRODUCTO,@FECHAREGISTROPRECIOCOMPRA,@FECHAREGISTROPRECIOVENTA)

exec insertarDatosProducto'M0001','Disco Duro','Disco Duro Samsung 1TB','Dispositivo de Almacenamiento',
										5,60.00,80.00,'12/02/2018','12/02/2018'
select *from PRODUCTO
GO


--STORE PROCEDURA PARA BUSCAR PRODUCTO POR C�DIGO
create proc buscarProductoCodigo
	@CODIGOPRODUCTO			varchar(5)

as select IDPRODUCTO, CODIGOPRODUCTO,NOMBREPRODUCTO,DESCRIPCIONPRODUCTO,CATEGORIAPRODUCTO,CANTIDADPRODUCTO,PRECIOCOMPRAPRODUCTO,
						PRECIOVENTAPRODUCTO,FECHAREGISTROPRECIOCOMPRA,FECHAREGISTROPRECIOVENTA
						from PRODUCTO
	where CODIGOPRODUCTO like @CODIGOPRODUCTO + '%'

exec buscarProductoCodigo'M0'
GO


--STORE PROCEDURE PARA ACTUALIZAR DATOS DEL PRODUCTO
create proc actualizarDatosProducto (
	@CODIGOPRODUCTO				varchar(5),
	@CANTIDADPRODUCTO			int,
	@PRECIOCOMPRAPRODUCTO		float(5),
	@PRECIOVENTAPRODUCTO		float(5),
	@FECHAREGISTROPRECIOCOMPRA	varchar(10),
	@FECHAREGISTROPRECIOVENTA	varchar(10)
)
as
	begin
	update PRODUCTO set
	CANTIDADPRODUCTO=@CANTIDADPRODUCTO, PRECIOCOMPRAPRODUCTO=@PRECIOCOMPRAPRODUCTO, PRECIOVENTAPRODUCTO=@PRECIOVENTAPRODUCTO,
	FECHAREGISTROPRECIOCOMPRA=@FECHAREGISTROPRECIOCOMPRA, FECHAREGISTROPRECIOVENTA=@FECHAREGISTROPRECIOVENTA
	where CODIGOPRODUCTO=@CODIGOPRODUCTO
	end

exec actualizarDatosProducto 'M0001',10,60.00,85.50,'22/02/2018','22/02/2018'
select *from PRODUCTO
GO


--STORE PROCEDURE PARA ELIMINAR PRODUCTO
create proc eliminarProducto (
	@CODIGOPRODUCTO           varchar(5)
)
as delete PRODUCTO
	where CODIGOPRODUCTO=@CODIGOPRODUCTO

exec eliminarProducto'M0001'
select *from PRODUCTO

--STORE PROCEDURE PARA MOSTRAR TABLA CLIENTE
create proc mostrarProductos
as select top 50 *from PRODUCTO
	order by CODIGOPRODUCTO asc

exec mostrarProductos