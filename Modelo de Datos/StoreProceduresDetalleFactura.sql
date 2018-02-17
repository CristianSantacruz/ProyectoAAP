-- STORE PROCEDURE PARA INSERTAR DATOS TABLA DETALLE_FACTURA
alter proc insertarDatosDetalleFactura (
	@IDFACTURA					int,
	@IDMANTENIMIENTO			int,
	@IDPRODUCTO					int,
	@CODIGO						varchar(5),
	@CANTIDAD					int,
	@DETALLE					varchar(50),
	@VALORUNITARIO				float(10),
	@DESCUENTODETALLE			float(10),
	@VALORTOTAL					float(10)
)
as insert into DETALLE_FACTURA(IDFACTURA, IDMANTENIMIENTO, IDPRODUCTO, CODIGO, CANTIDAD, DETALLE, VALORUNITARIO, DESCUENTODETALLE, VALORTOTAL)
	values (@IDFACTURA, @IDMANTENIMIENTO, @IDPRODUCTO, @CODIGO, @CANTIDAD, @DETALLE, @VALORUNITARIO, @DESCUENTODETALLE, @VALORTOTAL)

go
exec insertarDatosDetalleFactura 1,null,1,'M0001',2,'Disco',80,0,80
select *from DETALLE_FACTURA
GO

--DISMINUIR STOCK
create proc disminuirStock(
	@IDPRODUCTO		int,
	@CANTIDAD		int
)
as update PRODUCTO set CANTIDADPRODUCTO=CANTIDADPRODUCTO-@CANTIDAD
where IDPRODUCTO=@IDPRODUCTO
go

exec disminuirStock 1,2
go

select * from PRODUCTO




--****************************************************************************
--REESTABLECER STOCK AL ANULAR UNA FACTURA
alter trigger reestablecerStock
on [DETALLE_FACTURA]
for delete
as 

Update di set di.CANTIDADPRODUCTO=di.CANTIDADPRODUCTO+dv.CANTIDAD
from PRODUCTO as di inner join
deleted as dv on di.IDPRODUCTO=dv.IDPRODUCTO
go




--MOSTRAR DETALLE FACTURA
create proc mostarDetalleFactura 
	@IDFACTURA			int

as select IDDETALLEFACTURA, CODIGO, CANTIDAD, DETALLE, VALORUNITARIO, DESCUENTODETALLE, VALORTOTAL
		from DETALLE_FACTURA
		WHERE IDFACTURA = @IDFACTURA
go
exec mostarDetalleFactura 10
GO

--STORE PROCEDURE PARA ANULAR UNA FACTURA
create proc anularFactura (
	@IDFACTURA			int,
	@ESTADOFACTURA		varchar(15)
)
as
	begin
	update FACTURA set
	ESTADOFACTURA=@ESTADOFACTURA
	where IDFACTURA=@IDFACTURA
	end

exec anularFactura 1,'PENDIENTE'
select *from FACTURA
GO


