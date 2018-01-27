/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     27/1/2018 0:52:20                            */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLE_FACTURA') and o.name = 'FK_DETALLE__MANTENIMI_MANTENIM')
alter table DETALLE_FACTURA
   drop constraint FK_DETALLE__MANTENIMI_MANTENIM
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLE_FACTURA') and o.name = 'FK_DETALLE__PRODUCTO__PRODUCTO')
alter table DETALLE_FACTURA
   drop constraint FK_DETALLE__PRODUCTO__PRODUCTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FACTURA') and o.name = 'FK_FACTURA_CLIENTE_F_CLIENTE')
alter table FACTURA
   drop constraint FK_FACTURA_CLIENTE_F_CLIENTE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FACTURA') and o.name = 'FK_FACTURA_DETALLE_F_DETALLE_')
alter table FACTURA
   drop constraint FK_FACTURA_DETALLE_F_DETALLE_
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENTE')
            and   type = 'U')
   drop table CLIENTE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETALLE_FACTURA')
            and   name  = 'MANTENIMIENTO_DETALLE_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETALLE_FACTURA.MANTENIMIENTO_DETALLE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETALLE_FACTURA')
            and   name  = 'PRODUCTO_DETALLE_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETALLE_FACTURA.PRODUCTO_DETALLE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DETALLE_FACTURA')
            and   type = 'U')
   drop table DETALLE_FACTURA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FACTURA')
            and   name  = 'DETALLE_FACTURA_FK'
            and   indid > 0
            and   indid < 255)
   drop index FACTURA.DETALLE_FACTURA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FACTURA')
            and   name  = 'CLIENTE_FACTURA_FK'
            and   indid > 0
            and   indid < 255)
   drop index FACTURA.CLIENTE_FACTURA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FACTURA')
            and   type = 'U')
   drop table FACTURA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MANTENIMIENTO')
            and   type = 'U')
   drop table MANTENIMIENTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PARAMETRO')
            and   type = 'U')
   drop table PARAMETRO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRODUCTO')
            and   type = 'U')
   drop table PRODUCTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIO')
            and   type = 'U')
   drop table USUARIO
go

/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE (
   IDCLIENTE            int                  not null,
   CICLIENTE            varchar(13)          not null,
   NOMBRECLIENTE        varchar(50)          not null,
   DIRECCIONCLIENTE     varchar(200)         not null,
   TELEFONOFIJOCLIENTE  varchar(9)           not null,
   TELEFONOMOVILCLIENTE varchar(10)          not null,
   constraint PK_CLIENTE primary key nonclustered (IDCLIENTE)
)
go

/*==============================================================*/
/* Table: DETALLE_FACTURA                                       */
/*==============================================================*/
create table DETALLE_FACTURA (
   IDDETALLEFACTURA     int                  not null,
   IDMANTENIMIENTO      int                  not null,
   IDPRODUCTO           int                  not null,
   CODIGO               int                  not null,
   CANTIDAD             int                  not null,
   DETALLE              varchar(50)          not null,
   VALORUNITARIO        float(7)             not null,
   DESCUENTODETALLE     float(7)             not null,
   VALORTOTAL           float(7)             not null,
   constraint PK_DETALLE_FACTURA primary key nonclustered (IDDETALLEFACTURA)
)
go

/*==============================================================*/
/* Index: PRODUCTO_DETALLE_FK                                   */
/*==============================================================*/
create index PRODUCTO_DETALLE_FK on DETALLE_FACTURA (
IDPRODUCTO ASC
)
go

/*==============================================================*/
/* Index: MANTENIMIENTO_DETALLE_FK                              */
/*==============================================================*/
create index MANTENIMIENTO_DETALLE_FK on DETALLE_FACTURA (
IDMANTENIMIENTO ASC
)
go

/*==============================================================*/
/* Table: FACTURA                                               */
/*==============================================================*/
create table FACTURA (
   IDFACTURA            int                  not null,
   IDDETALLEFACTURA     int                  not null,
   IDCLIENTE            int                  not null,
   FECHAFACTURA         varchar(10)          not null,
   VENDEDOR             varchar(50)          not null,
   TIPOPAGO             varchar(10)          not null,
   SUBTOTAL             float(10)            not null,
   DESCUENTO            float(7)             not null,
   IVA                  float(7)             not null,
   TOTAL                float(10)            not null,
   constraint PK_FACTURA primary key nonclustered (IDFACTURA)
)
go

/*==============================================================*/
/* Index: CLIENTE_FACTURA_FK                                    */
/*==============================================================*/
create index CLIENTE_FACTURA_FK on FACTURA (
IDCLIENTE ASC
)
go

/*==============================================================*/
/* Index: DETALLE_FACTURA_FK                                    */
/*==============================================================*/
create index DETALLE_FACTURA_FK on FACTURA (
IDDETALLEFACTURA ASC
)
go

/*==============================================================*/
/* Table: MANTENIMIENTO                                         */
/*==============================================================*/
create table MANTENIMIENTO (
   IDMANTENIMIENTO      int                  not null,
   FECHAMANTENIMIENTO   varchar(10)          not null,
   HORAMANTENIMIENTO    varchar(8)           not null,
   ESTADOMANTENIMIENTO  varchar(15)          not null,
   OBSERVACIONMANTENIMIENTO varchar(200)         not null,
   PRECIOMANTENIMIENTO  float(5)             not null,
   constraint PK_MANTENIMIENTO primary key nonclustered (IDMANTENIMIENTO)
)
go

/*==============================================================*/
/* Table: PARAMETRO                                             */
/*==============================================================*/
create table PARAMETRO (
   IDPARAMETRO          int                  not null,
   NOMBREPARAMETRO      varchar(15)          not null,
   VALOR                int                  not null,
   constraint PK_PARAMETRO primary key nonclustered (IDPARAMETRO)
)
go

/*==============================================================*/
/* Table: PRODUCTO                                              */
/*==============================================================*/
create table PRODUCTO (
   IDPRODUCTO           int                  not null,
   NOMBREPRODUCTO       varchar(25)          not null,
   DESCRIPCIONPRODUCTO  varchar(50)          not null,
   CATEGORIAPRODUCTO    varchar(25)          not null,
   CANTIDADPRODUCTO     int                  not null,
   PRECIOCOMPRAPRODUCTO float(5)             not null,
   PRECIOVENTAPRODUCTO  float(5)             not null,
   FECHAREGISTROPRECIOCOMPRA varchar(10)          not null,
   FECHAREGISTROPRECIOVENTA varchar(10)          not null,
   constraint PK_PRODUCTO primary key nonclustered (IDPRODUCTO)
)
go

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   IDUSUARIO            int                  not null,
   NOMBREUSUARIO        varchar(50)          not null,
   LOGINUSUARIO         varchar(20)          not null,
   PASSWORDUSUARIO      varchar(10)          not null,
   CARGOUSUARIO         varchar(15)          not null,
   constraint PK_USUARIO primary key nonclustered (IDUSUARIO)
)
go

alter table DETALLE_FACTURA
   add constraint FK_DETALLE__MANTENIMI_MANTENIM foreign key (IDMANTENIMIENTO)
      references MANTENIMIENTO (IDMANTENIMIENTO)
go

alter table DETALLE_FACTURA
   add constraint FK_DETALLE__PRODUCTO__PRODUCTO foreign key (IDPRODUCTO)
      references PRODUCTO (IDPRODUCTO)
go

alter table FACTURA
   add constraint FK_FACTURA_CLIENTE_F_CLIENTE foreign key (IDCLIENTE)
      references CLIENTE (IDCLIENTE)
go

alter table FACTURA
   add constraint FK_FACTURA_DETALLE_F_DETALLE_ foreign key (IDDETALLEFACTURA)
      references DETALLE_FACTURA (IDDETALLEFACTURA)
go

