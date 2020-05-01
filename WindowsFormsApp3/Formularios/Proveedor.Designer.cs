namespace WindowsFormsApp3
{
    partial class Proveedor
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblrnc = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.RichTextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtrnc = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lbltelefono1 = new System.Windows.Forms.Label();
            this.txttelefono2 = new System.Windows.Forms.TextBox();
            this.txttelefono1 = new System.Windows.Forms.TextBox();
            this.lbltelefono2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-4, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 461);
            this.panel1.TabIndex = 8;
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
            this.btnLimpiar.Location = new System.Drawing.Point(400, 388);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 46);
            this.btnLimpiar.TabIndex = 10;
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
            this.btnNuevo.Location = new System.Drawing.Point(292, 389);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 46);
            this.btnNuevo.TabIndex = 9;
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
            this.btnCancelar.Location = new System.Drawing.Point(614, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 46);
            this.btnCancelar.TabIndex = 11;
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
            this.btnGuardar.Location = new System.Drawing.Point(507, 387);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 46);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 100);
            this.panel2.TabIndex = 28;
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
            this.button2.Location = new System.Drawing.Point(603, 14);
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
            this.btnCerrar.Location = new System.Drawing.Point(658, 14);
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
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provedores";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtIdProveedor);
            this.panel3.Controls.Add(this.btnActualizar);
            this.panel3.Controls.Add(this.txtemail);
            this.panel3.Controls.Add(this.lblemail);
            this.panel3.Controls.Add(this.lblrnc);
            this.panel3.Controls.Add(this.txtnombre);
            this.panel3.Controls.Add(this.txtdireccion);
            this.panel3.Controls.Add(this.lblnombre);
            this.panel3.Controls.Add(this.txtrnc);
            this.panel3.Controls.Add(this.lbldireccion);
            this.panel3.Controls.Add(this.lbltelefono1);
            this.panel3.Controls.Add(this.txttelefono2);
            this.panel3.Controls.Add(this.txttelefono1);
            this.panel3.Controls.Add(this.lbltelefono2);
            this.panel3.Location = new System.Drawing.Point(0, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 360);
            this.panel3.TabIndex = 29;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(64, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 78;
            this.label2.Text = "ID Proveedor";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdProveedor.Enabled = false;
            this.txtIdProveedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProveedor.Location = new System.Drawing.Point(68, 53);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(140, 20);
            this.txtIdProveedor.TabIndex = 79;
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
            this.btnActualizar.Location = new System.Drawing.Point(614, 229);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 46);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Guardar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(366, 53);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(186, 20);
            this.txtemail.TabIndex = 4;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged_1);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblemail.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblemail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblemail.Location = new System.Drawing.Point(361, 27);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(58, 23);
            this.lblemail.TabIndex = 46;
            this.lblemail.Text = "Email:";
            // 
            // lblrnc
            // 
            this.lblrnc.AutoSize = true;
            this.lblrnc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblrnc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblrnc.Location = new System.Drawing.Point(361, 95);
            this.lblrnc.Name = "lblrnc";
            this.lblrnc.Size = new System.Drawing.Size(111, 23);
            this.lblrnc.TabIndex = 22;
            this.lblrnc.Text = "RNC/Cedula:";
            // 
            // txtnombre
            // 
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(68, 120);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(187, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtdireccion.Location = new System.Drawing.Point(365, 186);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(235, 85);
            this.txtdireccion.TabIndex = 6;
            this.txtdireccion.Text = "";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnombre.Location = new System.Drawing.Point(63, 95);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(80, 23);
            this.lblnombre.TabIndex = 12;
            this.lblnombre.Text = "Nombre:";
            // 
            // txtrnc
            // 
            this.txtrnc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrnc.Enabled = false;
            this.txtrnc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrnc.Location = new System.Drawing.Point(365, 121);
            this.txtrnc.Name = "txtrnc";
            this.txtrnc.Size = new System.Drawing.Size(140, 20);
            this.txtrnc.TabIndex = 5;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lbldireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldireccion.Location = new System.Drawing.Point(361, 160);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(90, 23);
            this.lbldireccion.TabIndex = 16;
            this.lbldireccion.Text = "Direccion:";
            // 
            // lbltelefono1
            // 
            this.lbltelefono1.AutoSize = true;
            this.lbltelefono1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbltelefono1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lbltelefono1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltelefono1.Location = new System.Drawing.Point(64, 160);
            this.lbltelefono1.Name = "lbltelefono1";
            this.lbltelefono1.Size = new System.Drawing.Size(97, 23);
            this.lbltelefono1.TabIndex = 24;
            this.lbltelefono1.Text = "Telefono 1:";
            // 
            // txttelefono2
            // 
            this.txttelefono2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttelefono2.Enabled = false;
            this.txttelefono2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono2.Location = new System.Drawing.Point(69, 251);
            this.txttelefono2.Name = "txttelefono2";
            this.txttelefono2.Size = new System.Drawing.Size(139, 20);
            this.txttelefono2.TabIndex = 3;
            // 
            // txttelefono1
            // 
            this.txttelefono1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttelefono1.Enabled = false;
            this.txttelefono1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono1.Location = new System.Drawing.Point(68, 186);
            this.txttelefono1.Name = "txttelefono1";
            this.txttelefono1.Size = new System.Drawing.Size(140, 20);
            this.txttelefono1.TabIndex = 2;
            // 
            // lbltelefono2
            // 
            this.lbltelefono2.AutoSize = true;
            this.lbltelefono2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbltelefono2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lbltelefono2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltelefono2.Location = new System.Drawing.Point(63, 225);
            this.lbltelefono2.Name = "lbltelefono2";
            this.lbltelefono2.Size = new System.Drawing.Size(97, 23);
            this.lbltelefono2.TabIndex = 25;
            this.lbltelefono2.Text = "Telefono 2:";
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtrnc;
        private System.Windows.Forms.Label lblrnc;
        private System.Windows.Forms.TextBox txttelefono1;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbltelefono2;
        private System.Windows.Forms.Label lbltelefono1;
        private System.Windows.Forms.TextBox txttelefono2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtdireccion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCerrar;
    }
}