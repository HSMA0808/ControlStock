namespace WindowsFormsApp3
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GBoxAccesoRapido = new System.Windows.Forms.GroupBox();
            this.LinkDevEntrada = new System.Windows.Forms.LinkLabel();
            this.LinkSalida = new System.Windows.Forms.LinkLabel();
            this.LinkEntrada = new System.Windows.Forms.LinkLabel();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblStocker = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnMantenimientos = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnProcesos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GBoxAccesoRapido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 667);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnCerrar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(344, -4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 677);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(249, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 66);
            this.label1.TabIndex = 8;
            this.label1.Text = "CONTROL STOCK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(754, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inicio";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.GBoxAccesoRapido);
            this.panel2.Controls.Add(this.btnConsultas);
            this.panel2.Controls.Add(this.lblSystem);
            this.panel2.Controls.Add(this.lblStocker);
            this.panel2.Controls.Add(this.btnUser);
            this.panel2.Controls.Add(this.btnMantenimientos);
            this.panel2.Controls.Add(this.btnStock);
            this.panel2.Controls.Add(this.btnReportes);
            this.panel2.Controls.Add(this.btnProcesos);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 667);
            this.panel2.TabIndex = 0;
            // 
            // GBoxAccesoRapido
            // 
            this.GBoxAccesoRapido.Controls.Add(this.LinkDevEntrada);
            this.GBoxAccesoRapido.Controls.Add(this.LinkSalida);
            this.GBoxAccesoRapido.Controls.Add(this.LinkEntrada);
            this.GBoxAccesoRapido.Font = new System.Drawing.Font("Calibri", 12F);
            this.GBoxAccesoRapido.ForeColor = System.Drawing.Color.White;
            this.GBoxAccesoRapido.Location = new System.Drawing.Point(30, 402);
            this.GBoxAccesoRapido.Name = "GBoxAccesoRapido";
            this.GBoxAccesoRapido.Size = new System.Drawing.Size(289, 118);
            this.GBoxAccesoRapido.TabIndex = 9;
            this.GBoxAccesoRapido.TabStop = false;
            this.GBoxAccesoRapido.Text = "Acceso Rapido";
            // 
            // LinkDevEntrada
            // 
            this.LinkDevEntrada.AutoSize = true;
            this.LinkDevEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkDevEntrada.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkDevEntrada.ForeColor = System.Drawing.Color.White;
            this.LinkDevEntrada.LinkColor = System.Drawing.Color.Lime;
            this.LinkDevEntrada.Location = new System.Drawing.Point(6, 87);
            this.LinkDevEntrada.Name = "LinkDevEntrada";
            this.LinkDevEntrada.Size = new System.Drawing.Size(160, 23);
            this.LinkDevEntrada.TabIndex = 7;
            this.LinkDevEntrada.TabStop = true;
            this.LinkDevEntrada.Text = "Devolucion Entrada";
            this.LinkDevEntrada.VisitedLinkColor = System.Drawing.Color.Black;
            this.LinkDevEntrada.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkDevEntrada_LinkClicked);
            // 
            // LinkSalida
            // 
            this.LinkSalida.AutoSize = true;
            this.LinkSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkSalida.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkSalida.ForeColor = System.Drawing.Color.White;
            this.LinkSalida.LinkColor = System.Drawing.Color.Lime;
            this.LinkSalida.Location = new System.Drawing.Point(6, 55);
            this.LinkSalida.Name = "LinkSalida";
            this.LinkSalida.Size = new System.Drawing.Size(55, 23);
            this.LinkSalida.TabIndex = 6;
            this.LinkSalida.TabStop = true;
            this.LinkSalida.Text = "Salida";
            this.LinkSalida.VisitedLinkColor = System.Drawing.Color.Black;
            this.LinkSalida.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSalida_LinkClicked_1);
            // 
            // LinkEntrada
            // 
            this.LinkEntrada.AutoSize = true;
            this.LinkEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkEntrada.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkEntrada.ForeColor = System.Drawing.Color.White;
            this.LinkEntrada.LinkColor = System.Drawing.Color.Lime;
            this.LinkEntrada.Location = new System.Drawing.Point(6, 23);
            this.LinkEntrada.Name = "LinkEntrada";
            this.LinkEntrada.Size = new System.Drawing.Size(70, 23);
            this.LinkEntrada.TabIndex = 5;
            this.LinkEntrada.TabStop = true;
            this.LinkEntrada.Text = "Entrada";
            this.LinkEntrada.VisitedLinkColor = System.Drawing.Color.Black;
            this.LinkEntrada.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkEntrada_LinkClicked_1);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.Location = new System.Drawing.Point(27, 246);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(287, 67);
            this.btnConsultas.TabIndex = 3;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblSystem.ForeColor = System.Drawing.Color.White;
            this.lblSystem.Location = new System.Drawing.Point(198, 23);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(51, 17);
            this.lblSystem.TabIndex = 6;
            this.lblSystem.Text = "System";
            // 
            // lblStocker
            // 
            this.lblStocker.AutoSize = true;
            this.lblStocker.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.lblStocker.ForeColor = System.Drawing.Color.White;
            this.lblStocker.Location = new System.Drawing.Point(6, 12);
            this.lblStocker.Name = "lblStocker";
            this.lblStocker.Size = new System.Drawing.Size(200, 33);
            this.lblStocker.TabIndex = 0;
            this.lblStocker.Text = "CONTROL STOCK";
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUser.BackgroundImage")));
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(274, 10);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(61, 57);
            this.btnUser.TabIndex = 9;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnMantenimientos
            // 
            this.btnMantenimientos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMantenimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMantenimientos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMantenimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnMantenimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientos.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientos.ForeColor = System.Drawing.Color.White;
            this.btnMantenimientos.Location = new System.Drawing.Point(27, 88);
            this.btnMantenimientos.Name = "btnMantenimientos";
            this.btnMantenimientos.Size = new System.Drawing.Size(287, 67);
            this.btnMantenimientos.TabIndex = 1;
            this.btnMantenimientos.Text = "Mantenimientos";
            this.btnMantenimientos.UseVisualStyleBackColor = false;
            this.btnMantenimientos.Click += new System.EventHandler(this.btnMantenimientos_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.Black;
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Location = new System.Drawing.Point(27, 532);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(287, 106);
            this.btnStock.TabIndex = 8;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(27, 324);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(287, 67);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnProcesos
            // 
            this.btnProcesos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnProcesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProcesos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesos.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesos.ForeColor = System.Drawing.Color.White;
            this.btnProcesos.Location = new System.Drawing.Point(27, 168);
            this.btnProcesos.Name = "btnProcesos";
            this.btnProcesos.Size = new System.Drawing.Size(287, 67);
            this.btnProcesos.TabIndex = 2;
            this.btnProcesos.Text = "Procesos";
            this.btnProcesos.UseVisualStyleBackColor = false;
            this.btnProcesos.Click += new System.EventHandler(this.btnProcesos_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(811, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 25);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.button2.Location = new System.Drawing.Point(756, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "__";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 665);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocker - Menu";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.GBoxAccesoRapido.ResumeLayout(false);
            this.GBoxAccesoRapido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnProcesos;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnMantenimientos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblStocker;
        private System.Windows.Forms.GroupBox GBoxAccesoRapido;
        private System.Windows.Forms.LinkLabel LinkDevEntrada;
        private System.Windows.Forms.LinkLabel LinkSalida;
        private System.Windows.Forms.LinkLabel LinkEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCerrar;
    }
}

