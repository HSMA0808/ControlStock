using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormularioConsultas : Form
    {
        public FormularioConsultas()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        public FormularioConsultas(string entidad)
        {
            InitializeComponent();
            lblEntidad.Text = entidad;
            ParsearRadios(entidad);
        }

        private void FormularioConsultas_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
            // TODO: esta línea de código carga datos en la tabla 'inventario_articulos_DataSet.Articulos' Puede moverla o quitarla según sea necesario.
           // this.articulosTableAdapter.Fill(this.inventario_articulos_DataSet.Articulos);
        }
        private void ParsearRadios(string Entidad)
        {
            switch (Entidad)
            {
                case "Stock":
                    radioButton1.Text = "ID";
                    radioButton2.Text = "Nombre";
                    radioButton3.Text = "Marca";
                    radioButton4.Text = "Proveedor";
                    break;
                case "Articulos":
                    radioButton1.Text = "ID";
                    radioButton2.Text = "Nombre";
                    radioButton3.Text = "Marca";
                    radioButton4.Visible = false;
                    break;
                case "Departamentos":
                    radioButton1.Text = "Nombre";
                    radioButton2.Text = "Superviaor";
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    break;
                case "Empleados":
                    radioButton1.Text = "Nombre";
                    radioButton2.Text = "Cedula";
                    radioButton3.Text = "Direccion";
                    radioButton4.Text = "Telefono";
                    break;
                case "Entradas":
                    radioButton1.Text = "No. Entrada";
                    radioButton2.Text = "Proveedor";
                    radioButton3.Text = "Empleado";
                    radioButton4.Text = "Fecha";
                    break;
                case "Proveedores":
                    radioButton1.Text = "RNC";
                    radioButton2.Text = "Nombre";
                    radioButton3.Text = "Direccion";
                    radioButton4.Visible = false;
                    break;
                case "Salidas":
                    radioButton1.Text = "No. Salida";
                    radioButton2.Text = "Usuario";
                    radioButton3.Text = "Fecha";
                    radioButton4.Visible = false;
                    break;
                case "Usuarios":
                    radioButton1.Text = "Nombre Usuario";
                    radioButton2.Visible = false;
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    break;
                case "Devolucion Entrada":
                    radioButton1.Text = "No. Devolucion";
                    radioButton2.Text = "Usuario";
                    radioButton3.Text = "Fecha";
                    radioButton4.Visible = false;
                    break;
                case "Devolucion Salida":
                    radioButton1.Text = "No. Devolucion";
                    radioButton2.Text = "Usuario";
                    radioButton3.Text = "Fecha";
                    radioButton4.Visible = false;
                    break;
            }
        }

        private void EjecutarConsultaClasificada()
        {
            var conexion = new Clases.Conexion();
            switch (lblEntidad.Text)
            {
                case "Stock":
                    if (txtBusqueda.Text == string.Empty)
                    {
                        conexion.CargarDataGridView("select articulos.idarticulo as 'ID', articulos.nombre_articulo as 'Nombre', articulos.cantidad as 'Cantidad', articulos.marca as 'Marca', " +
                        "proveedores.nombre as 'Proveedor' from articulos join proveedores on articulos.idproveedor = proveedores.idproveedor", dataGridView2);
                    }
                    else if (radioButton1.Checked)
                    {
                        conexion.CargarDataGridView("select articulos.idarticulo as 'ID', articulos.nombre_articulo as 'Nombre', articulos.cantidad as 'Cantidad', articulos.marca as 'Marca', " +
                        "proveedores.nombre as 'Proveedor' from articulos join proveedores on articulos.idproveedor = proveedores.idproveedor where articulos.idarticulo like '%" + txtBusqueda.Text + "%'", dataGridView2);
                    }
                    else if (radioButton2.Checked)
                    {
                        conexion.CargarDataGridView("select articulos.idarticulo as 'ID', articulos.nombre_articulo as 'Nombre', articulos.cantidad as 'Cantidad', articulos.marca as 'Marca', " +
                        "proveedores.nombre as 'Proveedor' from articulos join proveedores on articulos.idproveedor = proveedores.idproveedor where articulos.nombre_articulo like '%" + txtBusqueda.Text + "%'", dataGridView2);

                    }
                    else if (radioButton3.Checked)
                    {
                        conexion.CargarDataGridView("select articulos.idarticulo as 'ID', articulos.nombre_articulo as 'Nombre', articulos.cantidad as 'Cantidad', articulos.marca as 'Marca', " +
                        "proveedores.nombre as 'Proveedor' from articulos join proveedores on articulos.idproveedor = proveedores.idproveedor where articulos.marca like '%" + txtBusqueda.Text + "%'", dataGridView2);

                    }
                    else if (radioButton4.Checked)
                    {
                        conexion.CargarDataGridView("select articulos.idarticulo as 'ID', articulos.nombre_articulo as 'Nombre', articulos.cantidad as 'Cantidad', articulos.marca as 'Marca', " +
                        "proveedores.nombre as 'Proveedor' from articulos join proveedores on articulos.idproveedor = proveedores.idproveedor where proveedores.nombre like '%" + txtBusqueda.Text + "%'", dataGridView2);

                    }
                    else
                    {
                        conexion.CargarDataGridView("select articulos.idarticulo as 'ID', articulos.nombre_articulo as 'Nombre', articulos.cantidad as 'Cantidad', articulos.marca as 'Marca', " +
                        "proveedores.nombre as 'Proveedor' from articulos join proveedores on articulos.idproveedor = proveedores.idproveedor where articulos.nombre_articulo like '%" + txtBusqueda.Text + "%'", dataGridView2);
                    }
                    break;

                case "Articulos":
                    if (txtBusqueda.Text == string.Empty)
                    {
                        conexion.CargarDataGridView("select idarticulo as 'ID', nombre_articulo as 'Nombre', cantidad as 'Cantidad', marca as 'Marca' " +
                        "from articulos", dataGridView2);
                    }
                    else if (radioButton1.Checked)
                    {
                        conexion.CargarDataGridView("select idarticulo as 'ID', nombre_articulo as 'Nombre', cantidad as 'Cantidad', marca as 'Marca' " +
                        "from articulos where id = '%" + txtBusqueda.Text + "%'", dataGridView2);
                    }
                    else if (radioButton2.Checked)
                    {
                        conexion.CargarDataGridView("select idarticulo as 'ID', nombre_articulo as 'Nombre', cantidad as 'Cantidad', marca as 'Marca' " +
                        "from articulos where nombre_articulo like '%" + txtBusqueda.Text + "%'", dataGridView2);

                    }
                    else if (radioButton3.Checked)
                    {
                        conexion.CargarDataGridView("select idarticulo as 'ID', nombre_articulo as 'Nombre', cantidad as 'Cantidad', marca as 'Marca' " +
                        "from articulos where marca like '%" + txtBusqueda.Text + "%'", dataGridView2);

                    }
                    else
                    {
                        conexion.CargarDataGridView("select idarticulo as 'ID', nombre_articulo as 'Nombre', cantidad as 'Cantidad', marca as 'Marca' " +
                        "from articulos where nombre_articulo like '%" + txtBusqueda.Text + "%'", dataGridView2);
                    }
                    break;

                case "Departamentos":
                    if (txtBusqueda.Text == string.Empty)
                    {
                        conexion.CargarDataGridView("select departamentos.iddepartamento as 'ID', departamentos.nombredepto as 'Nombre', empleados.nombre +' '+ empleados.apellido as 'Supervisor' " +
                        "from Departamentos join empleados on departamentos.idempleado = empleados.idempleado", dataGridView2);
                    }
                    else if (radioButton1.Checked)
                    {
                        conexion.CargarDataGridView("select departamentos.iddepartamento as 'ID', departamentos.nombredepto as 'Nombre', empleados.nombre +' '+ empleados.apellido as 'Supervisor' " +
                        "from Departamentos join empleados on departamentos.idempleado = empleados.idempleado where Nombredepto like '%"+txtBusqueda.Text+"%'", dataGridView2);
                    }
                    else if (radioButton2.Checked)
                    {
                        conexion.CargarDataGridView("select departamentos.iddepartamento as 'ID', departamentos.nombredepto as 'Nombre', empleados.nombre +' '+ empleados.apellido as 'Supervisor' " +
                        "from Departamentos join empleados on departamentos.idempleado = empleados.idempleado where empleados.nombre +' '+ empleados.apellido like '%" + txtBusqueda.Text + "%'", dataGridView2);

                    }
                    else
                    {
                        conexion.CargarDataGridView("select departamentos.iddepartamento as 'ID', departamentos.nombredepto as 'Nombre', empleados.nombre +' '+ empleados.apellido as 'Supervisor' " +
                        "from Departamentos join empleados on departamentos.idempleado = empleados.idempleado where Nombredepto like '%" + txtBusqueda.Text + "%'", dataGridView2);
                    }
                    break;

                case "Empleados":
                    if (txtBusqueda.Text == string.Empty)
                    {
                        conexion.CargarDataGridView("select idempleado as 'ID', nombre +' '+ apellido as 'Nombre', sexo as 'Sexo', cedula as 'Cedula', " +
                        "cargo as 'Cargo'from empleados", dataGridView2);
                    }
                    else if (radioButton1.Checked)
                    {
                        conexion.CargarDataGridView("select idempleado as 'ID', nombre +' '+ apellido as 'Nombre', sexo as 'Sexo', cedula as 'Cedula', " +
                        "cargo as 'Cargo'from empleados where nombre like '%" + txtBusqueda.Text + "%' or apellido like '%" + txtBusqueda.Text + "%'", dataGridView2);
                    }
                    else if (radioButton2.Checked)
                    {
                        conexion.CargarDataGridView("select idempleado as 'ID', nombre +' '+ apellido as 'Nombre', sexo as 'Sexo', cedula as 'Cedula', " +
                        "cargo as 'Cargo'from empleados where cedula = '" + txtBusqueda.Text + "'", dataGridView2);

                    }
                    else if (radioButton3.Checked)
                    {
                        conexion.CargarDataGridView("select idempleado as 'ID', nombre +' '+ apellido as 'Nombre', sexo as 'Sexo', cedula as 'Cedula', " +
                        "cargo as 'Cargo'from empleados where Direccion like '%" + txtBusqueda.Text + "%'", dataGridView2);

                    }
                    else if (radioButton4.Checked)
                    {
                        conexion.CargarDataGridView("select idempleado as 'ID', nombre +' '+ apellido as 'Nombre', sexo as 'Sexo', cedula as 'Cedula', " +
                        "cargo as 'Cargo'from empleados where telefono like '%" + txtBusqueda.Text + "%'", dataGridView2);
                    }
                    else
                    {
                        conexion.CargarDataGridView("select idempleado as 'ID', nombre +' '+ apellido as 'Nombre', sexo as 'Sexo', cedula as 'Cedula', " +
                        "cargo as 'Cargo'from empleados", dataGridView2);
                    }
                    break;

                case "Entradas":
                    if (txtBusqueda.Text == string.Empty)
                    {
                        conexion.CargarDataGridView("select entradas.identrada as 'No. Entrada', entradas.conduce as 'Conduce', entradas.fecha as 'Fecha', entradas.cant_total as 'Cantidad Arts.', " +
                        "proveedores.nombre as 'Proveedor' from entradas join proveedores on entradas.idproveedor = proveedores.idproveedor where entradas.estado = 'Normal'", dataGridView2);
                    }
                    else if (radioButton1.Checked)
                    {
                        conexion.CargarDataGridView("select entradas.identrada as 'No. Entrada', entradas.conduce as 'Conduce', entradas.fecha as 'Fecha', entradas.cant_total as 'Cantidad Arts.', " +
                        "proveedores.nombre as 'Proveedor' from entradas join proveedores on entradas.idproveedor = proveedores.idproveedor where entradas.identrada = "+txtBusqueda.Text+ " and entradas.estado = 'Normal'", dataGridView2);
                    }
                    else if (radioButton2.Checked)
                    {
                        conexion.CargarDataGridView("select entradas.identrada as 'No. Entrada', entradas.conduce as 'Conduce', entradas.fecha as 'Fecha', entradas.cant_total as 'Cantidad Arts.', " +
                        "proveedores.nombre as 'Proveedor' from entradas join proveedores on entradas.idproveedor = proveedores.idproveedor where proveedores.nombre like '%" + txtBusqueda.Text + "%' and entradas.estado = 'Normal'", dataGridView2);

                    }
                    else if (radioButton3.Checked)
                    {
                        conexion.CargarDataGridView("select entradas.identrada as 'No. Entrada', entradas.conduce as 'Conduce', entradas.fecha as 'Fecha', entradas.cant_total as 'Cantidad Arts.', " +
                        "proveedores.nombre as 'Proveedor' from entradas join proveedores on entradas.idproveedor = proveedores.idproveedor join usuarios on usuarios.idusuarios = entradas.idusuarios "+ 
                        "where usuarios.nm_user like '%" + txtBusqueda.Text + "%' and entradas.estado = 'Normal'", dataGridView2);

                    }
                    else if (radioButton4.Checked)
                    {
                        conexion.CargarDataGridView("select entradas.identrada as 'No. Entrada', entradas.conduce as 'Conduce', entradas.fecha as 'Fecha', entradas.cant_total as 'Cantidad Arts.', " +
                        "proveedores.nombre as 'Proveedor' from entradas join proveedores on entradas.idproveedor = proveedores.idproveedor where entradas.fecha = Convert(char(19),'" + dateTimePicker1.Value.ToShortDateString() + "') and entradas.estado = 'Normal'", dataGridView2);

                    }
                    else
                    {
                        conexion.CargarDataGridView("select entradas.identrada as 'No. Entrada', entradas.conduce as 'Conduce', entradas.fecha as 'Fecha', entradas.cant_total as 'Cantidad Arts.', " +
                        "proveedores.nombre as 'Proveedor' from entradas join proveedores on entradas.idproveedor = proveedores.idproveedor and entradas.estado = 'Normal'", dataGridView2);
                    }
                    break;

                case "Proveedores":
                    if (txtBusqueda.Text == string.Empty)
                    {
                        conexion.CargarDataGridView("select idproveedor as 'ID', nombre as 'Nombre', rnc as 'RNC', Tel1 as 'Telefono 1' " +
                        "from proveedores", dataGridView2);
                    }
                    else if (radioButton1.Checked)
                    {
                        conexion.CargarDataGridView("select idproveedor as 'ID', nombre as 'Nombre', rnc as 'RNC', Tel1 as 'Telefono 1' " +
                        "from proveedores where rnc like '%"+txtBusqueda.Text+"%'", dataGridView2);
                    }
                    else if (radioButton2.Checked)
                    {
                        conexion.CargarDataGridView("select idproveedor as 'ID', nombre as 'Nombre', rnc as 'RNC', Tel1 as 'Telefono 1' " +
                        "from proveedores where nombre like '%" + txtBusqueda.Text + "%'", dataGridView2);

                    }
                    else if (radioButton3.Checked)
                    {
                        conexion.CargarDataGridView("select idproveedor as 'ID', nombre as 'Nombre', rnc as 'RNC', Tel1 as 'Telefono 1' " +
                        "from proveedores where direccion like '%" + txtBusqueda.Text + "%'", dataGridView2);

                    }
                    else
                    {
                        conexion.CargarDataGridView("select idproveedor as 'ID', nombre as 'Nombre', rnc as 'RNC', Tel1 as 'Telefono 1' " +
                        "from proveedores", dataGridView2);
                    }
                    break;

                case "Salidas":
                    if (txtBusqueda.Text == string.Empty)
                    {
                        conexion.CargarDataGridView("select salidas.idsalida as 'No. Salida', departamentos.nombredepto as 'Departamento', salidas.fecha as 'Fecha'," +
                        "cant_total as 'Cantidad Total', usuarios.nm_user as 'Usuario' from salidas join departamentos on salidas.iddepartamento = departamentos.iddepartamento join "
                        +"usuarios on salidas.idusuario = usuarios.idusuario and salidas.estado = 'Normal'", dataGridView2);
                    }
                    else if (radioButton1.Checked)
                    {
                        conexion.CargarDataGridView("select salidas.idsalida as 'No. Salida', departamentos.nombredepto as 'Departamento', salidas.fecha as 'Fecha'," +
                        "cant_total as 'Cantidad Total', usuarios.nm_user as 'Usuario' from salidas join departamentos on salidas.iddepartamento = departamentos.iddepartamento join "
                        + "usuarios on salidas.idusuario = usuarios.idusuario where salidas.idsalida like '%"+txtBusqueda.Text+ "%'  and salidas.estado = 'Normal'", dataGridView2);
                    }
                    else if (radioButton2.Checked)
                    {
                        conexion.CargarDataGridView("select salidas.idsalida as 'No. Salida', departamentos.nombredepto as 'Departamento', salidas.fecha as 'Fecha'," +
                        "cant_total as 'Cantidad Total', usuarios.nm_user as 'Usuario' from salidas join departamentos on salidas.iddepartamento = departamentos.iddepartamento join "
                        + "usuarios on salidas.idusuario = usuarios.idusuario where usuarios.nm_user like '%"+txtBusqueda.Text+ "%'  and salidas.estado = 'Normal'", dataGridView2);

                    }
                    else if (radioButton3.Checked)
                    {
                        conexion.CargarDataGridView("select salidas.idsalida as 'No. Salida', departamentos.nombredepto as 'Departamento', salidas.fecha as 'Fecha'," +
                        "cant_total as 'Cantidad Total', usuarios.nm_user as 'Usuario' from salidas join departamentos on salidas.iddepartamento = departamentos.iddepartamento join "
                        + "usuarios on salidas.idusuario = usuarios.idusuario where salidas.fecha = '" + dateTimePicker1.Value.ToShortDateString() + "'  and salidas.estado = 'Normal'", dataGridView2);

                    }
                    else
                    {
                        conexion.CargarDataGridView("select salidas.idsalida as 'No. Salida', departamentos.nombredepto as 'Departamento', salidas.fecha as 'Fecha'," +
                        "cant_total as 'Cantidad Total', usuarios.nm_user as 'Usuario' from salidas join departamentos on salidas.iddepartamento = departamentos.iddepartamento join "
                        + "usuarios on salidas.idusuario = usuarios.idusuario  and salidas.estado = 'Normal'", dataGridView2);
                    }
                    break;

                case "Usuarios":
                    if (txtBusqueda.Text == string.Empty)
                    {
                        conexion.CargarDataGridView("select usuarios.idusuario as 'ID', usuarios.nm_user as 'Usuario', empleados.nombre + ' ' + empleados.apellido as 'Empleado'from usuarios " + 
                            "join empleados on usuarios.idempleado = empleados.idempleado", dataGridView2);
                    }
                    else if (radioButton1.Checked)
                    {
                        conexion.CargarDataGridView("select usuarios.idusuario as 'ID', usuarios.nm_user as 'Usuario', empleados.nombre + ' ' + empleados.apellido as 'Empleado' from usuarios" +
                            " join empleados on usuarios.idempleado = empleados.idempleado where usuarios.nm_user like '%"+txtBusqueda.Text+"%'", dataGridView2);
                    }
                    else
                    {
                        conexion.CargarDataGridView("select usuarios.idusuario as 'ID', usuarios.nm_user as 'Usuario', empleados.nombre + ' ' + empleados.apellido as 'Empleado'from usuarios" +
                            "join empleados on usuarios.idempleado = empleados.idempleado", dataGridView2);
                    }
                    break;

                case "Devolucion Entrada":
                    if (txtBusqueda.Text == string.Empty)
                    {
                        conexion.CargarDataGridView("select devolucion_entrada.iddevolucionentrada 'No. Devolucion Entrada', devolucion_entrada.numentrada as 'No. Entrada', " +
                        "devolucion_entrada.fecha as 'Fecha', entradas.cant_total as 'Cantidad Total', usuarios.nm_user as 'Usuario' from devolucion_entrada" +
                        " join entradas on entradas.identrada = devolucion_entrada.numentrada join usuarios on devolucion_entrada.idusuario = usuarios.idusuario", dataGridView2);
                    }
                    else if (radioButton1.Checked)
                    {
                        conexion.CargarDataGridView("select devolucion_entrada.iddevolucionentrada 'No. Devolucion Entrada', devolucion_entrada.numentrada as 'No. Entrada', " +
                        "devolucion_entrada.fecha as 'Fecha', entradas.cant_total as 'Cantidad Total', usuarios.nm_user as 'Usuario' from devolucion_entrada" +
                        " join entradas on entradas.identrada = devolucion_entrada.numentrada join usuarios on devolucion_entrada.idusuario = usuarios.idusuario" + 
                        " where Devolucion_entrada.iddevolucionentrada like '%"+txtBusqueda.Text+"%'", dataGridView2);
                    }
                    else if (radioButton2.Checked)
                    {
                        conexion.CargarDataGridView("select devolucion_entrada.iddevolucionentrada 'No. Devolucion Entrada', devolucion_entrada.numentrada as 'No. Entrada', " +
                        "devolucion_entrada.fecha as 'Fecha', entradas.cant_total as 'Cantidad Total', usuarios.nm_user as 'Usuario' from devolucion_entrada" +
                        " join entradas on entradas.identrada = devolucion_entrada.numentrada join usuarios on devolucion_entrada.idusuario = usuarios.idusuario" +
                        " where usuarios.nm_user like '%" + txtBusqueda.Text + "%'", dataGridView2);

                    }
                    else if (radioButton3.Checked)
                    {
                        conexion.CargarDataGridView("select devolucion_entrada.iddevolucionentrada 'No. Devolucion Entrada', devolucion_entrada.numentrada as 'No. Entrada', " +
                        "devolucion_entrada.fecha as 'Fecha', entradas.cant_total as 'Cantidad Total', usuarios.nm_user as 'Usuario' from devolucion_entrada" +
                        " join entradas on entradas.identrada = devolucion_entrada.numentrada join usuarios on devolucion_entrada.idusuario = usuarios.idusuario" +
                        " where Devolucion_entrada.fecha = '" + dateTimePicker1.Value.ToShortDateString() + "'", dataGridView2);

                    }
                    else
                    {
                        conexion.CargarDataGridView("select devolucion_entrada.iddevolucionentrada 'No. Devolucion Entrada', devolucion_entrada.numentrada as 'No. Entrada', " +
                        "devolucion_entrada.fecha as 'Fecha', entradas.cant_total as 'Cantidad Total', usuarios.nm_user as 'Usuario' from devolucion_entrada" +
                        " join entradas on entradas.identrada = devolucion_entrada.numentrada join usuarios on devolucion_entrada.idusuario = usuarios.idusuario", dataGridView2);
                    }
                    break;

                case "Devolucion Salida":
                    if (txtBusqueda.Text == string.Empty)
                    {
                        conexion.CargarDataGridView("select devolucion_salida.iddevolucionsalida 'No. Devolucion Salida', salidas.idsalida as 'No. Salida', " +
                        "devolucion_salida.fecha as 'Fecha', salidas.cant_total as 'Cantidad Total', usuarios.nm_user as 'Usuario' from devolucion_salida" +
                        " join salidas on salidas.idsalida = devolucion_salida.numsalida join usuarios on devolucion_salida.idusuario = usuarios.idusuario", dataGridView2);
                    }
                    else if (radioButton1.Checked)
                    {
                        conexion.CargarDataGridView("select devolucion_salida.iddevolucionsalida 'No. Devolucion Salida', Devolucion_salida.numsalida as 'No. Salida', " +
                        "devolucion_salida.fecha as 'Fecha', salidas.cant_total as 'Cantidad Total', usuarios.nm_user as 'Usuario' from devolucion_salida" +
                        " join salidas on salidas.idsalida = devolucion_salida.numsalida join usuarios on devolucion_salida.idusuario = usuarios.idusuario" +
                        " where devolucion_salida.iddevolucionsalida like '%" + txtBusqueda.Text + "%'", dataGridView2);
                    }
                    else if (radioButton2.Checked)
                    {
                        conexion.CargarDataGridView("select devolucion_salida.iddevolucionsalida 'No. Devolucion Salida', Devolucion_salida.numsalida as 'No. Salida', " +
                        "devolucion_salida.fecha as 'Fecha', salidas.cant_total as 'Cantidad Total', usuarios.nm_user as 'Usuario' from devolucion_salida" +
                        " join salidas on salidas.idsalida = devolucion_salida.numsalida join usuarios on devolucion_salida.idusuario = usuarios.idusuario" +
                        " where usuarios.nm_user like '%" + txtBusqueda.Text + "%'", dataGridView2);

                    }
                    else if (radioButton3.Checked)
                    {
                        conexion.CargarDataGridView("select devolucion_salida.iddevolucionsalida 'No. Devolucion Salida', Devolucion_salida.numsalida as 'No. Salida', " +
                        "devolucion_salida.fecha as 'Fecha', salidas.cant_total as 'Cantidad Total', usuarios.nm_user as 'Usuario' from devolucion_salida" +
                        " join salidas on salidas.idsalida = devolucion_salida.numsalida join usuarios on devolucion_salida.idusuario = usuarios.idusuario" +
                        " where devolucion_salida.fecha = '" + dateTimePicker1.Value.ToShortDateString() + "'", dataGridView2);

                    }
                    else
                    {
                        conexion.CargarDataGridView("select devolucion_salida.iddevolucionsalida 'No. Devolucion Salida', salidas.idsalida as 'No. Salida', " +
                        "devolucion_salida.fecha as 'Fecha', salidas.cant_total as 'Cantidad Total', usuarios.nm_user as 'Usuario' from devolucion_salida" +
                        " join salidas on salidas.idsalida = devolucion_salida.numsalida join usuarios on devolucion_salida.idusuario = usuarios.idusuario", dataGridView2);
                    }
                    break;
            }
        }

        private void VerEntidad(string entidad, bool Editar)
        {
            switch (entidad)
            {
                case "Articulos":
                    Articulo VerArticulo = new Articulo(id, Editar);
                    VerArticulo.Show();
                    break;

                case "Departamentos":
                    Departamento VerDepto = new Departamento(id, Editar);
                    VerDepto.Show();
                    break;
               case "Empleados":
                    Empleado VerEmpleado = new Empleado(id, Editar);
                    VerEmpleado.Show();
                    break;

                case "Entradas":
                    Entrada VerEntrada = new Entrada(id, false);
                    VerEntrada.Show();
                    break;

                    
                case "Salidas":
                    Salidacs VerSalida = new Salidacs(id, false);
                    VerSalida.Show();
                    break;

                
                case "Devolucion Entrada":
                    DevolucionEntrada VerDevEntrada = new DevolucionEntrada(id, false);
                    VerDevEntrada.Show();
                    break;

                case "Devolucion Salida":
                    DevolucionSalida VerDevSalida = new DevolucionSalida(id, false);
                    VerDevSalida.Show();
                    break;
              

                case "Proveedores":
                    Proveedor proveedor = new Proveedor(id, Editar);
                    proveedor.Show();
                    break;

                case "Usuarios":
                    Usuarios usuario = new Usuarios(id, Editar);
                    usuario.Show();
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            EjecutarConsultaClasificada();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked && radioButton3.Text == "Fecha")
            {
                dateTimePicker1.Visible = true;
                txtBusqueda.Enabled = false;
            }
            else if (!radioButton3.Checked && radioButton3.Text == "Fecha")
            {
                dateTimePicker1.Visible = false;
                txtBusqueda.Enabled = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked && radioButton4.Text == "Fecha")
            {
                dateTimePicker1.Visible = true;
                txtBusqueda.Enabled = false;
            }
            else if (!radioButton4.Checked && radioButton4.Text == "Fecha")
            {
                dateTimePicker1.Visible = false;
                txtBusqueda.Enabled = true;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lblEntidad.Text == "Entradas" || lblEntidad.Text == "Salidas" || lblEntidad.Text == "Devolucion Salida" || lblEntidad.Text == "Devolucion Entrada")
            {
                id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                btnVer.Visible = true;
            }
            else if (lblEntidad.Text != "Stock")
            {
                id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                btnEditar.Visible = true;
                btnVer.Visible = true;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            VerEntidad(lblEntidad.Text, false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            VerEntidad(lblEntidad.Text, true);
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (lblEntidad.Text == "Entradas" || lblEntidad.Text == "Salidas" || lblEntidad.Text == "Devolucion Salida" || lblEntidad.Text == "Devolucion Entrada")
            {
                id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                btnVer.Visible = true;
            }
            else if (lblEntidad.Text != "Stock")
            {
                id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                btnEditar.Visible = true;
                btnVer.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioConsultas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.ControlDeDatos.MinimizarVentana(this);
        }
    }
}
