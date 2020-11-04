using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintPoging
{
    public partial class ChildForm : Form
    {
        private PaintingControl pc;
        private IPaintTool currenTool;
        private bool isMouseDown { get; set; } = false;
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
            pc = new PaintingControl(SplitPanel_LR.Panel2);
            pc.MouseDown += (object o, MouseEventArgs e) =>
            {
                isMouseDown = true;
                currenTool.MBDown(pc, e.Location);
            };
            pc.MouseMove += (object o, MouseEventArgs e) =>
            {
                if (isMouseDown)
                {
                    currenTool.MBDrag(pc, e.Location);
                }
            };
            pc.MouseUp += (object o, MouseEventArgs e) =>
            {
                if (isMouseDown)
                {
                    currenTool.MBUp(pc, e.Location);
                    isMouseDown = false;
                }
            };
            pc.KeyPress += (object o, KeyPressEventArgs e) =>
            {
                currenTool.Letter(pc, e.KeyChar);
            };

            this.Controls.Add(pc);
            this.Resize += this.SizeChanged;
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
        }

        private void SetToolEventHandlers()
        {
            foreach (ToolStripItem item in TS.Items)
            {
                if ((!(item is ToolStripSeparator)) && item.Enabled) //TODO FIX CLEAR AND ROTATE BTN
                {
                    ToolStripButton temp = item as ToolStripButton;
                    // mousedown => checkedchanged => checkstatechanged => click => mouseup
                    temp.MouseDown += this.ToolMouseDown;   //button.checked niet veranderd
                    temp.CheckStateChanged += this.ToolCheckStateChanged;
                    item.MouseUp += this.ToolMouseUp;         //button.checked al veranderd
                    this.TSButtons.Add((ToolStripButton)item);
                }
            }
        }

        private void ToolCheckStateChanged(object sender, EventArgs e)
        {
            ToolStripButton temp = sender as ToolStripButton;
            switch (temp.CheckState)
            {
                case CheckState.Unchecked:
                    temp.BackColor = Color.Red;
                    break;
                case CheckState.Checked:
                    temp.BackColor = Color.Blue;
                    break;
                case CheckState.Indeterminate:
                    temp.BackColor = Color.Red;
                    break;
                default:
                    temp.BackColor = Color.Red;
                    break;
            }
        }



        private new void SizeChanged(object o, EventArgs e)
        {
            pc.Size = SplitPanel_LR.Panel2.ClientSize;
        }



        private void Clear(object o, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void ToolMouseDown(object o, MouseEventArgs e)
        {
            ToolStripButton button = o as ToolStripButton;
            currenTool = this.tools[(int)button.Tag];
            foreach (ToolStripButton item in TSButtons)
            {
                if (item.Checked)
                {
                    item.PerformClick();
                }
                Console.WriteLine(item.ToolTipText + "  " + item.Checked.ToString());
            // mousedown => checkedchanged => checkstatechanged => click => mouseup
            }
        }
        private void ToolMouseUp(object sender, EventArgs e)
        {
            ToolStripButton temp = sender as ToolStripButton;
            Console.WriteLine("clickety");
            Console.WriteLine(temp.ToolTipText + "  " + temp.Checked.ToString());
            TS.Refresh();
        }
    }
}
