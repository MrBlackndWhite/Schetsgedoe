﻿using System;
using System.Drawing;
using System.Collections.Generic;


namespace PaintPoging
{
    public class Painting
    {
        private Bitmap bmp;
        public List<PaintingElement> elements { get; set; }
        public Painting(Size s)
        {
            bmp = new Bitmap(s.Width, s.Height);
        }
        public Graphics BmpGraphics
        {
            get { return Graphics.FromImage(bmp); }
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
            g.DrawImage(bmp, 0, 0);
        }

        public void Clear()
        {
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

        }

        public void Rotate()
        {
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }
    }
}
