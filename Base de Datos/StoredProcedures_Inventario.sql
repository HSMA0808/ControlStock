alter procedure Mostrar_Articulos
as
begin
select articulos.idarticulo as 'ID Articulo', proveedores.nombre as 'Proveedor', articulos.nombre_articulo, 
articulos.cantidad as 'Cantidad', articulos.marca as 'Marca', articulos.Descripcion as 'Descripcion'
from articulos join proveedores on proveedores.idproveedor = articulos.idproveedor
end
go


create procedure Mostrar_Departamento
as
begin
select departamentos.iddepartamento as 'ID Departamento', empleados.nombre + ' ' + empleados.Apellido as 'Empleado', 
Departamentos.nombredepto as 'Departamento' from departamentos join Empleados on departamentos.idempleado = empleados.idempleado
end
go

create procedure Mostrar_Entradas
as
begin
select entradas.identrada as 'ID Entrada', usuarios.nm_user as 'Usuario', proveedores.nombre as 'Proveedor', 
entradas.conduce as 'Conduce', entradas.fecha as 'Fecha', entradas.cant_total as 'Cantidad' from entradas join usuarios
on usuarios.idusuario = entradas.idusuario join proveedores on entradas.idproveedor = proveedores.idproveedor
where entradas.estado = 'Normal';
end 
go

create procedure Mostrar_Salidas
as
begin
select salidas.idsalida as 'ID Salida', usuarios.nm_user as 'Usuario', departamentos.nombredepto as 'Departamento',
empleados.nombre + ' ' + empleados.apellido as 'Supervisor', salidas.fecha as 'Fecha', salidas.cant_total as 'Cantidad' 
from salidas  join usuarios on salidas.idusuario = usuarios.idusuario join departamentos on salidas.iddepartamento = departamentos.iddepartamento 
join Empleados on Departamentos.idempleado = Empleados.idempleado where salidas.estado = 'Normal'
end
go

create procedure Mostrar_DevolucionEntrada
as
begin
select dev.iddevolucionentrada as 'ID Devolucion', dev.numentrada as 'ID Entrada', usuarios.nm_user as 'Usuario', dev.fecha as 'Fecha', 
dev.cant_articulos as 'Cantidad', dev.descripcion as 'Descripcion' from Devolucion_entrada dev join usuarios on Usuarios.idusuario = dev.idusuario;
end
go

select * from empleados

alter procedure Mostrar_DevolucionSalida
as
begin
select dev.iddevolucionsalida as 'ID Devolucion', dev.numsalida as 'ID Salida', usuarios.nm_user as 'Usuario', dev.fecha as 'Fecha', 
dev.cant_articulos as 'Cantidad', dev.descripcion as 'Descripcion' from Devolucion_salida dev join usuarios on Usuarios.idusuario = dev.idusuario;
end