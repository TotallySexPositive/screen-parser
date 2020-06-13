using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace ScreenParser
{
    class Capture
    {
        public static String imagePath = "C:\\Users\\riege\\Documents\\temp.png";
        public Rectangle area;
        public Capture(Rectangle rect)
        {
            area = rect;
            makeBmp();
        }

        private void makeBmp()
        {
            int width = area.Right - area.Left;
            int height = area.Bottom - area.Top;
            if (height == 0 || width == 0)
            {
                return;
            }
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.CopyFromScreen(area.Left, area.Top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
            }
            bmp.Save(Capture.imagePath, ImageFormat.Png);
        }
        
    }
}
