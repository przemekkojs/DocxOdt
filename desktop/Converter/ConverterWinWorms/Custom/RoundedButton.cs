using System.Drawing.Drawing2D;

namespace ConverterWinWorms.Custom
{
    public class RoundedButton : Button
    {
        public int BorderRadius { get; set; } = 5;

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            var path = new GraphicsPath();
            var radius = BorderRadius * 2;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            using Pen pen = new (Color.Black, 2);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.DrawPath(pen, path);
        }
    }
}
