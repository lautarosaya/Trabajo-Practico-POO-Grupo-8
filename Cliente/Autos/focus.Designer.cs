namespace vista.Cliente.Modelos_Autos
{
    partial class focus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(focus));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureFord = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFord)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ford";
            // 
            // pictureFord
            // 
            this.pictureFord.Image = ((System.Drawing.Image)(resources.GetObject("pictureFord.Image")));
            this.pictureFord.Location = new System.Drawing.Point(12, 12);
            this.pictureFord.Name = "pictureFord";
            this.pictureFord.Size = new System.Drawing.Size(206, 85);
            this.pictureFord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFord.TabIndex = 2;
            this.pictureFord.TabStop = false;
            // 
            // focus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureFord);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "focus";
            this.Text = "focus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureFord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureFord;
    }
}