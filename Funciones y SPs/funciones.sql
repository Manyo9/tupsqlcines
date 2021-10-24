
--Trae las butacas disponibles
--Para una funcion llamada por parámetro
--Se ejecuta así: select * from dbo.f_butacas_disp_funcion(id_funcion)

create function f_butacas_disp_funcion
(@funcion int)
returns @butacas table
(id_butaca int, cod_butaca varchar(3))
begin
	insert @butacas
		select id_butaca, cod_butaca from funciones f
		join salas sa on sa.id_sala=f.id_sala
		join butacas bu on bu.id_sala=sa.id_sala
		where id_funcion = @funcion 
		and bu.id_butaca not in
		(select rb.id_butaca from reservas re 
		join reservas_butaca rb on rb.id_resev_but = re.id_reserva
		where id_funcion = @funcion and vigencia = 1 --Vigencia en 1 verifica que no se haya dado de baja por tiempo
		union -- uno los resultados de las reservas y de lo que ya fue comprado y pagado, puede que se repita pero no importa
		select id_butaca from ticket t
		join detalles_ticket dt on dt.nro_ticket = t.nro_ticket
		where id_funcion = @funcion)
	return
end
