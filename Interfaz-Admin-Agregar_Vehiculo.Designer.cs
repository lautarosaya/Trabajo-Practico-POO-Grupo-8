namespace vista
{
    partial class Interfaz_Admin_Agregar_Vehiculo
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(133, 95);
            this.listBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 3);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2022, 6, 8, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(9, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 80);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "¿Es NUEVO el vehículo?";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(34, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Si";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(7, 5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(136, 95);
            this.listBox2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(19, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 110);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Location = new System.Drawing.Point(19, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 110);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Location = new System.Drawing.Point(186, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 30);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Location = new System.Drawing.Point(186, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(172, 101);
            this.panel4.TabIndex = 9;
            // 
            // Interfaz_Admin_Agregar_Vehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 331);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Interfaz_Admin_Agregar_Vehiculo";
            this.Text = "Interfaz_Admin_Agregar_Vehiculo";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}