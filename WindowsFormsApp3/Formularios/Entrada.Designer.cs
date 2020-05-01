namespace WindowsFormsApp3
{
    partial class Entrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltotalarticulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtproveedor = new System.Windows.Forms.TextBox();
            this.txtIdEntrada = new System.Windows.Forms.TextBox();
            this.lblIdEntrada = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbuscararticulo = new System.Windows.Forms.Button();
            this.btnbuscarProveedor = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtIDProveedor = new System.Windows.Forms.TextBox();
            this.lblidProveedor = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblconduce = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtconduce = new System.Windows.Forms.TextBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtNoArticulo = new System.Windows.Forms.TextBox();
            this.lblnoarticulo = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada de Articulos";
            // 
            // lbltotalarticulo
            // 
            this.lbltotalarticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalarticulo.AutoSize = true;
            this.lbltotalarticulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalarticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltotalarticulo.Location = new System.Drawing.Point(17, 485);
            this.lbltotalarticulo.Name = "lbltotalarticulo";
            this.lbltotalarticulo.Size = new System.Drawing.Size(53, 23);
            this.lbltotalarticulo.TabIndex = 1;
            this.lbltotalarticulo.Text = "Total:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.txtproveedor);
            this.panel1.Controls.Add(this.txtIdEntrada);
            this.panel1.Controls.Add(this.lblIdEntrada);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnbuscararticulo);
            this.panel1.Controls.Add(this.btnbuscarProveedor);
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Controls.Add(this.txtIDProveedor);
            this.panel1.Controls.Add(this.lblidProveedor);
            this.panel1.Controls.Add(this.txtcantidad);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.lblconduce);
            this.panel1.Controls.Add(this.lblcantidad);
            this.panel1.Controls.Add(this.txtconduce);
            this.panel1.Controls.Add(this.lbldescripcion);
            this.panel1.Controls.Add(this.txtNoArticulo);
            this.panel1.Controls.Add(this.lblnoarticulo);
            this.panel1.Controls.Add(this.lblProveedor);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btncancelar);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.lblContador);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbltotalarticulo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 523);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtproveedor
            // 
            this.txtproveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtproveedor.Enabled = false;
            this.txtproveedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproveedor.Location = new System.Drawing.Point(434, 98);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(168, 20);
            this.txtproveedor.TabIndex = 39;
            // 
            // txtIdEntrada
            // 
            this.txtIdEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdEntrada.Enabled = false;
            this.txtIdEntrada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEntrada.Location = new System.Drawing.Point(113, 100);
            this.txtIdEntrada.Name = "txtIdEntrada";
            this.txtIdEntrada.Size = new System.Drawing.Size(51, 20);
            this.txtIdEntrada.TabIndex = 80;
            // 
            // lblIdEntrada
            // 
            this.lblIdEntrada.AutoSize = true;
            this.lblIdEntrada.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblIdEntrada.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblIdEntrada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdEntrada.Location = new System.Drawing.Point(19, 97);
            this.lblIdEntrada.Name = "lblIdEntrada";
            this.lblIdEntrada.Size = new System.Drawing.Size(97, 23);
            this.lblIdEntrada.TabIndex = 79;
            this.lblIdEntrada.Text = "ID Entrada:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDArticulo,
            this.Articulo,
            this.Cantidad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(21, 169);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(840, 306);
            this.dataGridView1.TabIndex = 78;
            // 
            // IDArticulo
            // 
            this.IDArticulo.HeaderText = "ID Articulo";
            this.IDArticulo.Name = "IDArticulo";
            this.IDArticulo.ReadOnly = true;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // btnbuscararticulo
            // 
            this.btnbuscararticulo.BackColor = System.Drawing.Color.DimGray;
            this.btnbuscararticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscararticulo.FlatAppearance.BorderSize = 0;
            this.btnbuscararticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscararticulo.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnbuscararticulo.ForeColor = System.Drawing.Color.White;
            this.btnbuscararticulo.Location = new System.Drawing.Point(244, 132);
            this.btnbuscararticulo.Name = "btnbuscararticulo";
            this.btnbuscararticulo.Size = new System.Drawing.Size(75, 23);
            this.btnbuscararticulo.TabIndex = 3;
            this.btnbuscararticulo.Text = "Buscar";
            this.btnbuscararticulo.UseVisualStyleBackColor = false;
            this.btnbuscararticulo.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnbuscarProveedor
            // 
            this.btnbuscarProveedor.BackColor = System.Drawing.Color.DimGray;
            this.btnbuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarProveedor.FlatAppearance.BorderSize = 0;
            this.btnbuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarProveedor.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnbuscarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnbuscarProveedor.Location = new System.Drawing.Point(604, 95);
            this.btnbuscarProveedor.Name = "btnbuscarProveedor";
            this.btnbuscarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarProveedor.TabIndex = 1;
            this.btnbuscarProveedor.Text = "Buscar";
            this.btnbuscarProveedor.UseVisualStyleBackColor = false;
            this.btnbuscarProveedor.Click += new System.EventHandler(this.btnbuscarProveedor_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnagregar.BackColor = System.Drawing.Color.White;
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.FlatAppearance.BorderSize = 0;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnagregar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnagregar.Location = new System.Drawing.Point(756, 123);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(105, 39);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtIDProveedor
            // 
            this.txtIDProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDProveedor.Enabled = false;
            this.txtIDProveedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProveedor.Location = new System.Drawing.Point(284, 99);
            this.txtIDProveedor.Name = "txtIDProveedor";
            this.txtIDProveedor.Size = new System.Drawing.Size(51, 20);
            this.txtIDProveedor.TabIndex = 47;
            // 
            // lblidProveedor
            // 
            this.lblidProveedor.AutoSize = true;
            this.lblidProveedor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblidProveedor.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblidProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblidProveedor.Location = new System.Drawing.Point(167, 96);
            this.lblidProveedor.Name = "lblidProveedor";
            this.lblidProveedor.Size = new System.Drawing.Size(119, 23);
            this.lblidProveedor.TabIndex = 46;
            this.lblidProveedor.Text = "ID Proveedor:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcantidad.Enabled = false;
            this.txtcantidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(653, 134);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(97, 20);
            this.txtcantidad.TabIndex = 43;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(425, 135);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(139, 20);
            this.txtDescripcion.TabIndex = 44;
            // 
            // lblconduce
            // 
            this.lblconduce.AutoSize = true;
            this.lblconduce.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblconduce.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblconduce.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblconduce.Location = new System.Drawing.Point(680, 94);
            this.lblconduce.Name = "lblconduce";
            this.lblconduce.Size = new System.Drawing.Size(83, 23);
            this.lblconduce.TabIndex = 37;
            this.lblconduce.Text = "Conduce:";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblcantidad.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblcantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcantidad.Location = new System.Drawing.Point(568, 132);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(84, 23);
            this.lblcantidad.TabIndex = 42;
            this.lblcantidad.Text = "Cantidad:";
            // 
            // txtconduce
            // 
            this.txtconduce.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtconduce.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconduce.Location = new System.Drawing.Point(764, 96);
            this.txtconduce.Name = "txtconduce";
            this.txtconduce.Size = new System.Drawing.Size(97, 20);
            this.txtconduce.TabIndex = 2;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbldescripcion.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lbldescripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldescripcion.Location = new System.Drawing.Point(320, 133);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(108, 23);
            this.lbldescripcion.TabIndex = 45;
            this.lbldescripcion.Text = "Descripcion:";
            // 
            // txtNoArticulo
            // 
            this.txtNoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoArticulo.Enabled = false;
            this.txtNoArticulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoArticulo.Location = new System.Drawing.Point(139, 134);
            this.txtNoArticulo.Name = "txtNoArticulo";
            this.txtNoArticulo.Size = new System.Drawing.Size(103, 20);
            this.txtNoArticulo.TabIndex = 41;
            // 
            // lblnoarticulo
            // 
            this.lblnoarticulo.AutoSize = true;
            this.lblnoarticulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblnoarticulo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblnoarticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnoarticulo.Location = new System.Drawing.Point(21, 133);
            this.lblnoarticulo.Name = "lblnoarticulo";
            this.lblnoarticulo.Size = new System.Drawing.Size(110, 23);
            this.lblnoarticulo.TabIndex = 40;
            this.lblnoarticulo.Text = "No. Articulo:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblProveedor.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProveedor.Location = new System.Drawing.Point(337, 95);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(98, 23);
            this.lblProveedor.TabIndex = 38;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpiar.Location = new System.Drawing.Point(887, 252);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 59);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevo.Location = new System.Drawing.Point(887, 171);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 59);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackColor = System.Drawing.Color.Red;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(887, 414);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(93, 59);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(887, 333);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(93, 59);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // lblContador
            // 
            this.lblContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblContador.AutoSize = true;
            this.lblContador.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblContador.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.Color.Red;
            this.lblContador.Location = new System.Drawing.Point(126, 485);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(83, 23);
            this.lblContador.TabIndex = 11;
            this.lblContador.Text = "Contador";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(3, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 86);
            this.panel2.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(884, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(92, 24);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(881, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 25);
            this.button2.TabIndex = 16;
            this.button2.Text = "__";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(936, 13);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 25);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 520);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.Entrada_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltotalarticulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIDProveedor;
        private System.Windows.Forms.Label lblidProveedor;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblconduce;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtconduce;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox txtNoArticulo;
        private System.Windows.Forms.TextBox txtproveedor;
        private System.Windows.Forms.Label lblnoarticulo;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnbuscarProveedor;
        private System.Windows.Forms.Button btnbuscararticulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.TextBox txtIdEntrada;
        private System.Windows.Forms.Label lblIdEntrada;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCerrar;
    }
}