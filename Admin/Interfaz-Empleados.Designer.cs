namespace vista
{
    partial class Interfaz_Empleados
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Purchase_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostumerName_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaraPurchase_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Columna,
            this.Date_Purchase_Column,
            this.CostumerName_Column,
            this.DaraPurchase_Column});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID_Columna
            // 
            this.ID_Columna.HeaderText = "ID";
            this.ID_Columna.Name = "ID_Columna";
            // 
            // Date_Purchase_Column
            // 
            this.Date_Purchase_Column.HeaderText = "Fecha";
            this.Date_Purchase_Column.Name = "Date_Purchase_Column";
            // 
            // CostumerName_Column
            // 
            this.CostumerName_Column.HeaderText = "Nombre de cliente";
            this.CostumerName_Column.Name = "CostumerName_Column";
            // 
            // DaraPurchase_Column
            // 
            this.DaraPurchase_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DaraPurchase_Column.HeaderText = "Datos de compra";
            this.DaraPurchase_Column.Name = "DaraPurchase_Column";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Editar Compra";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.button2.Location = new System.Drawing.Point(3, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Borrar Compra";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button3.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.button3.Location = new System.Drawing.Point(3, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Agregar Compra";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(173, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 162);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 169);
            this.panel2.TabIndex = 5;
            // 
            // Interfaz_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(598, 389);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Interfaz_Empleados";
            this.Text = "Interfaz_Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Columna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Purchase_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostumerName_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaraPurchase_Column;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}