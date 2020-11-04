using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintPoging
{
    public class PaintingElement
    {
        private ToolEnum Type { get; set; } //type of drawing
        public Point[] points { get; set; } = new Point[2];
        public int priority { get; set; } = 0;
        public Color color { get; set; }
        public string Name { get; set; } //name of specified element

        public PaintingElement(ToolEnum type)
        {
            this.Type = type;
            this.color = Color.Black;
        }
        public PaintingElement(ToolEnum type, Color color)
        {
            this.Type = type;
            this.color = color;
        }
        public PaintingElement(ToolEnum type, Color color, Point p1)
        {
            this.Type = type;
            this.color = color;
            this.points[0] = p1;
        }
        public PaintingElement(ToolEnum type, Color color, Point p1, Point p2)
        {
            this.Type = type;
            this.color = color;
            this.points[0] = p1;
            this.points[1] = p2;
        }
        public PaintingElement(ToolEnum type, Point p1)
        {
            this.Type = type;
            this.points[0] = p1;
        }
        public PaintingElement(ToolEnum type, Point p1, Point p2)
        {
            this.Type = type;
            this.points[0] = p1;
            this.points[1] = p2;
        }        
        public PaintingElement(ToolEnum type, string name)
        {
            this.Type = type;
            this.Name = name;
            this.color = Color.Black;
        }
        public PaintingElement(ToolEnum type,String name, Color color)
        {
            this.Type = type;
            this.Name = name;
            this.color = color;
        }
        public PaintingElement(ToolEnum type,String name, Color color, Point p1)
        {
            this.Type = type;
            this.Name = name;
            this.color = color;
            this.points[0] = p1;
        }
        public PaintingElement(ToolEnum type,String name, Color color, Point p1, Point p2)
        {
            this.Type = type;
            this.Name = name;
            this.color = color;
            this.points[0] = p1;
            this.points[1] = p2;
        }
        public PaintingElement(ToolEnum type,String name, Point p1)
        {
            this.Type = type;
            this.Name = name;
            this.points[0] = p1;
        }
        public PaintingElement(ToolEnum type,String name, Point p1, Point p2)
        {
            this.Type = type;
            this.Name = name;
            this.points[0] = p1;
            this.points[1] = p2;
        }

        public void DrawElement(Graphics g)
        {
            if (this == null)
            {
                return;
            }
            Brush b = new SolidBrush(color);
            Pen p = TwoPTool.CreatePen(b, 3);
            switch (Type)
            {
                case ToolEnum.Pen:
                    break;
                case ToolEnum.Line:
                    g.DrawLine(p, points[0], points[1]);
                    break;
                case ToolEnum.Rectangle:
                    g.DrawRectangle(p, TwoPTool.CreateRectangle(points[0], points[1]));
                    break;
                case ToolEnum.FillRectangle:
                    g.FillRectangle(b, TwoPTool.CreateRectangle(points[0], points[1]));
                    break;
                case ToolEnum.Text:
                    break;
                case ToolEnum.Eraser:
                    break;
                case ToolEnum.Circle:
                    g.DrawEllipse(p, TwoPTool.CreateRectangle(points[0], points[1]));
                    break;
                case ToolEnum.FillCircle:
                    g.FillEllipse(b, TwoPTool.CreateRectangle(points[0], points[1]));
                    break;
                default:
                    break;
            }
        }
    }
}
