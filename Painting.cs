﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Threading;

namespace PaintPoging
{
    public class Painting
    {
        private Color ActiveColor { get; } = Color.Gray;
        private Bitmap bmp;
        private int count = 0;
        public List<PaintingElement> elements = new List<PaintingElement>();
        public PaintingElement CurrentlyDrawing = new PaintingElement(0);
        public Painting(Size s)
        {
            bmp = new Bitmap(s.Width, s.Height);
        }
        public Graphics BmpGraphics
        {
            get { return Graphics.FromImage(bmp); }
        }

        public void ElementCompleted(Color color)
        {
            CurrentlyDrawing.color = color;
            CurrentlyDrawing.priority = count;
            CurrentlyDrawing.Name = CurrentlyDrawing.Type.ToString() + " " + CurrentlyDrawing.priority.ToString();
            elements.Add(CurrentlyDrawing);
            count++;
            CurrentlyDrawing = new PaintingElement(0);
        }

        public void SizeChanged(Size s)
        {
            if (s.Width > bmp.Size.Width || s.Height > bmp.Size.Height)
            {
                Bitmap newbmp = new Bitmap(Math.Max(s.Width, bmp.Size.Width),
                                           Math.Max(s.Height, bmp.Size.Height));
                Graphics g = Graphics.FromImage(newbmp);
                g.DrawImage(bmp, 0, 0);
                bmp = newbmp;
            }
        }

        public void Draw(Graphics g)
        {

            foreach (PaintingElement e in elements)
            {
                e.DrawElement(g);
            }

            CurrentlyDrawing.color = this.ActiveColor;
            CurrentlyDrawing.DrawElement(g);

        }

        public void Clear()
        {
            elements.Clear();

        }

        public void Rotate()
        {
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }
    }
}
