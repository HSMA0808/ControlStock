namespace WindowsFormsApp3
{
    partial class MenuConsultas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDevEntrada = new System.Windows.Forms.Button();
            this.btnDevSalida = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnDepartamentos = new System.Windows.Forms.Button();
            this.lblStocker = new System.Windows.Forms.Label();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnDevEntrada);
            this.panel1.Controls.Add(this.btnDevSalida);
            this.panel1.Controls.Add(this.btnSalida);
            this.panel1.Controls.Add(this.btnEntrada);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnProveedores);
            this.panel1.Controls.Add(this.btnArticulos);
            this.panel1.Controls.Add(this.btnDepartamentos);
            this.panel1.Controls.Add(this.lblStocker);
            this.panel1.Controls.Add(this.btnEmpleados);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 399);
            this.panel1.TabIndex = 13;
            // 
            // btnDevEntrada
            // 
            this.btnDevEntrada.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDevEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevEntrada.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDevEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnDevEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevEntrada.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevEntrada.ForeColor = System.Drawing.Color.White;
            this.btnDevEntrada.Location = new System.Drawing.Point(387, 200);
            this.btnDevEntrada.Name = "btnDevEntrada";
            this.btnDevEntrada.Size = new System.Drawing.Size(250, 40);
            this.btnDevEntrada.TabIndex = 8;
            this.btnDevEntrada.Text = "Devolucion Entrada";
            this.btnDevEntrada.UseVisualStyleBackColor = false;
            this.btnDevEntrada.Click += new System.EventHandler(this.btnDevEntrada_Click);
            // 
            // btnDevSalida
            // 
            this.btnDevSalida.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDevSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevSalida.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDevSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnDevSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevSalida.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevSalida.ForeColor = System.Drawing.Color.White;
            this.btnDevSalida.Location = new System.Drawing.Point(387, 253);
            this.btnDevSalida.Name = "btnDevSalida";
            this.btnDevSalida.Size = new System.Drawing.Size(250, 40);
            this.btnDevSalida.TabIndex = 9;
            this.btnDevSalida.Text = "Devolucion Salida";
            this.btnDevSalida.UseVisualStyleBackColor = false;
            this.btnDevSalida.Click += new System.EventHandler(this.btnDevSalida_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalida.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalida.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.ForeColor = System.Drawing.Color.White;
            this.btnSalida.Location = new System.Drawing.Point(387, 147);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(250, 40);
            this.btnSalida.TabIndex = 7;
            this.btnSalida.Text = "Salidas";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrada.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.Color.White;
            this.btnEntrada.Location = new System.Drawing.Point(387, 94);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(250, 40);
            this.btnEntrada.TabIndex = 6;
            this.btnEntrada.Text = "Entradas";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(47, 308);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(250, 40);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Location = new System.Drawing.Point(46, 253);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(250, 40);
            this.btnProveedores.TabIndex = 4;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArticulos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.ForeColor = System.Drawing.Color.White;
            this.btnArticulos.Location = new System.Drawing.Point(47, 147);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(250, 40);
            this.btnArticulos.TabIndex = 2;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.UseVisualStyleBackColor = false;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnDepartamentos
            // 
            this.btnDepartamentos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDepartamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartamentos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDepartamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartamentos.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartamentos.ForeColor = System.Drawing.Color.White;
            this.btnDepartamentos.Location = new System.Drawing.Point(47, 200);
            this.btnDepartamentos.Name = "btnDepartamentos";
            this.btnDepartamentos.Size = new System.Drawing.Size(250, 40);
            this.btnDepartamentos.TabIndex = 3;
            this.btnDepartamentos.Text = "Departamentos";
            this.btnDepartamentos.UseVisualStyleBackColor = false;
            this.btnDepartamentos.Click += new System.EventHandler(this.btnDepartamentos_Click);
            // 
            // lblStocker
            // 
            this.lblStocker.AutoSize = true;
            this.lblStocker.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.lblStocker.ForeColor = System.Drawing.Color.White;
            this.lblStocker.Location = new System.Drawing.Point(281, 25);
            this.lblStocker.Name = "lblStocker";
            this.lblStocker.Size = new System.Drawing.Size(123, 33);
            this.lblStocker.TabIndex = 6;
            this.lblStocker.Text = "Consultas";
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Location = new System.Drawing.Point(47, 94);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(250, 40);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(630, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 25);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 396);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuConsultas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnUsuarios;
        public System.Windows.Forms.Button btnProveedores;
        public System.Windows.Forms.Button btnArticulos;
        public System.Windows.Forms.Button btnDepartamentos;
        public System.Windows.Forms.Label lblStocker;
        public System.Windows.Forms.Button btnEmpleados;
        public System.Windows.Forms.Button btnSalida;
        public System.Windows.Forms.Button btnEntrada;
        public System.Windows.Forms.Button btnDevEntrada;
        public System.Windows.Forms.Button btnDevSalida;
        private System.Windows.Forms.Button btnCerrar;
    }
}