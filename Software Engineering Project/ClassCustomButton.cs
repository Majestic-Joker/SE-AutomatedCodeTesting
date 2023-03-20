using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Software_Engineering_Project
{
    public class ClassCustomButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Define a rectangle that will be used to draw the rounded corners
            RectangleF rect = new RectangleF(0, 0, Width, Height);

            // Define the radius of the rounded corners
            float radius = 20;

            // Create a graphics path that defines the shape of the button
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            // Fill the button with a solid color and draw its border
            e.Graphics.FillPath(Brushes.White, path);
            e.Graphics.DrawPath(Pens.Black, path);

            // Draw the button text in the center
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            e.Graphics.DrawString(Text, Font, Brushes.Black, ClientRectangle, sf);
        }
    }
}
