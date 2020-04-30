namespace WindowsFormsApp3
{
    partial class Empleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.richtxtDireccion = new System.Windows.Forms.RichTextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.radiomasculino = new System.Windows.Forms.RadioButton();
            this.radiofemenino = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 92);
            this.panel2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.txtidempleado);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnActualizar);
            this.panel3.Controls.Add(this.txtcargo);
            this.panel3.Controls.Add(this.lblCargo);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Controls.Add(this.lblTelefono);
            this.panel3.Controls.Add(this.richtxtDireccion);
            this.panel3.Controls.Add(this.lblDireccion);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.radiomasculino);
            this.panel3.Controls.Add(this.radiofemenino);
            this.panel3.Controls.Add(this.btnLimpiar);
            this.panel3.Controls.Add(this.btnNuevo);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Controls.Add(this.lblCedula);
            this.panel3.Controls.Add(this.lblSexo);
            this.panel3.Controls.Add(this.txtapellido);
            this.panel3.Controls.Add(this.lblApellido);
            this.panel3.Controls.Add(this.txtcedula);
            this.panel3.Controls.Add(this.txtnombre);
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Location = new System.Drawing.Point(-2, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 369);
            this.panel3.TabIndex = 31;
            // 
            // txtidempleado
            // 
            this.txtidempleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidempleado.Enabled = false;
            this.txtidempleado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidempleado.Location = new System.Drawing.Point(147, 18);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Size = new System.Drawing.Size(123, 20);
            this.txtidempleado.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 78;
            this.label2.Text = "ID Empleado:";
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
            this.btnActualizar.Location = new System.Drawing.Point(607, 253);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 46);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Guardar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtcargo
            // 
            this.txtcargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcargo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcargo.Location = new System.Drawing.Point(115, 213);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(156, 20);
            this.txtcargo.TabIndex = 7;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCargo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCargo.Location = new System.Drawing.Point(34, 210);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(60, 23);
            this.lblCargo.TabIndex = 68;
            this.lblCargo.Text = "Cargo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(116, 154);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(156, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTelefono.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelefono.Location = new System.Drawing.Point(34, 151);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(83, 23);
            this.lblTelefono.TabIndex = 66;
            this.lblTelefono.Text = "Telefono:";
            this.lblTelefono.Click += new System.EventHandler(this.lblTelefono_Click);
            // 
            // richtxtDireccion
            // 
            this.richtxtDireccion.Font = new System.Drawing.Font("Calibri", 12F);
            this.richtxtDireccion.Location = new System.Drawing.Point(410, 155);
            this.richtxtDireccion.Name = "richtxtDireccion";
            this.richtxtDireccion.Size = new System.Drawing.Size(235, 78);
            this.richtxtDireccion.TabIndex = 9;
            this.richtxtDireccion.Text = "";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblDireccion.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDireccion.Location = new System.Drawing.Point(320, 151);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(90, 23);
            this.lblDireccion.TabIndex = 64;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(115, 270);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // radiomasculino
            // 
            this.radiomasculino.AutoSize = true;
            this.radiomasculino.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiomasculino.ForeColor = System.Drawing.Color.White;
            this.radiomasculino.Location = new System.Drawing.Point(226, 98);
            this.radiomasculino.Name = "radiomasculino";
            this.radiomasculino.Size = new System.Drawing.Size(45, 27);
            this.radiomasculino.TabIndex = 4;
            this.radiomasculino.TabStop = true;
            this.radiomasculino.Text = "M";
            this.radiomasculino.UseVisualStyleBackColor = true;
            // 
            // radiofemenino
            // 
            this.radiofemenino.AutoSize = true;
            this.radiofemenino.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiofemenino.ForeColor = System.Drawing.Color.White;
            this.radiofemenino.Location = new System.Drawing.Point(115, 98);
            this.radiofemenino.Name = "radiofemenino";
            this.radiofemenino.Size = new System.Drawing.Size(37, 27);
            this.radiofemenino.TabIndex = 3;
            this.radiofemenino.TabStop = true;
            this.radiofemenino.Text = "F";
            this.radiofemenino.UseVisualStyleBackColor = true;
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
            this.btnLimpiar.Location = new System.Drawing.Point(392, 309);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 46);
            this.btnLimpiar.TabIndex = 13;
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
            this.btnNuevo.Location = new System.Drawing.Point(284, 310);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 46);
            this.btnNuevo.TabIndex = 12;
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
            this.btnCancelar.Location = new System.Drawing.Point(607, 308);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 46);
            this.btnCancelar.TabIndex = 14;
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
            this.btnGuardar.Location = new System.Drawing.Point(500, 309);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 46);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(34, 270);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 23);
            this.lblEmail.TabIndex = 52;
            this.lblEmail.Text = "Email:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCedula.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblCedula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCedula.Location = new System.Drawing.Point(322, 104);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(69, 23);
            this.lblCedula.TabIndex = 51;
            this.lblCedula.Text = "Cedula:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSexo.Location = new System.Drawing.Point(34, 100);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(53, 23);
            this.lblSexo.TabIndex = 49;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtapellido
            // 
            this.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapellido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(410, 60);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(140, 20);
            this.txtapellido.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblApellido.Location = new System.Drawing.Point(322, 57);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(82, 23);
            this.lblApellido.TabIndex = 49;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtcedula
            // 
            this.txtcedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcedula.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcedula.Location = new System.Drawing.Point(410, 104);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(140, 20);
            this.txtcedula.TabIndex = 5;
            // 
            // txtnombre
            // 
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(116, 60);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(155, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(34, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 23);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre:";
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
            this.button2.Location = new System.Drawing.Point(602, 15);
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
            this.btnCerrar.Location = new System.Drawing.Point(657, 15);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 25);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.RichTextBox richtxtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton radiomasculino;
        private System.Windows.Forms.RadioButton radiofemenino;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtidempleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCerrar;
    }
}