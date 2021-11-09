use cine
go

--Trae las butacas ocupadas
--Para una funcion llamada por parámetro
--Se ejecuta así: select * from dbo.f_butacas_ocupadas(id_funcion)
create function f_butacas_ocupadas
(@funcion int)
returns @ocupadas table
(id_butaca int)
as
	begin
		insert @ocupadas
			select rb.id_butaca from reservas re 
			join reservas_butaca rb on rb.id_resev_but = re.id_reserva
			where id_funcion = @funcion and vigencia = 1 --Vigencia en 1 verifica que no se haya dado de baja por tiempo
			union -- uno los resultados de las reservas y de lo que ya fue comprado y pagado, puede que se repita pero no importa
			select id_butaca from ticket t
			join detalles_ticket dt on dt.nro_ticket = t.nro_ticket
			where id_funcion = @funcion
		return
	end
go
--Trae las butacas disponibles
--Para una funcion llamada por parámetro
--Usa la funcion que devuelve las butacas ocupadas
--se ejecuta así: exec pa_butacas_disp_funcion 1
create procedure pa_butacas_disp_funcion
(@funcion int)
as	
	begin
		select id_butaca, cod_butaca from funciones f
		join salas sa on sa.id_sala=f.id_sala
		join butacas bu on bu.id_sala=sa.id_sala
		where id_funcion = @funcion 
		and bu.id_butaca not in
		(select * from dbo.f_butacas_ocupadas(@funcion)) --llama la funcion que devuelve butacas ocupadas
	end
go	
--Devuelve las reservas sin pagar
create function f_reservas_sin_pagar
(@funcion int)
returns table
as
return(
	select re.id_reserva from ticket ti
	right join reservas re on re.id_reserva = ti.id_reserva
	where nro_ticket is null and re.id_funcion = @funcion
	)
go
--Pone vigencia 0 en las reservas que estén sin pagar
--Usa la funcion que retorna dichas reservas
--Se llamaría por aplicación 2 horas antes de la función
create procedure pa_expirar_reservas
(@funcion int)
as
begin
	update reservas set vigencia = 0 where id_reserva in (select * from dbo.f_reservas_sin_pagar(@funcion))
end
go
--Contar entradas segun número de ticket e id_sucursal
create function f_contar_entradas
(@nroticket int,@sucursal int)
returns int
as
begin
	declare @cantidad int
	select @cantidad=count(id_detalle) from ticket t
	join detalles_ticket dt on t.nro_ticket=dt.nro_ticket and t.id_sucursal=dt.id_sucursal
	where t.nro_ticket = @nroticket and @sucursal = t.id_sucursal
	group by t.nro_ticket, t.id_sucursal
	return @cantidad
end 
go
--Reporte: Funciones pasadas que no vendieron ninguna entrada (entre un periodo de tiempo)
create procedure pa_peliculas_sin_ventas
@fecha1 date = '01/01/1900',
@fecha2 date= '01/01/2500'
as
    begin
	select p.id_pelicula as 'ID Pelicula',
	p.nombre as 'Nombre de la pelicula',
	g.genero as 'Genero',
	ltrim(str(p.duracion)+' minutos') as 'Duracion' 
	from peliculas p
	join generos g on p.id_genero = g.id_genero
	where id_pelicula not in (select distinct pe.id_pelicula from detalles_ticket dt
		join funciones fu on dt.id_funcion = dt.id_funcion
		join peliculas pe on fu.id_pelicula = pe.id_pelicula
		where fu.dia between @fecha1 and @fecha2)
    end
go

--Reporte:Peliculas mas vistas dentro de un periodo de tiempo, con filtrado minimo
create procedure pa_pelicula_mas_vista
@fecha1 date='01/01/1900',
@fecha2 date='31/12/2500', 
@cant_min int
as
begin
	select p.nombre 'Nombre de la Pelicula', COUNT (dt.id_detalle) 'Cantidad de Butacas vendidas'
	from detalles_ticket dt join funciones f on dt.id_funcion=f.id_funcion
	join peliculas p on f.id_pelicula=p.id_pelicula
	where f.dia between @fecha1 and @fecha2
	group by p.nombre
	having COUNT(dt.id_detalle) > @cant_min 	
	order by 2 desc
end
go

--calcula el subtotal de un detalle teniendo en cuenta el descuento
create function f_calcular_subtotal
(@detalle int)
returns money
as
begin
	declare @total money
	declare @variabletest int
	select @variabletest=dt.id_promocion from ticket t 
	join detalles_ticket dt on dt.id_detalle = @detalle
	if @variabletest is not null
		begin
			select @total=dt.precio*(1-pro.descuento) 
			from detalles_ticket dt 
			join promociones pro on pro.id_promocion = dt.id_promocion
			where @detalle = dt.id_detalle
		end
	else
		begin
			select @total=dt.precio
			from detalles_ticket dt
			where @detalle = dt.id_detalle
		end
	return @total
end
go

--calcula el total a pagar con descuentos aplicados de un ticket
create function f_calcular_total
(@nroticket int, @sucursal int)
returns money
as
begin
	declare @total money

	select @total=sum(dbo.f_calcular_subtotal(dt.id_detalle)) from ticket t
	join detalles_ticket dt on t.nro_ticket=dt.nro_ticket and t.id_sucursal=dt.id_sucursal
	where @nroticket=t.nro_ticket and @sucursal=t.id_sucursal
	return @total
end
go

--Reporte de ganancias mensuales de un año (o sea genera un valor por cada mes donde hubo ventas)
create procedure pa_reporte_ganancias_mensuales
@año int
as
begin
    select month(t.fecha)'Mes', sum(dbo.f_calcular_total(t.nro_ticket,t.id_sucursal)) 'Ganancias del mes'
	from ticket t
    where year(t.fecha)=year(GETDATE())
    group by month(t.fecha)
    order by 1 asc
end
go

--Reporte: cantidad de entradas vendidas por sucursal en un periodo definido 
create procedure pa_reporte_entradas_sucursal
(@fecha_1 datetime,
@fecha_2 datetime)
as
begin 
    select t.id_sucursal, suc.nombre 'Nombre de la sucursal', COUNT (dt.id_detalle) 'Cantidad de entradas vendidas'
    from ticket t join detalles_ticket dt on dt.nro_ticket=t.nro_ticket
	join sucursales suc on suc.id_sucursal = t.id_sucursal
    where fecha between @fecha_1 and @fecha_2
    group by t.id_sucursal, suc.nombre
    order by 1 
end
go

--Reporte de importe promedio de venta (ticket) por mes por cajero,
--mostrando cantidad de entradas,
--teniendo en cuenta los descuentos
--de un año en particular
create procedure pa_ventas_promedio_por_cajero
(@año int)
as
	select ca.apellido+' '+ca.nombre as 'Cajero',
	month(t.fecha) as 'Mes del año',
	avg(distinct dbo.f_calcular_total(t.nro_ticket,t.id_sucursal)) as 'Importe promedio de venta',
	count(dt.id_detalle) as 'Cantidad de entradas vendidas'
	from ticket t
	join cajeros ca on t.id_cajero = ca.id_cajero
	join detalles_ticket dt on t.nro_ticket=dt.nro_ticket and t.id_sucursal=dt.id_sucursal
	where year(t.fecha) = @año
	group by ca.apellido+' '+ca.nombre, month(t.fecha)
	order by 1
go

-- SP para imprimir entrada
create procedure pa_entradas_por_ticket
(@nro_ticket int,
@id_sucursal int)
as
	select *
	from vista_entrada
	where id_sucursal=@id_sucursal and [Nro de transacción] = @nro_ticket
go

--SP para imprimir un ticket (no trae detalles)
create procedure pa_imprimir_ticket
(@nro_ticket int,
@id_sucursal int)
as
	select *
	from vista_comprobante
	where [Id sucursal]=@id_sucursal and [Nro de transacción] = @nro_ticket
go