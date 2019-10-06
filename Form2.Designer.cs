namespace Zumi
{
    partial class Form2
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
            this.Pcb_Foto2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_Foto2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pcb_Foto2
            // 
            this.Pcb_Foto2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pcb_Foto2.Location = new System.Drawing.Point(0, 0);
            this.Pcb_Foto2.Name = "Pcb_Foto2";
            this.Pcb_Foto2.Size = new System.Drawing.Size(988, 591);
            this.Pcb_Foto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pcb_Foto2.TabIndex = 0;
            this.Pcb_Foto2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(988, 591);
            this.Controls.Add(this.Pcb_Foto2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.LocationChanged += new System.EventHandler(this.Form2_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_Foto2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox Pcb_Foto2;
    }
}