using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System;

namespace Mastermind
{
    public class CirclePanel : Panel
    {
        private eColor currentColor;

        public eColor CurrentColor
        {
            get => currentColor;
            set
            {
                currentColor = value;
                this.BackColor = Enums.ColorFromEnum(currentColor);
            }
        }

        public bool AllowColorChange { get; set; } = true;

        public CirclePanel()
        {
            this.CurrentColor = 0;
            this.Click += Panel_Click;
            this.DoubleClick += Panel_Click;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ExtendedDraw(e);
            DrawBorder(e.Graphics);
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            if (!this.AllowColorChange)
                return;

            var cp = (CirclePanel)sender;

            //the next color after pink, is the first color
            if (cp.CurrentColor == eColor.Pink)
                cp.CurrentColor = 0;
            else
                cp.CurrentColor++;
        }

        private Rectangle GetLeftUpper(int e)
            => new Rectangle(0, 0, e, e);

        private Rectangle GetRightUpper(int e)
            => new Rectangle(Width - e, 0, e, e);

        private Rectangle GetRightLower(int e)
            => new Rectangle(Width - e, Height - e, e, e);

        private Rectangle GetLeftLower(int e)
            => new Rectangle(0, Height - e, e, e);

        private void ExtendedDraw(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(GetLeftUpper(Width), 180, 90);
            path.AddLine(Width, 0, 0, 0);
            path.AddArc(GetRightUpper(Width), 270, 90);
            path.AddLine(Width, Width, Width, Height - Width);
            path.AddArc(GetRightLower(Width), 0, 90);
            path.AddLine(0, Height, Width, Height);
            path.AddArc(GetLeftLower(Width), 90, 90);
            path.AddLine(0, Height - Width, 0, Width);
            path.CloseFigure();
            Region = new Region(path);
        }

        private void DrawSingleBorder(Graphics graphics)
        {
            var pen = new Pen(Color.Transparent, 2.0F);
            graphics.DrawArc(pen, new Rectangle(0, 0, Width, Width), 180, 90);
            graphics.DrawArc(pen, new Rectangle(-1, -1, Width, Width), 270, 90);
            graphics.DrawArc(pen, new Rectangle(-1, Height - Width - 1, Width, Width), 0, 90);
            graphics.DrawArc(pen, new Rectangle(0, Height - Width - 1, Width, Width), 90, 90);
            graphics.DrawRectangle(pen, 0.0F, 0.0F, Convert.ToSingle((Width - 1)), Convert.ToSingle((Height - 1)));
        }

        private void DrawBorder(Graphics graphics)
            => DrawSingleBorder(graphics);
    }
}