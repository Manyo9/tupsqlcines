create database cine
go
use cine
go

create table promociones 
(id_promocion smallint identity,
promocion varchar (30),
descuento decimal (3,2)
constraint pk_promocion primary key (id_promocion)  
)
create table metodos_pago
(id_metodo smallint identity,
nombre varchar (20)
constraint pk_metodos_pago primary key (id_metodo) 
)
create table bancos
(id_banco smallint identity,
nom_banco varchar (50)
constraint pk_banco primary key (id_banco) 
)
create table tipos_compra
(id_tipo_compra tinyint identity,
tipo varchar (20)
constraint pk_tipos_compra primary key (id_tipo_compra) 
)
create table tipos_sala
(id_tipo_sala tinyint identity,
nombre varchar (30),
precio money
constraint pk_tipos_sala primary key (id_tipo_sala) 
)
create table localidades
(id_localidad smallint identity,
localidad varchar (30)
constraint pk_localidades primary key (id_localidad) 
)
create table barrios
(id_barrio smallint identity,
nombre varchar (50),
id_localidad smallint
constraint pk_barrios primary key (id_barrio),
constraint fk_localidades foreign key (id_localidad)
references localidades (id_localidad)
)
create table tipos_documento
(id_tipo_doc smallint identity,
tipo_doc varchar (30)
constraint pk_tipos_doc primary key (id_tipo_doc) 
)
create table sucursales
(id_sucursal smallint identity,
nombre varchar (50)
constraint pk_sucursales primary key (id_sucursal) 
)
create table generos
(id_genero smallint identity,
genero varchar (30)
constraint pk_generos primary key (id_genero) 
)
create table clientes
(id_cliente int identity, 
nombre varchar (30),
apellido varchar (30),
fec_nac datetime, 
id_tipo_doc smallint, 
num_doc varchar (30)
constraint pk_clientes primary key (id_cliente),
constraint fk_tipo_documento_clientes foreign key (id_tipo_doc)
references tipos_documento (id_tipo_doc)
)
create table salas 
(id_sala smallint identity, 
id_sucursal smallint, 
nom_sala varchar (20),
id_tipo_sala tinyint
constraint pk_salas primary key (id_sala),
constraint fk_sucursales foreign key (id_sucursal)
references sucursales (id_sucursal),
constraint fk_tipos_sala foreign key (id_tipo_sala)
references tipos_sala (id_tipo_sala)
)
create table butacas
(id_butaca int identity,
id_sala smallint, 
cod_butaca varchar(4)
constraint pk_butacas primary key (id_butaca),
constraint fk_salas foreign key (id_sala)
references salas (id_sala)
)
create table cajeros
(id_cajero int identity, 
nombre varchar (30),
apellido varchar (30), 
fec_nac datetime, 
id_tipo_doc smallint, 
num_doc varchar (30),
id_barrio smallint,
direccion varchar (50),
sueldo money,
fecha_ingreso datetime,
id_sucursal smallint
constraint pk_cajeros primary key (id_cajero),
constraint fk_tipo_documento_cajeros foreign key (id_tipo_doc)
references tipos_documento (id_tipo_doc),
constraint fk_barrios foreign key (id_barrio)
references barrios (id_barrio),
constraint fk_sucursales_cajeros foreign key (id_sucursal)
references sucursales (id_sucursal)
)
create table tarjetas 
(id_tarjeta int identity, 
num_tarjeta char (16),
nom_titular varchar (60),
fec_venc datetime,
id_banco smallint
constraint pk_tarjetas primary key (id_tarjeta),
constraint fk_bancos foreign key (id_banco)
references bancos (id_banco)
)
create table pagos 
(id_pago int identity, 
id_metodo smallint, 
id_tarjeta int 
constraint pk_pagos primary key (id_pago),
constraint fk_metodos_pago_pagos foreign key (id_metodo)
references metodos_pago (id_metodo),
constraint fk_tarjetas foreign key (id_tarjeta)
references tarjetas (id_tarjeta)
)
create table peliculas 
(id_pelicula int identity,
nombre varchar (80),
id_genero smallint, 
fecha_estreno date,
duracion smallint 
constraint pk_peliculas primary key (id_pelicula),
constraint fk_generos foreign key (id_genero)
references generos (id_genero)
)
create table funciones 
(id_funcion int identity, 
id_sala smallint,
hora_inicio time,
dia date,
id_pelicula int
constraint pk_funciones primary key (id_funcion),
constraint fk_salas_funciones foreign key (id_sala)
references salas (id_sala),
constraint fk_peliculas foreign key (id_pelicula)
references peliculas (id_pelicula)
)
create table reservas 
(id_reserva int identity, 
id_funcion int, 
id_cliente int, 
fecha_hora datetime,
vigencia bit  
constraint pk_reservas primary key (id_reserva),
constraint fk_funciones foreign key (id_funcion)
references funciones (id_funcion),
constraint fk_clientes foreign key (id_cliente)
references clientes (id_cliente) 
)
create table reservas_butaca 
(id_resev_but int,
id_butaca int
constraint pk_reservas_butaca primary key (id_resev_but,id_butaca),
constraint fk_reservas foreign key (id_resev_but)
references reservas (id_reserva),
constraint fk_butacas foreign key (id_butaca)
references butacas (id_butaca)
)
create table ticket
(nro_ticket int,
id_sucursal smallint,
fecha datetime,
id_cajero int,
id_cliente int, 
id_tipo_compra tinyint,
id_reserva int 
constraint pk_ticket primary key (nro_ticket,id_sucursal),
constraint fk_sucursales_tickets foreign key (id_sucursal)
references sucursales (id_sucursal),
constraint fk_cajeros_tickets foreign key (id_cajero)
references cajeros (id_cajero),
constraint fk_cliente foreign key (id_cliente)
references clientes (id_cliente),
constraint fk_tipos_compras foreign key (id_tipo_compra)
references tipos_compra (id_tipo_compra),
constraint fk_reservas_ticket foreign key (id_reserva)
references reservas (id_reserva)
)
create table detalles_ticket
(id_detalle int identity,
nro_ticket int,
id_butaca int,
id_pago int,
precio money, 
id_funcion int,
id_sucursal smallint 
constraint pk_detalles_ticket primary key (id_detalle),
constraint fk_ticket foreign key (nro_ticket,id_sucursal)
references ticket (nro_ticket,id_sucursal),
constraint fk_sucursales_detalles foreign key (id_sucursal)
references sucursales (id_sucursal),
constraint fk_butacas_detalles foreign key (id_butaca)
references butacas (id_butaca),
constraint fk_pagos foreign key (id_pago)
references pagos (id_pago),
constraint fk_funciones_detalles foreign key (id_funcion)
references funciones (id_funcion)
)
create table promos_detalle
(id_promocion smallint, 
id_detalle int
constraint pk_promos_detalle primary key (id_promocion,id_detalle),
constraint fk_promociones foreign key (id_promocion)
references promociones (id_promocion),
constraint fk_detalles_ticket foreign key (id_detalle)
references detalles_ticket (id_detalle)
)
