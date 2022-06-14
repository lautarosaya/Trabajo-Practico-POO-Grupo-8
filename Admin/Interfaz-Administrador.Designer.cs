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
            this.label1 = new System.Windows.Forms.Label();
            this.Purchase_Button = new System.Windows.Forms.Button();
            this.Add_Employee = new System.Windows.Forms.Button();
            this.Kick_Employee = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehiculos Disponibles:";
            // 
            // Purchase_Button
            // 
            this.Purchase_Button.Location = new System.Drawing.Point(27, 147);
            this.Purchase_Button.Name = "Purchase_Button";
            this.Purchase_Button.Size = new System.Drawing.Size(75, 51);
            this.Purchase_Button.TabIndex = 2;
            this.Purchase_Button.Text = "Agregar Vehículo";
            this.Purchase_Button.UseVisualStyleBackColor = true;
            this.Purchase_Button.Click += new System.EventHandler(this.Purchase_Button_Click);
            // 
            // Add_Employee
            // 
            this.Add_Employee.Location = new System.Drawing.Point(189, 147);
            this.Add_Employee.Name = "Add_Employee";
            this.Add_Employee.Size = new System.Drawing.Size(75, 51);
            this.Add_Employee.TabIndex = 3;
            this.Add_Employee.Text = "Contratar empleado";
            this.Add_Employee.UseVisualStyleBackColor = true;
            this.Add_Employee.Click += new System.EventHandler(this.Add_Employee_Click);
            // 
            // Kick_Employee
            // 
            this.Kick_Employee.Location = new System.Drawing.Point(270, 147);
            this.Kick_Employee.Name = "Kick_Employee";
            this.Kick_Employee.Size = new System.Drawing.Size(75, 51);
            this.Kick_Employee.TabIndex = 4;
            this.Kick_Employee.Text = "Despedir empleado";
            this.Kick_Employee.UseVisualStyleBackColor = true;
            this.Kick_Employee.Click += new System.EventHandler(this.Kick_Employee_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(121, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 121);
            this.listBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "Descartar Vehículo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Interfaz_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 207);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Kick_Employee);
            this.Controls.Add(this.Add_Employee);
            this.Controls.Add(this.Purchase_Button);
            this.Controls.Add(this.label1);
            this.Name = "Interfaz_Administrador";
            this.Text = "Interfaz_Administrador";
            this.Load += new System.EventHandler(this.Interfaz_Administrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Purchase_Button;
        private System.Windows.Forms.Button Add_Employee;
        private System.Windows.Forms.Button Kick_Employee;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}