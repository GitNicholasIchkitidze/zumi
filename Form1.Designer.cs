namespace Zumi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextH = new System.Windows.Forms.TextBox();
            this.TextW = new System.Windows.Forms.TextBox();
            this.TextY = new System.Windows.Forms.TextBox();
            this.TextX = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Player1_cBoxScreen = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.TextH);
            this.panel1.Controls.Add(this.TextW);
            this.panel1.Controls.Add(this.TextY);
            this.panel1.Controls.Add(this.TextX);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Player1_cBoxScreen);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 31);
            this.panel1.TabIndex = 5;
            // 
            // TextH
            // 
            this.TextH.Location = new System.Drawing.Point(497, 6);
            this.TextH.Name = "TextH";
            this.TextH.Size = new System.Drawing.Size(68, 20);
            this.TextH.TabIndex = 12;
            this.TextH.Text = "2000";
            this.TextH.TextChanged += new System.EventHandler(this.TextH_TextChanged);
            // 
            // TextW
            // 
            this.TextW.Location = new System.Drawing.Point(423, 6);
            this.TextW.Name = "TextW";
            this.TextW.Size = new System.Drawing.Size(68, 20);
            this.TextW.TabIndex = 11;
            this.TextW.Text = "4000";
            this.TextW.TextChanged += new System.EventHandler(this.TextW_TextChanged);
            // 
            // TextY
            // 
            this.TextY.Location = new System.Drawing.Point(316, 6);
            this.TextY.Name = "TextY";
            this.TextY.Size = new System.Drawing.Size(68, 20);
            this.TextY.TabIndex = 10;
            this.TextY.Text = "50";
            this.TextY.TextChanged += new System.EventHandler(this.TextY_TextChanged);
            // 
            // TextX
            // 
            this.TextX.Location = new System.Drawing.Point(242, 6);
            this.TextX.Name = "TextX";
            this.TextX.Size = new System.Drawing.Size(68, 20);
            this.TextX.TabIndex = 9;
            this.TextX.Text = "430";
            this.TextX.TextChanged += new System.EventHandler(this.TextX_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(724, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "COLOSE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Player1_cBoxScreen
            // 
            this.Player1_cBoxScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Player1_cBoxScreen.FormattingEnabled = true;
            this.Player1_cBoxScreen.Location = new System.Drawing.Point(77, 6);
            this.Player1_cBoxScreen.Name = "Player1_cBoxScreen";
            this.Player1_cBoxScreen.Size = new System.Drawing.Size(124, 21);
            this.Player1_cBoxScreen.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 6);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "2";
            this.textBox1.LocationChanged += new System.EventHandler(this.TextBox1_LocationChanged);
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 34);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ფორმულა ზუმი";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Player1_cBoxScreen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TextH;
        private System.Windows.Forms.TextBox TextW;
        private System.Windows.Forms.TextBox TextY;
        private System.Windows.Forms.TextBox TextX;
    }
}

