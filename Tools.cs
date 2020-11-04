using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace PaintPoging
{
    public enum ToolEnum
    {
        Pen = 0,
        Line = 1,
        Rectangle = 2,
        FillRectangle = 3,
        Text = 4,
        Eraser = 5,
        Circle = 6
    }

    public static class Tools
    {
        public static IPaintTool[] CreateAllTools()
        {
            IPaintTool[] tools = {
                new PenTool(),
                new LineTool(),
                new RecTool(),
                new FillRecTool(),
                new TxTool(),
                new EraserTool(),
                new CircleTool()
            };
            return tools;
        }
    }

    public interface IPaintTool
    {
        void MBDown(PaintingControl s, Point p);
        void MBDrag(PaintingControl s, Point p);
        void MBUp(PaintingControl s, Point p);
        void Letter(PaintingControl s, char c);
    }

    public abstract class OnePTool : IPaintTool
    {
        protected Point start;
        protected Brush brush;

        public virtual void MBDown(PaintingControl s, Point p)
        {
            start = p;
        }
        public virtual void MBUp(PaintingControl s, Point p)
        {
            brush = new SolidBrush(s.color);
        }
        public abstract void MBDrag(PaintingControl s, Point p);
        public abstract void Letter(PaintingControl s, char c);
    }

    public class TxTool : OnePTool
    {
        public override string ToString() { return "text"; }

        public override void MBDrag(PaintingControl s, Point p) { }

        public override void Letter(PaintingControl s, char c)
        {
            if (c >= 32)
            {
                Graphics gr = s.CreateGraphics();
                Font font = new Font("Tahoma", 40);
                string txt = c.ToString();
                SizeF sz =
                gr.MeasureString(txt, font, this.start, StringFormat.GenericTypographic);
                gr.DrawString(txt, font, brush,
                                              this.start, StringFormat.GenericTypographic);
                gr.DrawRectangle(Pens.Black, start.X, start.Y, sz.Width, sz.Height);
                start.X += (int)sz.Width;
                s.Invalidate();
            }
        }
    }

    public abstract class TwoPTool : OnePTool
    {
        public static Rectangle CreateRectangle(Point p1, Point p2)
        {
            return new Rectangle(new Point(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y))
                                , new Size(Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y))
                                );
        }
        public static Pen CreatePen(Brush b, int thickness)
        {
            Pen pen = new Pen(b, thickness);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            return pen;
        }
        public override void MBDown(PaintingControl s, Point p)
        {
            base.MBDown(s, p);
            brush = Brushes.Gray;
        }
        public override void MBDrag(PaintingControl s, Point p)
        {
            s.Refresh();
            this.Active(s.CreateGraphics(), this.start, p);
        }
        public override void MBUp(PaintingControl s, Point p)
        {
            base.MBUp(s, p);
            this.Finished(s.CreateGraphics(), this.start, p);
            s.Invalidate();
        }
        public override void Letter(PaintingControl s, char c)
        {
        }
        public abstract void Active(Graphics g, Point p1, Point p2);

        public virtual void Finished(Graphics g, Point p1, Point p2)
        {
            this.Active(g, p1, p2);
        }
    }

    public class RecTool : TwoPTool
    {
        public override string ToString() { return "rect"; }

        public override void Active(Graphics g, Point p1, Point p2)
        {
            g.DrawRectangle(CreatePen(brush, 3), TwoPTool.CreateRectangle(p1, p2));
        }
    }
    public class CircleTool : TwoPTool
    {
        public override string ToString() { return "circle"; }

        public override void Active(Graphics g, Point p1, Point p2)
        {
            g.DrawEllipse(CreatePen(brush, 3), TwoPTool.CreateRectangle(p1, p2));
        }
    }

    public class FillRecTool : RecTool
    {
        public override string ToString() { return "fillrect"; }

        public override void Finished(Graphics g, Point p1, Point p2)
        {
            g.FillRectangle(brush, TwoPTool.CreateRectangle(p1, p2));
        }
    }

    public class LineTool : TwoPTool
    {
        public override string ToString() { return "line"; }

        public override void Active(Graphics g, Point p1, Point p2)
        {
            g.DrawLine(CreatePen(this.brush, 3), p1, p2);
        }
    }

    public class PenTool : LineTool
    {
        public override string ToString() { return "pen"; }

        public override void MBDrag(PaintingControl s, Point p)
        {
            this.MBUp(s, p);
            this.MBDown(s, p);
        }
    }

    public class EraserTool : PenTool
    {
        public override string ToString() { return "eraser"; }

        public override void Active(Graphics g, Point p1, Point p2)
        {
            g.DrawLine(CreatePen(Brushes.White, 7), p1, p2);
        }
    }
}

