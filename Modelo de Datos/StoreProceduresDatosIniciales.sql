exec insertarDatosCliente '9999999999999','CONSUMIDOR FINAL','','2222222',''
select *from CLIENTE
GO

exec insertarDatosProducto'00001','MANTENIMIENTO','SERVICIO DE MANTENIMIENTO','MANTENIMIENTO DE COMPUTADORES',
										0,0,0,'',''
select *from PRODUCTO
GO

exec insertarDatosUsuario 'ERIKA ANATOA','erika','123456','CAJERO'
select *from USUARIO
GO

exec insertarDatosFactura 1,1,'','OMICROM','', 0, 0, 0,0,''
select *from FACTURA
GO