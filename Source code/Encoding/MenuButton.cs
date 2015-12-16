/*
Encoding - A mini tool to encrypt and decrypt a plain-text
Copyright (c) 2015 - Nguyễn Tuấn
*/

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Encoding
{
    public class MenuButton : Button
    {
        [DefaultValue(null)]
        public ContextMenuStrip Menu { get; set; }

        protected override void OnMouseDown(MouseEventArgs mouseEvent)
        {
            base.OnMouseDown(mouseEvent);

            if (Menu != null && mouseEvent.Button == MouseButtons.Left)
            {
                Menu.Show(this, this.Width-this.Size.Width, this.Size.Height);
            }
        }

        protected override void OnPaint(PaintEventArgs paintEvent)
        {
            base.OnPaint(paintEvent);

            int arrowX = ClientRectangle.Width - 14;
            int arrowY = ClientRectangle.Height / 2 - 1;

            SolidBrush visible = new SolidBrush(ForeColor);

            Brush brush = Enabled ? visible : SystemBrushes.ButtonShadow;
            Point[] arrows = new Point[] { new Point(arrowX, arrowY), new Point(arrowX + 7, arrowY), new Point(arrowX + 3, arrowY + 4) };
            paintEvent.Graphics.FillPolygon(brush, arrows);
        }
    }
}
