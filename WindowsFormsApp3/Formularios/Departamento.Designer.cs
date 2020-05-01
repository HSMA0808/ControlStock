namespace WindowsFormsApp3
{
    partial class Departamento
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtidDepartamento = new System.Windows.Forms.TextBox();
            this.lblIdDepto = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.lblidempleado = new System.Windows.Forms.Label();
            this.txtnomdepto = new System.Windows.Forms.TextBox();
            this.lblnomdepto = new System.Windows.Forms.Label();
            this.txtsupervisor = new System.Windows.Forms.TextBox();
            this.lblsupervisor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.txtidDepartamento);
            this.panel1.Controls.Add(this.lblIdDepto);
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtidempleado);
            this.panel1.Controls.Add(this.lblidempleado);
            this.panel1.Controls.Add(this.txtnomdepto);
            this.panel1.Controls.Add(this.lblnomdepto);
            this.panel1.Controls.Add(this.txtsupervisor);
            this.panel1.Controls.Add(this.lblsupervisor);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(-4, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 461);
            this.panel1.TabIndex = 7;
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
            this.btnActualizar.Location = new System.Drawing.Point(608, 325);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 46);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Guardar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtidDepartamento
            // 
            this.txtidDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidDepartamento.Enabled = false;
            this.txtidDepartamento.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtidDepartamento.Location = new System.Drawing.Point(42, 154);
            this.txtidDepartamento.Name = "txtidDepartamento";
            this.txtidDepartamento.Size = new System.Drawing.Size(96, 20);
            this.txtidDepartamento.TabIndex = 78;
            // 
            // lblIdDepto
            // 
            this.lblIdDepto.AutoSize = true;
            this.lblIdDepto.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblIdDepto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdDepto.Location = new System.Drawing.Point(38, 131);
            this.lblIdDepto.Name = "lblIdDepto";
            this.lblIdDepto.Size = new System.Drawing.Size(152, 23);
            this.lblIdDepto.TabIndex = 77;
            this.lblIdDepto.Text = "ID Departamento:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.DimGray;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnbuscar.Location = new System.Drawing.Point(484, 246);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(394, 388);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 46);
            this.btnLimpiar.TabIndex = 6;
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
            this.btnNuevo.Location = new System.Drawing.Point(286, 389);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 46);
            this.btnNuevo.TabIndex = 5;
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
            this.btnCancelar.Location = new System.Drawing.Point(608, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 46);
            this.btnCancelar.TabIndex = 7;
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
            this.btnGuardar.Location = new System.Drawing.Point(501, 387);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 46);
            this.btnGuardar.TabIndex = 3;
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
            this.panel2.Size = new System.Drawing.Size(734, 100);
            this.panel2.TabIndex = 29;
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
            this.button2.Location = new System.Drawing.Point(605, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 25);
            this.button2.TabIndex = 14;
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
            this.btnCerrar.Location = new System.Drawing.Point(660, 14);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 25);
            this.btnCerrar.TabIndex = 13;
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
            this.label1.Size = new System.Drawing.Size(190, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamentos";
            // 
            // txtidempleado
            // 
            this.txtidempleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidempleado.Enabled = false;
            this.txtidempleado.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtidempleado.Location = new System.Drawing.Point(42, 244);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Size = new System.Drawing.Size(96, 20);
            this.txtidempleado.TabIndex = 23;
            // 
            // lblidempleado
            // 
            this.lblidempleado.AutoSize = true;
            this.lblidempleado.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblidempleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblidempleado.Location = new System.Drawing.Point(38, 221);
            this.lblidempleado.Name = "lblidempleado";
            this.lblidempleado.Size = new System.Drawing.Size(114, 23);
            this.lblidempleado.TabIndex = 22;
            this.lblidempleado.Text = "ID Empleado:";
            // 
            // txtnomdepto
            // 
            this.txtnomdepto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnomdepto.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtnomdepto.Location = new System.Drawing.Point(295, 157);
            this.txtnomdepto.Name = "txtnomdepto";
            this.txtnomdepto.Size = new System.Drawing.Size(168, 20);
            this.txtnomdepto.TabIndex = 1;
            // 
            // lblnomdepto
            // 
            this.lblnomdepto.AutoSize = true;
            this.lblnomdepto.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblnomdepto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnomdepto.Location = new System.Drawing.Point(291, 131);
            this.lblnomdepto.Name = "lblnomdepto";
            this.lblnomdepto.Size = new System.Drawing.Size(131, 23);
            this.lblnomdepto.TabIndex = 16;
            this.lblnomdepto.Text = "Departamento:";
            // 
            // txtsupervisor
            // 
            this.txtsupervisor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsupervisor.Enabled = false;
            this.txtsupervisor.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtsupervisor.Location = new System.Drawing.Point(295, 247);
            this.txtsupervisor.Name = "txtsupervisor";
            this.txtsupervisor.Size = new System.Drawing.Size(187, 20);
            this.txtsupervisor.TabIndex = 13;
            this.txtsupervisor.TextChanged += new System.EventHandler(this.txtsupervisor_TextChanged);
            // 
            // lblsupervisor
            // 
            this.lblsupervisor.AutoSize = true;
            this.lblsupervisor.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblsupervisor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsupervisor.Location = new System.Drawing.Point(291, 221);
            this.lblsupervisor.Name = "lblsupervisor";
            this.lblsupervisor.Size = new System.Drawing.Size(100, 23);
            this.lblsupervisor.TabIndex = 12;
            this.lblsupervisor.Text = "Supervisor:";
            this.lblsupervisor.Click += new System.EventHandler(this.lblsupervisor_Click);
            // 
            // Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Departamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.Departamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtnomdepto;
        private System.Windows.Forms.Label lblnomdepto;
        private System.Windows.Forms.TextBox txtsupervisor;
        private System.Windows.Forms.Label lblsupervisor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtidDepartamento;
        private System.Windows.Forms.Label lblIdDepto;
        private System.Windows.Forms.TextBox txtidempleado;
        private System.Windows.Forms.Label lblidempleado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCerrar;
    }
}