exec insertarDatosCliente '9999999999999','CONSUMIDOR FINAL','','2222222',''
select *from CLIENTE
GO

exec insertarDatosProducto'1','MANTENIMIENTO','SERVICIO DE MANTENIMIENTO','MANTENIMIENTO DE COMPUTADORES',
										0,0,0,'',''
select *from PRODUCTO
GO

exec insertarDatosMantenimiento 1,'INICIO','INICIO','OK', 'OK',0
select *from MANTENIMIENTO
GO

exec insertarDatosUsuario 'JUAN DE LA TORRE','juan.delatorre','123456','GERENTE'
select *from USUARIO
GO

exec insertarDatosFactura 1,1,'','OMICROM','', 0, 0, 0,0,''
select *from FACTURA
GO

exec insertarDatosParametro 'IVA',12
select *from PARAMETRO
GO
