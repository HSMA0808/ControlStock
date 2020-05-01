namespace WindowsFormsApp3
{
    partial class Articulo
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblarticulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtnombrearticulo = new System.Windows.Forms.TextBox();
            this.lblnombreart = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.lblIdProveedor = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblproveedor = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtidarticulo = new System.Windows.Forms.TextBox();
            this.lblidarticulo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.lblarticulo);
            this.panel2.Location = new System.Drawing.Point(0, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 106);
            this.panel2.TabIndex = 31;
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
            this.button2.Location = new System.Drawing.Point(603, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 25);
            this.button2.TabIndex = 12;
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
            this.btnCerrar.Location = new System.Drawing.Point(658, 17);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 25);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblarticulo
            // 
            this.lblarticulo.AutoSize = true;
            this.lblarticulo.BackColor = System.Drawing.Color.Gray;
            this.lblarticulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblarticulo.Location = new System.Drawing.Point(13, 31);
            this.lblarticulo.Name = "lblarticulo";
            this.lblarticulo.Size = new System.Drawing.Size(104, 33);
            this.lblarticulo.TabIndex = 0;
            this.lblarticulo.Text = "Articulo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.btnActualizar);
            this.panel3.Controls.Add(this.btnbuscar);
            this.panel3.Controls.Add(this.txtnombrearticulo);
            this.panel3.Controls.Add(this.lblnombreart);
            this.panel3.Controls.Add(this.txtProveedor);
            this.panel3.Controls.Add(this.txtMarca);
            this.panel3.Controls.Add(this.lblMarca);
            this.panel3.Controls.Add(this.txtIdProveedor);
            this.panel3.Controls.Add(this.lblIdProveedor);
            this.panel3.Controls.Add(this.txtdescripcion);
            this.panel3.Controls.Add(this.lblDescripcion);
            this.panel3.Controls.Add(this.btnLimpiar);
            this.panel3.Controls.Add(this.btnNuevo);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.lblproveedor);
            this.panel3.Controls.Add(this.lblcantidad);
            this.panel3.Controls.Add(this.txtcantidad);
            this.panel3.Controls.Add(this.txtidarticulo);
            this.panel3.Controls.Add(this.lblidarticulo);
            this.panel3.Location = new System.Drawing.Point(-2, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 367);
            this.panel3.TabIndex = 32;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(605, 237);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 46);
            this.btnActualizar.TabIndex = 76;
            this.btnActualizar.Text = "Guardar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.DimGray;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnbuscar.Location = new System.Drawing.Point(424, 107);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtnombrearticulo
            // 
            this.txtnombrearticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombrearticulo.Enabled = false;
            this.txtnombrearticulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrearticulo.Location = new System.Drawing.Point(283, 50);
            this.txtnombrearticulo.Name = "txtnombrearticulo";
            this.txtnombrearticulo.Size = new System.Drawing.Size(140, 20);
            this.txtnombrearticulo.TabIndex = 1;
            // 
            // lblnombreart
            // 
            this.lblnombreart.AutoSize = true;
            this.lblnombreart.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblnombreart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnombreart.Location = new System.Drawing.Point(279, 24);
            this.lblnombreart.Name = "lblnombreart";
            this.lblnombreart.Size = new System.Drawing.Size(80, 23);
            this.lblnombreart.TabIndex = 71;
            this.lblnombreart.Text = "Nombre:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(283, 108);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(140, 20);
            this.txtProveedor.TabIndex = 70;
            // 
            // txtMarca
            // 
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(44, 168);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(123, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblMarca.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarca.Location = new System.Drawing.Point(38, 144);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(65, 23);
            this.lblMarca.TabIndex = 68;
            this.lblMarca.Text = "Marca:";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdProveedor.Enabled = false;
            this.txtIdProveedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProveedor.Location = new System.Drawing.Point(43, 111);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(87, 20);
            this.txtIdProveedor.TabIndex = 67;
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.AutoSize = true;
            this.lblIdProveedor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblIdProveedor.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblIdProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdProveedor.Location = new System.Drawing.Point(38, 87);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(119, 23);
            this.lblIdProveedor.TabIndex = 66;
            this.lblIdProveedor.Text = "ID Proveedor:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtdescripcion.Location = new System.Drawing.Point(283, 166);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(241, 96);
            this.txtdescripcion.TabIndex = 6;
            this.txtdescripcion.Text = "";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescripcion.Location = new System.Drawing.Point(279, 144);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(108, 23);
            this.lblDescripcion.TabIndex = 64;
            this.lblDescripcion.Text = "Descripcion:";
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
            this.btnLimpiar.Location = new System.Drawing.Point(391, 298);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 46);
            this.btnLimpiar.TabIndex = 9;
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
            this.btnNuevo.Location = new System.Drawing.Point(283, 299);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 46);
            this.btnNuevo.TabIndex = 8;
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
            this.btnCancelar.Location = new System.Drawing.Point(606, 297);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 46);
            this.btnCancelar.TabIndex = 10;
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
            this.btnGuardar.Location = new System.Drawing.Point(499, 298);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 46);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblproveedor
            // 
            this.lblproveedor.AutoSize = true;
            this.lblproveedor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblproveedor.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblproveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblproveedor.Location = new System.Drawing.Point(279, 87);
            this.lblproveedor.Name = "lblproveedor";
            this.lblproveedor.Size = new System.Drawing.Size(98, 23);
            this.lblproveedor.TabIndex = 51;
            this.lblproveedor.Text = "Proveedor:";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblcantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcantidad.Location = new System.Drawing.Point(38, 208);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(84, 23);
            this.lblcantidad.TabIndex = 49;
            this.lblcantidad.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcantidad.Enabled = false;
            this.txtcantidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(43, 235);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(125, 20);
            this.txtcantidad.TabIndex = 4;
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcontraseña_TextChanged);
            // 
            // txtidarticulo
            // 
            this.txtidarticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidarticulo.Enabled = false;
            this.txtidarticulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidarticulo.Location = new System.Drawing.Point(42, 53);
            this.txtidarticulo.Name = "txtidarticulo";
            this.txtidarticulo.Size = new System.Drawing.Size(90, 20);
            this.txtidarticulo.TabIndex = 46;
            // 
            // lblidarticulo
            // 
            this.lblidarticulo.AutoSize = true;
            this.lblidarticulo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblidarticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblidarticulo.Location = new System.Drawing.Point(38, 29);
            this.lblidarticulo.Name = "lblidarticulo";
            this.lblidarticulo.Size = new System.Drawing.Size(99, 23);
            this.lblidarticulo.TabIndex = 13;
            this.lblidarticulo.Text = "ID Articulo:";
            // 
            // Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Articulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.Articulo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblarticulo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Label lblIdProveedor;
        private System.Windows.Forms.RichTextBox txtdescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblproveedor;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtidarticulo;
        private System.Windows.Forms.Label lblidarticulo;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtnombrearticulo;
        private System.Windows.Forms.Label lblnombreart;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCerrar;
    }
}