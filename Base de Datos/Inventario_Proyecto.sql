create database Inventario
go

use Inventario
go

create table Empleados
(
idempleado int primary key identity(100, 1),
nombre nvarchar(50), 
apellido nvarchar(50), 
sexo char(1), 
cedula nvarchar(13),
email nvarchar(75),
direccion nvarchar(100), 
telefono nvarchar(14),
cargo nvarchar(30)
)
go

create table Usuarios
(
idusuario int primary key identity,
idempleado int constraint fk_idempleado_usuarios foreign key (idempleado) references empleados (idempleado),
nm_user nvarchar(15),
pass_word nvarchar(15),
categoria nvarchar(10)
)
go

create table Proveedores
(
idproveedor int primary key identity(100, 1), 
rnc nvarchar(15),
nombre nvarchar(75),
Direccion nvarchar(100),
Tel1 nvarchar(14),
tel2 nvarchar(14),
email nvarchar(75)
)
go

create table Departamentos
(
iddepartamento int primary key identity(1000, 10),
idempleado int constraint fk_idempleado_departamentos foreign key (idempleado) references empleados (idempleado),
nombredepto nvarchar(50)
)
go


create table Articulos
(
idarticulo int primary key identity(10000, 1),
idproveedor int constraint fk_idproveedor_articulos foreign key (idproveedor) references Proveedores (idproveedor),
nombre_articulo nvarchar(50), 
cantidad int,
marca nvarchar(30), 
descripcion nvarchar(100)
)
go

create table Entradas
(
identrada int primary key identity(100000, 1),
idusuario int constraint fk_idusuario_entradas foreign key (idusuario) references usuarios (idusuario),
idproveedor int constraint fk_idproveedor_entradas foreign key (idproveedor) references proveedores (idproveedor),
Conduce nvarchar(50),
fecha datetime,
cant_total int,
estado varchar(10)
)
go

create table EntradaDetail
(
Numentrada int constraint fk_numentrada_entradadetail foreign key (numentrada) references entradas (identrada),
idarticulo int constraint fk_idarticulo_entradadetail foreign key (idarticulo) references articulos (idarticulo),
cantidad int
)
go

create table Salidas
(
idsalida int primary key identity(1000000, 1),
idusuario int constraint fk_idusuario_salidas foreign key (idusuario) references usuarios (idusuario),
iddepartamento int constraint fk_iddepartamento_salidas foreign key (iddepartamento) references departamentos (iddepartamento),
fecha datetime,
cant_total int,
estado varchar(10)
)
go

create table SalidaDetail
(
numsalida int constraint fk_numsalida_salidadetail foreign key (numsalida) references salidas (idsalida),
idarticulo int constraint fk_idarticulo_salidadetail foreign key (idarticulo) references articulos (idarticulo),
cantidad int
)
go

create table Devolucion_entrada
(
iddevolucionentrada int primary key identity(1000000, 1),
numentrada int constraint fk_numentrada_devolucionentrada foreign key (numentrada) references entradas (identrada),
idusuario int constraint fk_idusuario_devolucionentrada foreign key (idusuario) references usuarios (idusuario),
fecha datetime,
cant_articulos int,
descripcion nvarchar(100)
)
go

create table Devolucion_salida
(
iddevolucionsalida int primary key identity(100000, 1),
numsalida int constraint fk_numsalida_devolucionsalida foreign key (numsalida) references salidas (idsalida),
idusuario int constraint fk_idusuario_devolucionsalida foreign key (idusuario) references usuarios (idusuario),
fecha datetime,
cant_articulos int,
descripcion nvarchar(100)
)
go

select * from devolucion_salida
use master
drop database inventario
