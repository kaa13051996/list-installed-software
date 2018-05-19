using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_soft_metro
{
    class RoundedPicBox:PictureBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Brush brImg;
            try
            {
                var img = new Bitmap(Image);
                img = new Bitmap(img, new Size(Width - 1, Height - 1));
                brImg = new TextureBrush(img);
            }
            catch
            {
                var img = new Bitmap(Width - 1, Height - 1, PixelFormat.Format32bppPArgb);
                brImg = new TextureBrush(img);
            }

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var path = new GraphicsPath();
            path.AddEllipse(0, 0, Width - 1, Height - 1);

            e.Graphics.FillPath(brImg, path);
            e.Graphics.DrawPath(Pens.Transparent, path);
        }
    }
}
