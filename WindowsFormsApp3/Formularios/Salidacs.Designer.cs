namespace WindowsFormsApp3
{
    partial class Salidacs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdSalida = new System.Windows.Forms.TextBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.txtIDDepto = new System.Windows.Forms.TextBox();
            this.txtSupervisor = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnagregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarDepto = new System.Windows.Forms.Button();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.lblIDDepto = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblsupervisor = new System.Windows.Forms.Label();
            this.lbldepartamento = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblnoarticulo = new System.Windows.Forms.Label();
            this.txtnoarticulo = new System.Windows.Forms.TextBox();
            this.lbltotalarticulo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.txtIdSalida);
            this.panel1.Controls.Add(this.lblSalida);
            this.panel1.Controls.Add(this.txtIDDepto);
            this.panel1.Controls.Add(this.txtSupervisor);
            this.panel1.Controls.Add(this.txtDepartamento);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnBuscarDepto);
            this.panel1.Controls.Add(this.btnBuscarArticulo);
            this.panel1.Controls.Add(this.lblIDDepto);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.lbldescripcion);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.lblcantidad);
            this.panel1.Controls.Add(this.lblsupervisor);
            this.panel1.Controls.Add(this.lbldepartamento);
            this.panel1.Controls.Add(this.lblContador);
            this.panel1.Controls.Add(this.lblnoarticulo);
            this.panel1.Controls.Add(this.txtnoarticulo);
            this.panel1.Controls.Add(this.lbltotalarticulo);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 523);
            this.panel1.TabIndex = 5;
            // 
            // txtIdSalida
            // 
            this.txtIdSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdSalida.Enabled = false;
            this.txtIdSalida.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtIdSalida.Location = new System.Drawing.Point(102, 100);
            this.txtIdSalida.Name = "txtIdSalida";
            this.txtIdSalida.Size = new System.Drawing.Size(60, 20);
            this.txtIdSalida.TabIndex = 82;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblSalida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalida.Location = new System.Drawing.Point(20, 98);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(83, 23);
            this.lblSalida.TabIndex = 81;
            this.lblSalida.Text = "ID Salida:";
            // 
            // txtIDDepto
            // 
            this.txtIDDepto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDDepto.Enabled = false;
            this.txtIDDepto.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtIDDepto.Location = new System.Drawing.Point(249, 101);
            this.txtIDDepto.Name = "txtIDDepto";
            this.txtIDDepto.Size = new System.Drawing.Size(60, 20);
            this.txtIDDepto.TabIndex = 51;
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupervisor.Enabled = false;
            this.txtSupervisor.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtSupervisor.Location = new System.Drawing.Point(721, 99);
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.Size = new System.Drawing.Size(137, 20);
            this.txtSupervisor.TabIndex = 17;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtDepartamento.Location = new System.Drawing.Point(438, 100);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(119, 20);
            this.txtDepartamento.TabIndex = 13;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDArticulo,
            this.Articulo,
            this.Cantidad});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(18, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(840, 306);
            this.dataGridView1.TabIndex = 80;
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
            // btnagregar
            // 
            this.btnagregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnagregar.BackColor = System.Drawing.Color.White;
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.FlatAppearance.BorderSize = 0;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnagregar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnagregar.Location = new System.Drawing.Point(707, 125);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(151, 39);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(1, -9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 93);
            this.panel2.TabIndex = 52;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Salida de Articulos";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(884, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(92, 24);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Visible = false;
            // 
            // btnBuscarDepto
            // 
            this.btnBuscarDepto.BackColor = System.Drawing.Color.DimGray;
            this.btnBuscarDepto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarDepto.FlatAppearance.BorderSize = 0;
            this.btnBuscarDepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDepto.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDepto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarDepto.Location = new System.Drawing.Point(559, 98);
            this.btnBuscarDepto.Name = "btnBuscarDepto";
            this.btnBuscarDepto.Size = new System.Drawing.Size(58, 23);
            this.btnBuscarDepto.TabIndex = 1;
            this.btnBuscarDepto.Text = "Buscar";
            this.btnBuscarDepto.UseVisualStyleBackColor = false;
            this.btnBuscarDepto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.BackColor = System.Drawing.Color.DimGray;
            this.btnBuscarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarArticulo.FlatAppearance.BorderSize = 0;
            this.btnBuscarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarArticulo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarArticulo.ForeColor = System.Drawing.Color.White;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(228, 136);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(58, 23);
            this.btnBuscarArticulo.TabIndex = 2;
            this.btnBuscarArticulo.Text = "Buscar";
            this.btnBuscarArticulo.UseVisualStyleBackColor = false;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblIDDepto
            // 
            this.lblIDDepto.AutoSize = true;
            this.lblIDDepto.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblIDDepto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIDDepto.Location = new System.Drawing.Point(166, 98);
            this.lblIDDepto.Name = "lblIDDepto";
            this.lblIDDepto.Size = new System.Drawing.Size(85, 23);
            this.lblIDDepto.TabIndex = 36;
            this.lblIDDepto.Text = "ID Depto:";
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
            this.btnLimpiar.Location = new System.Drawing.Point(884, 248);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 59);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
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
            this.btnNuevo.Location = new System.Drawing.Point(884, 167);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 59);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(884, 410);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 59);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(884, 329);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 59);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbldescripcion.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lbldescripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldescripcion.Location = new System.Drawing.Point(288, 133);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(108, 23);
            this.lbldescripcion.TabIndex = 21;
            this.lbldescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtDescripcion.Location = new System.Drawing.Point(398, 136);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(139, 20);
            this.txtDescripcion.TabIndex = 20;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtCantidad.Location = new System.Drawing.Point(628, 135);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(76, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblcantidad.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblcantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcantidad.Location = new System.Drawing.Point(545, 133);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(84, 23);
            this.lblcantidad.TabIndex = 18;
            this.lblcantidad.Text = "Cantidad:";
            // 
            // lblsupervisor
            // 
            this.lblsupervisor.AutoSize = true;
            this.lblsupervisor.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblsupervisor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsupervisor.Location = new System.Drawing.Point(623, 96);
            this.lblsupervisor.Name = "lblsupervisor";
            this.lblsupervisor.Size = new System.Drawing.Size(100, 23);
            this.lblsupervisor.TabIndex = 16;
            this.lblsupervisor.Text = "Supervisor:";
            // 
            // lbldepartamento
            // 
            this.lbldepartamento.AutoSize = true;
            this.lbldepartamento.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lbldepartamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldepartamento.Location = new System.Drawing.Point(311, 97);
            this.lbldepartamento.Name = "lbldepartamento";
            this.lbldepartamento.Size = new System.Drawing.Size(131, 23);
            this.lbldepartamento.TabIndex = 12;
            this.lbldepartamento.Text = "Departamento:";
            // 
            // lblContador
            // 
            this.lblContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblContador.AutoSize = true;
            this.lblContador.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblContador.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.Color.Red;
            this.lblContador.Location = new System.Drawing.Point(135, 484);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(83, 23);
            this.lblContador.TabIndex = 11;
            this.lblContador.Text = "Contador";
            // 
            // lblnoarticulo
            // 
            this.lblnoarticulo.AutoSize = true;
            this.lblnoarticulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblnoarticulo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblnoarticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnoarticulo.Location = new System.Drawing.Point(18, 135);
            this.lblnoarticulo.Name = "lblnoarticulo";
            this.lblnoarticulo.Size = new System.Drawing.Size(110, 23);
            this.lblnoarticulo.TabIndex = 2;
            this.lblnoarticulo.Text = "No. Articulo:";
            // 
            // txtnoarticulo
            // 
            this.txtnoarticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnoarticulo.Enabled = false;
            this.txtnoarticulo.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtnoarticulo.Location = new System.Drawing.Point(124, 138);
            this.txtnoarticulo.Name = "txtnoarticulo";
            this.txtnoarticulo.Size = new System.Drawing.Size(103, 20);
            this.txtnoarticulo.TabIndex = 9;
            // 
            // lbltotalarticulo
            // 
            this.lbltotalarticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalarticulo.AutoSize = true;
            this.lbltotalarticulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalarticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltotalarticulo.Location = new System.Drawing.Point(17, 484);
            this.lbltotalarticulo.Name = "lbltotalarticulo";
            this.lbltotalarticulo.Size = new System.Drawing.Size(53, 23);
            this.lbltotalarticulo.TabIndex = 1;
            this.lbltotalarticulo.Text = "Total:";
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
            this.button2.Location = new System.Drawing.Point(880, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 25);
            this.button2.TabIndex = 16;
            this.button2.Text = "__";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(935, 20);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 25);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Salidacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 520);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salidacs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salidacs";
            this.Load += new System.EventHandler(this.Salidacs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label lbldepartamento;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblnoarticulo;
        private System.Windows.Forms.TextBox txtnoarticulo;
        private System.Windows.Forms.Label lbltotalarticulo;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtSupervisor;
        private System.Windows.Forms.Label lblsupervisor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblIDDepto;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.TextBox txtIDDepto;
        private System.Windows.Forms.Button btnBuscarDepto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.TextBox txtIdSalida;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCerrar;
    }
}