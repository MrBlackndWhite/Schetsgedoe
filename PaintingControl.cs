﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace PaintPoging
{
    public class PaintingControl : UserControl
    {
        private Painting p;
        private Color clr;
        public Color color
        {
            get { return clr; }
        }
        public Painting painting
        {
            get { return p; }
        }


        public PaintingControl(Control parent)
        {
            this.Parent = parent;
            this.Size = this.Parent.ClientSize;
            this.Location = Point.Empty;
            p = new Painting(this.ClientSize);
            this.Paint += this.Repaint;
            this.Resize += this.SizeChanged;
        }

        public void AddElement(PaintingElement element)
        {
            p.elements.Add(element);
        }

        private new void SizeChanged(object sender, EventArgs e)
        {
            p.SizeChanged(this.ClientSize);
            Invalidate();
        }

        private void Repaint(object sender, PaintEventArgs e)
        {
            p.Draw(e.Graphics);
        }

        public new Graphics CreateGraphics()
        {
            Graphics g = p.BmpGraphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            return g;
        }
        public void Clear(object o, EventArgs e)
        {
            p.Clear();
            Invalidate();
        }

        public void Rotate(object o, EventArgs e)
        {
            p.SizeChanged(new Size(this.ClientSize.Height, this.ClientSize.Width));
            p.Rotate();
            Invalidate();
        }

        public void ChangeColor(object o, EventArgs e)
        {
            //TODO
        }

        public void ChangeColorWmenu(object o, EventArgs e)
        {
            //TODO
        }
    }
}