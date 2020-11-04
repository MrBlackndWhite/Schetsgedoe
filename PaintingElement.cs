using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace PaintPoging
{
    public class PaintingElement
    {
        public ToolEnum Type { get; set; } //type of drawing
        public List<Point> points { get; set; } = new List<Point>();
        public int priority { get; set; } = 0;
        public Color color { get; set; }
        public string Name { get; set; } //name of specified element

        public PaintingElement()
        {
            Type = ToolEnum.None;
            Name = "";
        }
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
            this.points.Add(p1);
            this.points.Add(p2);
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
                    for (int i = 0; i < points.Count-1; i++)
                    {
                        g.DrawLine(p, points.ElementAt(i), points.ElementAt(i+1));
                    }
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

        public bool ContainsPoint(Point p, int maxOffset)
        {
            switch (this.Type)
            {
                case ToolEnum.None:
                    return false;
                case ToolEnum.Pen:
                    foreach (Point point in points)
                    {

                    }
                    return false;
                case ToolEnum.Line:
                    return false;
                case ToolEnum.Rectangle:
                    Size sz = new Size(maxOffset, maxOffset);
                    Rectangle r1 = TwoPTool.CreateRectangle(points.ElementAt(0) - sz, 
                                                            points.ElementAt(1) + sz);
                    Rectangle r2 = TwoPTool.CreateRectangle(points.ElementAt(0) + sz,
                                        points.ElementAt(1) - sz);
                    if (r1.Contains(p) && (!r2.Contains(p)))
                    {
                        return true;
                    }
                    return false;
                case ToolEnum.FillRectangle:
                    if (TwoPTool.CreateRectangle(points.ElementAt(0),points.ElementAt(1)).Contains(p))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case ToolEnum.Text:
                    return false;
                case ToolEnum.Eraser:
                    return false;
                case ToolEnum.Circle:
                    return false;
                case ToolEnum.FillCircle:
                    return false;
                default:
                    return false;
            }
        }
    }
}
