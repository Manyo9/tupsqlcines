use cine
go

create trigger no_carga_butaca_ocupada
on reservas_butaca
for insert
as
begin
declare @idfuncion int
declare @idbutaca int
select @idfuncion = r.id_funcion, @idbutaca=i.id_butaca from inserted i join reservas r on i.id_resev_but=r.id_reserva
if @idbutaca in (select * from dbo.f_butacas_ocupadas(@idfuncion))
            begin
            raiserror('La butaca esta ocupada',16,1)
            rollback transaction --vuelve atras el insert porque hay un error
            end
end
go