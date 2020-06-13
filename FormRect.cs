
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenParser
{
    public class FormRect : Form
    {   
        private Graphics formGraphics;
        private Rectangle rect;
        private bool isMouseDown = false;
        private int initialX;
        private int initialY;
        private double minOpacity = 0.01;
        private double maxOpacity = 0.25;
        public FormRect()
        {
            InitializeComponent();
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Refresh();
                Pen drawPen = new Pen(Color.Navy, 1);
                rect = new Rectangle(Math.Min(e.X, initialX),
                                     Math.Min(e.Y, initialY),
                                     Math.Abs(e.X - initialX),
                                     Math.Abs(e.Y - initialY));
                formGraphics = this.CreateGraphics();
                formGraphics.DrawRectangle(drawPen, rect);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
            isMouseDown = true;
            initialX = e.X;
            initialY = e.Y;
            
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                isMouseDown = false;
                this.Opacity = minOpacity;
                Capture c = new Capture(rect);
                //Process.Start("explorer.exe", ScreenParser.Capture.imagePath);
                OCR o = new OCR(ScreenParser.Capture.imagePath);
                this.Close();
            }
        }

        private void panel1_keyDown(object sender, KeyEventArgs e)
        {
        }

        private void panel1_keyUp(object sender, KeyEventArgs e)
        {
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormRect
            // 
            this.ClientSize = new System.Drawing.Size(566, 380);
            this.Name = "FormRect";
            this.Opacity = maxOpacity;
            this.MouseUp += new MouseEventHandler(this.panel1_MouseUp);
            this.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new MouseEventHandler(this.panel1_MouseMove);
            this.KeyDown += new KeyEventHandler(this.panel1_keyDown);
            this.KeyUp += new KeyEventHandler(this.panel1_keyUp);
            this.ResumeLayout(false);

        }
    }
}
