# Repo scrits LCII

# Falta hacer:
- generar las consultas de reporte</br>

# Consultas a desarrollar: (los trigger van si o si, el resto elegir cuales)
- Butacas desocupadas por funcion (HECHO)</br>
- Películas pasadas que no vendieron ninguna entrada (HECHO)</br>
- Películas más vistas</br>
- SP que saque la vigencia de todas las reservas que no hayan sido pagadas o sea que no tengan ticket (HECHO)</br>
- Reporte de entradas vendidas por sucursal en un período definido</br>
- Reporte de ganancias mensuales de un año (o sea genera 12 valores)</br>
- Reporte de ventas promedio por mes por cajero, mostrando cantidad de entradas e importe, teniendo en cuenta los descuentos</br>
- Reporte de sucursales con más visitas, siempre y cuando el valor sea mayor a un número ingresado por parámetro</br>
- Trigger que no permita cargar una reserva si la butaca ya está ocupada (HECHO)</br>
- Trigger que no permita cargar un detalle si la butaca ya está ocupada</br>

# Orden de carga:
1 - crear_tablas.sql</br>
2 - insert_auxiliares.sql</br>
3 - insert_cajeros.sql</br>
4 - insert_clientes.sql</br>
5 - insert_promociones.sql</br>
6 - insert_salas.sql</br>
7 - insert_tarjetas.sql</br>
8 - insert_funciones.sql</br>
9 - insert_butacas.sql</br>
10 - insert_reservas.sql</br>
11 - insert_reservas_butaca.sql</br>
12 - insert_ticket.sql</br>
13 - insert_pagos_detalles.sql</br>
14 - NO AGREGAR!! insert_promos_detalle.sql</br>
15 - funciones_y_sps.sql</br>
