namespace vista
{
    partial class Interfaz_Administrador
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Purchase_Button = new System.Windows.Forms.Button();
            this.Add_Employee = new System.Windows.Forms.Button();
            this.Kick_Employee = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_Vehicle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(205, 9);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 26);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehiculos Disponibles:";
            // 
            // Purchase_Button
            // 
            this.Purchase_Button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Purchase_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Purchase_Button.Location = new System.Drawing.Point(62, 3);
            this.Purchase_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Purchase_Button.Name = "Purchase_Button";
            this.Purchase_Button.Size = new System.Drawing.Size(224, 51);
            this.Purchase_Button.TabIndex = 2;
            this.Purchase_Button.Text = "Comprar Vehículo";
            this.Purchase_Button.UseVisualStyleBackColor = false;
            this.Purchase_Button.Click += new System.EventHandler(this.Purchase_Button_Click);
            // 
            // Add_Employee
            // 
            this.Add_Employee.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Add_Employee.Location = new System.Drawing.Point(62, 117);
            this.Add_Employee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Add_Employee.Name = "Add_Employee";
            this.Add_Employee.Size = new System.Drawing.Size(224, 51);
            this.Add_Employee.TabIndex = 3;
            this.Add_Employee.Text = "Contratar empleado";
            this.Add_Employee.UseVisualStyleBackColor = false;
            this.Add_Employee.Click += new System.EventHandler(this.Add_Employee_Click);
            // 
            // Kick_Employee
            // 
            this.Kick_Employee.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Kick_Employee.Location = new System.Drawing.Point(62, 174);
            this.Kick_Employee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Kick_Employee.Name = "Kick_Employee";
            this.Kick_Employee.Size = new System.Drawing.Size(224, 51);
            this.Kick_Employee.TabIndex = 4;
            this.Kick_Employee.Text = "Despedir empleado";
            this.Kick_Employee.UseVisualStyleBackColor = false;
            this.Kick_Employee.Click += new System.EventHandler(this.Kick_Employee_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 26);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre empleado:";
            // 
            // Add_Vehicle
            // 
            this.Add_Vehicle.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Add_Vehicle.Location = new System.Drawing.Point(62, 60);
            this.Add_Vehicle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Add_Vehicle.Name = "Add_Vehicle";
            this.Add_Vehicle.Size = new System.Drawing.Size(224, 51);
            this.Add_Vehicle.TabIndex = 8;
            this.Add_Vehicle.Text = "Agregar Vehículo";
            this.Add_Vehicle.UseVisualStyleBackColor = false;
            this.Add_Vehicle.Click += new System.EventHandler(this.Add_Vehicle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 82);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Purchase_Button);
            this.panel2.Controls.Add(this.Add_Employee);
            this.panel2.Controls.Add(this.Add_Vehicle);
            this.panel2.Controls.Add(this.Kick_Employee);
            this.panel2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(14, 118);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 236);
            this.panel2.TabIndex = 10;
            // 
            // Interfaz_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(386, 373);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Interfaz_Administrador";
            this.Text = "Interfaz_Administrador";
            this.Load += new System.EventHandler(this.Interfaz_Administrador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Purchase_Button;
        private System.Windows.Forms.Button Add_Employee;
        private System.Windows.Forms.Button Kick_Employee;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_Vehicle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}