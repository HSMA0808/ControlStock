namespace WindowsFormsApp3
{
    partial class DevolucionSalida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdDevSalida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNoSalida = new System.Windows.Forms.TextBox();
            this.lblNoSalida = new System.Windows.Forms.Label();
            this.txtSupervisor = new System.Windows.Forms.TextBox();
            this.lblsupervisor = new System.Windows.Forms.Label();
            this.txtdepartamento = new System.Windows.Forms.TextBox();
            this.lbldepartamento = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblIDDepto = new System.Windows.Forms.Label();
            this.txtIDDepto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idarticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotalarticulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.txtIdDevSalida);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtNoSalida);
            this.panel1.Controls.Add(this.lblNoSalida);
            this.panel1.Controls.Add(this.txtSupervisor);
            this.panel1.Controls.Add(this.lblsupervisor);
            this.panel1.Controls.Add(this.txtdepartamento);
            this.panel1.Controls.Add(this.lbldepartamento);
            this.panel1.Controls.Add(this.lblContador);
            this.panel1.Controls.Add(this.lblIDDepto);
            this.panel1.Controls.Add(this.txtIDDepto);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lbltotalarticulo);
            this.panel1.Location = new System.Drawing.Point(-4, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 529);
            this.panel1.TabIndex = 6;
            // 
            // txtIdDevSalida
            // 
            this.txtIdDevSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdDevSalida.Enabled = false;
            this.txtIdDevSalida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDevSalida.Location = new System.Drawing.Point(154, 105);
            this.txtIdDevSalida.Name = "txtIdDevSalida";
            this.txtIdDevSalida.Size = new System.Drawing.Size(86, 20);
            this.txtIdDevSalida.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 77;
            this.label2.Text = "No. Devolucion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(786, 195);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(201, 96);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Text = "";
            this.txtDescripcion.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescripcion.Location = new System.Drawing.Point(784, 169);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(108, 23);
            this.lblDescripcion.TabIndex = 75;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.DimGray;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(443, 102);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
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
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 86);
            this.panel2.TabIndex = 53;
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
            this.button2.Location = new System.Drawing.Point(879, 14);
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
            this.btnCerrar.Location = new System.Drawing.Point(934, 14);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 25);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Devolucion Salidas";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(874, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(92, 24);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpiar.Location = new System.Drawing.Point(893, 304);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 59);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevo.Location = new System.Drawing.Point(787, 304);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 59);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(893, 379);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 59);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(785, 379);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 59);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Devolver";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // txtNoSalida
            // 
            this.txtNoSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoSalida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoSalida.Location = new System.Drawing.Point(338, 105);
            this.txtNoSalida.Name = "txtNoSalida";
            this.txtNoSalida.Size = new System.Drawing.Size(104, 20);
            this.txtNoSalida.TabIndex = 1;
            // 
            // lblNoSalida
            // 
            this.lblNoSalida.AutoSize = true;
            this.lblNoSalida.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblNoSalida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNoSalida.Location = new System.Drawing.Point(246, 103);
            this.lblNoSalida.Name = "lblNoSalida";
            this.lblNoSalida.Size = new System.Drawing.Size(94, 23);
            this.lblNoSalida.TabIndex = 22;
            this.lblNoSalida.Text = "No. Salida:";
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupervisor.Enabled = false;
            this.txtSupervisor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupervisor.Location = new System.Drawing.Point(588, 139);
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.Size = new System.Drawing.Size(187, 20);
            this.txtSupervisor.TabIndex = 17;
            // 
            // lblsupervisor
            // 
            this.lblsupervisor.AutoSize = true;
            this.lblsupervisor.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblsupervisor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsupervisor.Location = new System.Drawing.Point(491, 137);
            this.lblsupervisor.Name = "lblsupervisor";
            this.lblsupervisor.Size = new System.Drawing.Size(100, 23);
            this.lblsupervisor.TabIndex = 16;
            this.lblsupervisor.Text = "Supervisor:";
            // 
            // txtdepartamento
            // 
            this.txtdepartamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdepartamento.Enabled = false;
            this.txtdepartamento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepartamento.Location = new System.Drawing.Point(294, 140);
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(187, 20);
            this.txtdepartamento.TabIndex = 13;
            // 
            // lbldepartamento
            // 
            this.lbldepartamento.AutoSize = true;
            this.lbldepartamento.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lbldepartamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldepartamento.Location = new System.Drawing.Point(167, 138);
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
            this.lblContador.Location = new System.Drawing.Point(133, 481);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(20, 23);
            this.lblContador.TabIndex = 11;
            this.lblContador.Text = "0";
            // 
            // lblIDDepto
            // 
            this.lblIDDepto.AutoSize = true;
            this.lblIDDepto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblIDDepto.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblIDDepto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIDDepto.Location = new System.Drawing.Point(20, 139);
            this.lblIDDepto.Name = "lblIDDepto";
            this.lblIDDepto.Size = new System.Drawing.Size(85, 23);
            this.lblIDDepto.TabIndex = 2;
            this.lblIDDepto.Text = "ID Depto:";
            // 
            // txtIDDepto
            // 
            this.txtIDDepto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDDepto.Enabled = false;
            this.txtIDDepto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDDepto.Location = new System.Drawing.Point(110, 141);
            this.txtIDDepto.Name = "txtIDDepto";
            this.txtIDDepto.Size = new System.Drawing.Size(48, 20);
            this.txtIDDepto.TabIndex = 9;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idarticulo,
            this.Articulo,
            this.cantidad});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(17, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(748, 292);
            this.dataGridView1.TabIndex = 7;
            // 
            // idarticulo
            // 
            this.idarticulo.HeaderText = "ID Articulo";
            this.idarticulo.Name = "idarticulo";
            this.idarticulo.ReadOnly = true;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // lbltotalarticulo
            // 
            this.lbltotalarticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalarticulo.AutoSize = true;
            this.lbltotalarticulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalarticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltotalarticulo.Location = new System.Drawing.Point(23, 482);
            this.lbltotalarticulo.Name = "lbltotalarticulo";
            this.lbltotalarticulo.Size = new System.Drawing.Size(53, 23);
            this.lbltotalarticulo.TabIndex = 1;
            this.lbltotalarticulo.Text = "Total:";
            // 
            // DevolucionSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 520);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DevolucionSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevolucionSalida";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSupervisor;
        private System.Windows.Forms.Label lblsupervisor;
        private System.Windows.Forms.TextBox txtdepartamento;
        private System.Windows.Forms.Label lbldepartamento;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbltotalarticulo;
        private System.Windows.Forms.TextBox txtNoSalida;
        private System.Windows.Forms.Label lblNoSalida;
        private System.Windows.Forms.Label lblIDDepto;
        private System.Windows.Forms.TextBox txtIDDepto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtIdDevSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idarticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
    }
}