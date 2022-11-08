using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.App.GUI.Components
{
    public class RoundedButton : Button
    {
        private int borderSize = 0;
        private int borderRadius = 45;
        private Color borderColor = Color.PaleVioletRed;

        public RoundedButton()
            : base()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.DarkOrange;
            this.ForeColor = Color.White;
            this.Cursor = Cursors.Hand;
            this.Size = new Size(140, 50);
        }

        private GraphicsPath getFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8f, this.Height - 1);

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = this.getFigurePath(rectSurface, borderRadius))
                {
                    using (GraphicsPath pathBorder = this.getFigurePath(rectBorder, borderRadius - 1F))
                    {
                        using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                        {
                            using (Pen penBorder = new Pen(borderColor, borderSize))
                            {
                                penBorder.Alignment = PenAlignment.Inset;
                                this.Region = new Region(pathSurface);
                                pevent.Graphics.DrawPath(penSurface, pathSurface);

                                if (borderSize >= 1)
                                {
                                    pevent.Graphics.DrawPath(penBorder, pathBorder);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += (sender, ex) =>
            {
                if (this.DesignMode)
                {
                    this.Invalidate();
                }
            };
        }
    }
}
