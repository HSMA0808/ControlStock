create trigger Entrada_EstadoNormal on Entradas
after insert
as
begin
Declare @id int;
set @id = (select identrada from inserted)
update entradas set estado = 'Normal' where identrada = @id
end
go

create trigger Salid_EstadoNormal on Salidas
after insert
as
begin
Declare @id int;
set @id = (select idsalida from inserted)
update salidas set estado = 'Normal' where idsalida = @id
end
go

create trigger Salida_DescontarArticulo on SalidaDetail
after insert
as
begin
declare @idarticulo int;
declare @cantidad int;
set @cantidad = (select cantidad from inserted);
set @idarticulo = (select idarticulo from inserted);
update articulos set cantidad = cantidad - @cantidad where idarticulo = @idarticulo;
end
go

create trigger Entrada_AumentarArticulo on entradadetail
after insert
as
begin
declare @idarticulo int;
declare @cantidad int;
set @cantidad = (select cantidad from inserted);
set @idarticulo = (select idarticulo from inserted);
update articulos set cantidad = cantidad + @cantidad where idarticulo = @idarticulo;
end
go

create trigger DevolucionarEntrada on Devolucion_Entrada
after insert
as
begin
declare @id int;
set @id = (select numentrada from inserted)
update Entradas set estado = 'Devuelto' where identrada = @id
end
go

create trigger DevolucionarSalida on Devolucion_salida
after insert
as
begin
declare @id int;
set @id = (select numsalida from inserted)
update salidas set estado = 'Devuelto' where idsalida = @id
end
go

