﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PaintPoging
{
    public partial class ChildForm : Form
    {
        private PaintingControl pc;
        private Color currentColor { get; set; } = Color.Red;
        private ToolEnum currentToolEnum;
        private IPaintTool currenTool;
        private bool isMouseDown = false;
        //private ResourceManager rsm = new ResourceManager("PaintPoging.Properties.Resources",
        //    Assembly.GetExecutingAssembly());
        private IPaintTool[] tools { get; } = Tools.CreateAllTools();
        private List<ToolStripButton> TSButtons { get; set; } = new List<ToolStripButton>();


        public ChildForm()
        {
            InitializeComponent(); //do a lot of visual stuff with the VS designer
            SetToolTags();
            SetToolEventHandlers();

            currenTool = tools[(int)ToolEnum.Pen];
            pc = new PaintingControl(this.SplitPanel_LR.Panel2);

            pc.MouseDown += this.Pc_MouseDown;
            pc.MouseMove += this.Pc_MouseMove;
            pc.MouseUp += this.Pc_MouseUp;
            pc.KeyPress += this.Pc_KeyPress;
            this.SplitPanel_LR.Panel2.Controls.Add(pc);
            TSitm_clear.Click += pc.Clear;
            this.Resize += this.SizeChanged;
        }

        private void Pc_KeyPress(object sender, KeyPressEventArgs e)
        {
            currenTool.Letter(pc, e.KeyChar);
        }

        private void Pc_MouseUp(object sender, MouseEventArgs e)
        {
            pc.ElementCompleted(currentColor);
            //currenTool.MBUp(pc, e.Location);
            isMouseDown = false;
            Console.WriteLine("mup");
            pc.Invalidate();
        }

        private void Pc_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                pc.EndPointActive(e.Location);
                //currenTool.MBDrag(pc, e.Location);
                Console.WriteLine("mdrag");
                pc.Invalidate();
            }
        }

        private void Pc_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            pc.StartPointActive(currentToolEnum, e.Location);
            //currenTool.MBDown(pc, e.Location);
            Console.WriteLine("mdown");
        }

        private void SetToolTags()
        {
            this.TSitm_Pen.Tag = ToolEnum.Pen;
            this.TSitm_Line.Tag = ToolEnum.Line;
            this.TSitm_Rectangle.Tag = ToolEnum.Rectangle;
            this.TSitm_FillRectangle.Tag = ToolEnum.FillRectangle;
            this.TSitm_Text.Tag = ToolEnum.Text;
            this.TSitm_Circle.Tag = ToolEnum.Circle;
            this.TSitm_Eraser.Tag = ToolEnum.Eraser;
            this.TSitm_fillCircle.Tag = ToolEnum.FillCircle;
        }

        private void SetToolEventHandlers()
        {
            foreach (ToolStripItem item in TS_Top.Items)
            {
                if (!(item is ToolStripSeparator))
                {
                    ToolStripButton temp = item as ToolStripButton;
                    // mousedown => checkedchanged => checkstatechanged => click => mouseup
                    temp.CheckStateChanged += this.ToolCheckStateChanged;
                    item.Click += this.ToolClicked;         //button.checked al veranderd
                    this.TSButtons.Add((ToolStripButton)item);
                }
            }
        }

        private new void SizeChanged(object o, EventArgs e)
        {
            pc.Size = SplitPanel_LR.Panel2.ClientSize;
        }

        private void ToolClicked(object o, EventArgs e)
        {
            ToolStripButton btn = o as ToolStripButton;
            currenTool = tools.ElementAt((int)(ToolEnum)btn.Tag);
            currentToolEnum = (ToolEnum)btn.Tag;
            foreach (ToolStripButton item in this.TSButtons)
            {
                item.Checked = false;
                item.CheckState = CheckState.Unchecked;
                if (item == btn)
                {
                    item.Checked = true;
                    item.CheckState = CheckState.Checked;
                }
                ToolCheckStateChanged(item, e);
                Console.WriteLine(item.Tag.ToString());
                Console.WriteLine("checked" + item.Checked.ToString());
                Console.WriteLine("checkstate" + item.CheckState.ToString());
                Console.WriteLine(item.BackColor.ToString());
            }
            TS_Top.Invalidate();
        }

        private void ToolCheckStateChanged(object o, EventArgs e)
        {
            ToolStripButton temp = o as ToolStripButton;
            switch (temp.CheckState)
            {
                case CheckState.Unchecked:
                    temp.BackColor = Color.Red;
                    break;
                case CheckState.Checked:
                    temp.BackColor = Color.Yellow;
                    temp.ForeColor = Color.Yellow;
                    break;
                case CheckState.Indeterminate:
                    temp.BackColor = Color.Red;
                    break;
                default:
                    temp.BackColor = Color.Red;
                    break;
            }
        }
    }
}
