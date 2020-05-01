namespace WindowsFormsApp3
{
    partial class MenuProcesos
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
            this.btnDevSalida = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnDevEntrada = new System.Windows.Forms.Button();
            this.lblProcesos = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnDevSalida);
            this.panel1.Controls.Add(this.btnSalida);
            this.panel1.Controls.Add(this.btnDevEntrada);
            this.panel1.Controls.Add(this.lblProcesos);
            this.panel1.Controls.Add(this.btnEntrada);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 394);
            this.panel1.TabIndex = 13;
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
            this.btnDevSalida.Location = new System.Drawing.Point(215, 304);
            this.btnDevSalida.Name = "btnDevSalida";
            this.btnDevSalida.Size = new System.Drawing.Size(250, 50);
            this.btnDevSalida.TabIndex = 4;
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
            this.btnSalida.Location = new System.Drawing.Point(215, 148);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(250, 50);
            this.btnSalida.TabIndex = 2;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
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
            this.btnDevEntrada.Location = new System.Drawing.Point(215, 226);
            this.btnDevEntrada.Name = "btnDevEntrada";
            this.btnDevEntrada.Size = new System.Drawing.Size(250, 50);
            this.btnDevEntrada.TabIndex = 3;
            this.btnDevEntrada.Text = "Devolucion Entrada";
            this.btnDevEntrada.UseVisualStyleBackColor = false;
            this.btnDevEntrada.Click += new System.EventHandler(this.btnDevEntrada_Click);
            // 
            // lblProcesos
            // 
            this.lblProcesos.AutoSize = true;
            this.lblProcesos.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.lblProcesos.ForeColor = System.Drawing.Color.White;
            this.lblProcesos.Location = new System.Drawing.Point(281, 10);
            this.lblProcesos.Name = "lblProcesos";
            this.lblProcesos.Size = new System.Drawing.Size(116, 33);
            this.lblProcesos.TabIndex = 6;
            this.lblProcesos.Text = "Procesos";
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
            this.btnEntrada.Location = new System.Drawing.Point(215, 70);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(250, 50);
            this.btnEntrada.TabIndex = 1;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(634, 13);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 25);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 391);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuProcesos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuProcesos";
            this.Load += new System.EventHandler(this.MenuProcesos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnDevSalida;
        public System.Windows.Forms.Button btnSalida;
        public System.Windows.Forms.Button btnDevEntrada;
        public System.Windows.Forms.Label lblProcesos;
        public System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnCerrar;
    }
}