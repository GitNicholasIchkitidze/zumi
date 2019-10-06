using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zumi
{
    public partial class Form1 : Form
    {
        private Bitmap Bit;
        private Graphics Graf;
        private int Zoom = 2;

        //bool isDrag = false;
        //Rectangle theRectangle = new Rectangle(new Point(0, 0), new Size(0, 0));
        //Point startPoint;
        //Point currPoint;

        public Size SSize;

        public System.Windows.Forms.Screen[] _screens;

       
        private Form2 zooomForm;

        public Bitmap Bit1 { get => Bit; set => Bit = value; }
        public Graphics Graf1 { get => Graf; set => Graf = value; }
        public Form2 ZooomForm { get => zooomForm; set => zooomForm = value; }

        //ZooomForm = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            _screens = System.Windows.Forms.Screen.AllScreens;
            foreach (var screen in _screens)
            {
                Player1_cBoxScreen.Items.Add(screen.DeviceName);

            }
            Player1_cBoxScreen.SelectedItem = Player1_cBoxScreen.Items[Player1_cBoxScreen.Items.Count - 1];
            ZooomForm = new Form2();
            //ZooomForm.DesktopLocation = new Point(300,100);
            

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Bit = new Bitmap(Pcb_Foto.Width / Zoom, Pcb_Foto.Height / Zoom, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Bit1 = new Bitmap(ZooomForm.Pcb_Foto2.Width / Zoom, ZooomForm.Pcb_Foto2.Height / Zoom, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graf1 = Graphics.FromImage(Bit1);
            //currPoint = this.Pcb_Foto.PointToScreen(new Point());

            SSize = new Size(Convert.ToInt32(TextW.Text), Convert.ToInt32(TextH.Text));
            Graf1.CopyFromScreen(Convert.ToInt32(TextX.Text) , Convert.ToInt32(TextY.Text)  , ZooomForm.Pcb_Foto2.Location.X, ZooomForm.Pcb_Foto2.Location.Y, SSize, System.Drawing.CopyPixelOperation.SourceCopy);
            //Graf.CopyFromScreen(Convert.ToInt32(TextX.Text) - ZooomForm.Pcb_Foto2.Width / (Zoom * 2), Convert.ToInt32(TextY.Text) - ZooomForm.Pcb_Foto2.Height / (Zoom * 2), 0, 0, SSize, System.Drawing.CopyPixelOperation.SourceCopy);
            //            Graf.CopyFromScreen(MousePosition.X - ZooomForm.Pcb_Foto2.Width / (Zoom * 2), MousePosition.Y - ZooomForm.Pcb_Foto2.Height / (Zoom * 2), 0, 0, ZooomForm.Pcb_Foto2.Size, System.Drawing.CopyPixelOperation.SourceCopy);
            //            Graf.CopyFromScreen((currPoint.X + this.Pcb_Foto.Width)  - ZooomForm.Pcb_Foto2.Width / (Zoom * 2), (currPoint.Y + this.Pcb_Foto.Height) - ZooomForm.Pcb_Foto2.Height / (Zoom * 2), 0, 0, ZooomForm.Pcb_Foto2.Size, System.Drawing.CopyPixelOperation.SourceCopy);

            
            //Graf.CopyFromScreen(Convert.ToInt32(TextX.Text) - ZooomForm.Pcb_Foto2.Width / (Zoom * 2), (Convert.ToInt32(TextY.Text) + this.Pcb_Foto.Height) - ZooomForm.Pcb_Foto2.Height / (Zoom * 2), 0, 0, SSize, System.Drawing.CopyPixelOperation.SourceCopy);
            //Console.WriteLine("Mouse Pos: " + Convert.ToString(MousePosition.X) + "," + Convert.ToString(MousePosition.Y));
            //Console.WriteLine("Pcb_Foto Pos: " + Convert.ToString(currPoint.X) + "," + Convert.ToString(currPoint.Y));

            ZooomForm.Pcb_Foto2.Image = Bit1;


            /*
             * 
             * 
            //Bit = new Bitmap(ZooomForm.Pcb_Foto2.Width / Zoom, ZooomForm.Pcb_Foto2.Height / Zoom, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Bit = new Bitmap(ZooomForm.Pcb_Foto2.Width, ZooomForm.Pcb_Foto2.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graf = Graphics.FromImage(Bit);
            
            //Graf.CopyFromScreen(currPoint.X / (Zoom * 2), currPoint.Y / (Zoom * 2), 0, 0, this.Pcb_Foto.Size, System.Drawing.CopyPixelOperation.SourceCopy);
            Graf.CopyFromScreen(MousePosition.X - Pcb_Foto.Width / (Zoom * 2), MousePosition.Y - Pcb_Foto.Height / (Zoom * 2), 0, 0, Pcb_Foto.Size, System.Drawing.CopyPixelOperation.SourceCopy);
            //Pcb_Foto.Image = Bit;
            ZooomForm.Pcb_Foto2.Image = Bit;


            */


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //ZooomForm = new Form();


            // ZooomForm.Show();

            // ZooomForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //ZooomForm.WindowState = System.Windows.Forms.FormWindowState.Normal;
            //ZooomForm.Location = _screens[Player1_cBoxScreen.SelectedIndex].WorkingArea.Location;
            ZooomForm.Show();
            SetFormLocation(ZooomForm, _screens[Player1_cBoxScreen.SelectedIndex]);

            

        }

        private void SetFormLocation(Form form, Screen screen)
        {
            // first method
            Rectangle bounds = screen.Bounds;
            form.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);

            // second method
            //Point location = screen.Bounds.Location;
            //Size size = screen.Bounds.Size;

            //form.Left = location.X;
            //form.Top = location.Y;
            //form.Width = size.Width;
            //form.Height = size.Height;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            /*
            if (e.Button == MouseButtons.Left)
            {
                isDrag = true;
            }

            Control control = (Control)sender;

            // Calculate the startPoint by using the PointToScreen 
            // method.
            startPoint = control.PointToScreen(new Point(e.X, e.Y));
            textBox1.Text = startPoint.ToString();
            */
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            /*
            if (isDrag)

            // Hide the previous rectangle by calling the 
            // DrawReversibleFrame method with the same parameters.
            {
                ControlPaint.DrawReversibleFrame(theRectangle,
                    this.BackColor, FrameStyle.Dashed);

                // Calculate the endpoint and dimensions for the new 
                // rectangle, again using the PointToScreen method.
                Point endPoint = ((Control)sender).PointToScreen(new Point(e.X, e.Y));

                int width = endPoint.X - startPoint.X;
                int height = endPoint.Y - startPoint.Y;
                theRectangle = new Rectangle(startPoint.X,
                    startPoint.Y, width, height);

                // Draw the new rectangle by calling DrawReversibleFrame
                // again.  
                ControlPaint.DrawReversibleFrame(theRectangle,
                    this.BackColor, FrameStyle.Dashed);
            }
            */
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            /*
            isDrag = false;

            // Draw the rectangle to be evaluated. Set a dashed frame style 
            // using the FrameStyle enumeration.
            ControlPaint.DrawReversibleFrame(theRectangle,
                this.BackColor, FrameStyle.Dashed);

            // Find out which controls intersect the rectangle and 
            // change their color. The method uses the RectangleToScreen  
            // method to convert the Control's client coordinates 
            // to screen coordinates.
            Rectangle controlRectangle;
            for (int i = 0; i < Controls.Count; i++)
            {
                controlRectangle = Controls[i].RectangleToScreen
                    (Controls[i].ClientRectangle);
                if (controlRectangle.IntersectsWith(theRectangle))
                {
                    Controls[i].BackColor = Color.BurlyWood;
                }
            }

            // Reset the rectangle.
            theRectangle = new Rectangle(0, 0, 0, 0);
            */
        }

        private void TextBox1_LocationChanged(object sender, EventArgs e)
        {
            //currPoint = this.Pcb_Foto.PointToScreen(new Point());
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            Zoom = (textBox1.Text != "") ? Convert.ToInt32(textBox1.Text) : 2;
            
        }

        private void TextX_TextChanged(object sender, EventArgs e)
        {
           // DrawRectangleFloat();
        }
        public void DrawRectangleFloat()
        {
            /*
            // Create pen.
            Graphics g = this.CreateGraphics();

            //Pen blackPen = new Pen(Color.Black, 3);

            // Create location and size of rectangle.
            
            int x = Convert.ToInt32(TextX.Text);
            int y = Convert.ToInt32(TextY.Text);
            int width = Convert.ToInt32(TextW.Text);
            int height = Convert.ToInt32(TextH.Text);

            // Draw rectangle to screen.
            


            
            Pen selPen = new Pen(Color.Blue);
            g.DrawRectangle(selPen, x, y, width, height);
            g.Dispose();
            */
        }

        private void TextY_TextChanged(object sender, EventArgs e)
        {
           // DrawRectangleFloat();
        }

        private void TextW_TextChanged(object sender, EventArgs e)
        {
            //DrawRectangleFloat();
        }

        private void TextH_TextChanged(object sender, EventArgs e)
        {
            //DrawRectangleFloat();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
    }

