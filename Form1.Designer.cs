namespace vista
{
    partial class Form1
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnRegistrarLO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnLoginLO = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnRegistrarLO);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.txtUsuario);
            this.pnlLogin.Controls.Add(this.txtContraseña);
            this.pnlLogin.Controls.Add(this.btnLoginLO);
            this.pnlLogin.Location = new System.Drawing.Point(3, 12);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(264, 255);
            this.pnlLogin.TabIndex = 8;
            // 
            // btnRegistrarLO
            // 
            this.btnRegistrarLO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.btnRegistrarLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarLO.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarLO.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRegistrarLO.Location = new System.Drawing.Point(76, 203);
            this.btnRegistrarLO.Name = "btnRegistrarLO";
            this.btnRegistrarLO.Size = new System.Drawing.Size(113, 34);
            this.btnRegistrarLO.TabIndex = 3;
            this.btnRegistrarLO.Text = "Registrar";
            this.btnRegistrarLO.UseVisualStyleBackColor = false;
            this.btnRegistrarLO.Click += new System.EventHandler(this.btnRegistrarLO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 70);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sánchez \r\nAutomotores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(29, 84);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(206, 32);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "Nombre de usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.txtContraseña.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Silver;
            this.txtContraseña.Location = new System.Drawing.Point(29, 121);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(206, 32);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // btnLoginLO
            // 
            this.btnLoginLO.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginLO.Location = new System.Drawing.Point(29, 158);
            this.btnLoginLO.Name = "btnLoginLO";
            this.btnLoginLO.Size = new System.Drawing.Size(206, 39);
            this.btnLoginLO.TabIndex = 2;
            this.btnLoginLO.Text = "Ingresar";
            this.btnLoginLO.UseVisualStyleBackColor = true;
            this.btnLoginLO.Click += new System.EventHandler(this.btnLoginLO_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(159)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(272, 280);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnLoginLO;
        private System.Windows.Forms.Button btnRegistrarLO;
        private System.Windows.Forms.Label label1;
    }
}

