use cine

--vista de datos para ayudar a imprimir la entrada
create view vista_entrada
as
	select suc.id_sucursal, --no se usa al imprimir el ticket
	dt.nro_ticket 'Nro de transacción',
	suc.nombre as 'Nombre sucursal',
	sa.nom_sala 'Nombre sala',
	pe.nombre 'Nombre Pelicula',
	fun.dia 'Dia de la función',
	fun.hora_inicio 'Hora de inicio',
	bu.cod_butaca 'Código butaca',
	ltrim(str(pe.duracion)+' minutos') as 'Duracion de la película',
	dt.precio 'Subtotal'
	from ticket t
	join detalles_ticket dt on dt.nro_ticket = t.nro_ticket and dt.id_sucursal = t.id_sucursal
	join sucursales suc on suc.id_sucursal = t.id_sucursal
	join funciones fun on fun.id_funcion = dt.id_funcion
	join peliculas pe on fun.id_pelicula = pe.id_pelicula
	join butacas bu on bu.id_butaca = dt.id_butaca
	join salas sa on fun.id_sala = sa.id_sala
	
--vista de datos para ayudar a imprimir un ticket/comprobante de pago
create view vista_comprobante
as 
	select distinct suc.nombre as 'Sucursal',
	t.nro_ticket 'Nro de transacción',
	mt.nombre 'Forma de pago',
	dbo.f_contar_entradas(t.nro_ticket,t.id_sucursal) as 'Cantidad de entradas'
	from ticket t 
	join detalles_ticket dt on dt.id_sucursal=t.id_sucursal and dt.nro_ticket=t.nro_ticket
	join sucursales suc on t.id_sucursal = suc.id_sucursal
	join pagos pa on pa.id_pago=dt.id_pago
	join metodos_pago mt on mt.id_metodo=pa.id_metodo