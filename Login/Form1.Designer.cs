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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.icoClose = new FontAwesome.Sharp.IconButton();
            this.pnlLogin.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.pnlLogin.Controls.Add(this.btnRegistrarLO);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.txtUsuario);
            this.pnlLogin.Controls.Add(this.txtContraseña);
            this.pnlLogin.Controls.Add(this.btnLoginLO);
            this.pnlLogin.Location = new System.Drawing.Point(0, 37);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(264, 275);
            this.pnlLogin.TabIndex = 0;
            // 
            // btnRegistrarLO
            // 
            this.btnRegistrarLO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.btnRegistrarLO.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarLO.Location = new System.Drawing.Point(79, 203);
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
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 70);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sánchez \r\nAutomotores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(32, 89);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(206, 26);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "Nombre de usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtContraseña.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Silver;
            this.txtContraseña.Location = new System.Drawing.Point(32, 126);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(206, 26);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // btnLoginLO
            // 
            this.btnLoginLO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.btnLoginLO.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLoginLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginLO.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginLO.Location = new System.Drawing.Point(32, 158);
            this.btnLoginLO.Name = "btnLoginLO";
            this.btnLoginLO.Size = new System.Drawing.Size(206, 39);
            this.btnLoginLO.TabIndex = 2;
            this.btnLoginLO.Text = "Ingresar";
            this.btnLoginLO.UseVisualStyleBackColor = false;
            this.btnLoginLO.Click += new System.EventHandler(this.btnLoginLO_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(146)))), ((int)(((byte)(22)))));
            this.pnlTop.Controls.Add(this.icoClose);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(264, 40);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // icoClose
            // 
            this.icoClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.icoClose.FlatAppearance.BorderSize = 0;
            this.icoClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.icoClose.IconColor = System.Drawing.Color.Black;
            this.icoClose.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.icoClose.IconSize = 20;
            this.icoClose.Location = new System.Drawing.Point(209, 0);
            this.icoClose.Name = "icoClose";
            this.icoClose.Size = new System.Drawing.Size(55, 40);
            this.icoClose.TabIndex = 0;
            this.icoClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(264, 312);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnLoginLO;
        private System.Windows.Forms.Button btnRegistrarLO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTop;
        private FontAwesome.Sharp.IconButton icoClose;
    }
}

