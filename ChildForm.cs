using System;
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
        private int offSet = 10;
        //private IPaintTool currenTool;
        private bool isMouseDown = false;
        private PaintingElement Selected;
        //private ResourceManager rsm = new ResourceManager("PaintPoging.Properties.Resources",
        //    Assembly.GetExecutingAssembly());
        //private IPaintTool[] tools { get; } = Tools.CreateAllTools();
        private List<ToolStripButton> TSButtons { get; set; } = new List<ToolStripButton>();


        public ChildForm()
        {
            InitializeComponent(); //do a lot of visual stuff with the VS designer
            SetToolTags();
            SetToolEventHandlers();

            //currenTool = tools[(int)ToolEnum.Pen];
            pc = new PaintingControl(this.SplitPanel_LR.Panel2);

            pc.MouseDown += this.Pc_MouseDown;
            pc.MouseMove += this.Pc_MouseMove;
            pc.MouseUp += this.Pc_MouseUp;
            //pc.KeyPress += this.Pc_KeyPress;
            this.SplitPanel_LR.Panel2.Controls.Add(pc);
            TSitm_clear.Click += pc.Clear;
            TSitm_select.Click += this.SelectTool;
            TSitm_Eraser.Click += this.EraseSelected;
            LB_elements.SelectedValueChanged += this.OnSelectFromList;
            this.Resize += this.SizeChanged;
        }

        private void OnSelectFromList(object sender, EventArgs e)
        {
            SelectTool(null, null); //deselect all other tools
            if (LB_elements.SelectedIndex > -1)
            {
                Selected = pc.FindElement((String)LB_elements.Items[LB_elements.SelectedIndex]);
            }
        }

        private void EraseSelected(object sender, EventArgs e)
        {
            if (Selected != null && Selected.Type != ToolEnum.None)
            {
                pc.DeleteElement(Selected.Name);
                Selected = new PaintingElement();
                pc.Invalidate();
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Please select a layer to delete before pressing the EraserTool.");
            }
        }

        private void SelectTool(object sender, EventArgs e)
        {
            foreach (ToolStripButton b in TSButtons)
            {
                b.Checked = false;
                b.CheckState = CheckState.Unchecked;
            }
            currentToolEnum = ToolEnum.None;
            TS_Top.Invalidate();
        }

        private void UpdateListBox()
        {
            LB_elements.BeginUpdate();
            LB_elements.Items.Clear();
            foreach (PaintingElement e in pc.painting.elements)
            {
                LB_elements.Items.Add(e.Name.ToString());
            }
            LB_elements.EndUpdate();
            LB_elements.Invalidate();
        }

        /*        private void Pc_KeyPress(object sender, KeyPressEventArgs e)
                {
                    currenTool.Letter(pc, e.KeyChar);
                }*/

        private void Pc_MouseUp(object o, MouseEventArgs e)
        {
            if (currentToolEnum != ToolEnum.None)
            {
                pc.ElementCompleted(currentColor);
                //currenTool.MBUp(pc, e.Location);
                isMouseDown = false;
                UpdateListBox();
                pc.Invalidate();
            }

        }

        private void Pc_MouseMove(object o, MouseEventArgs e)
        {
            if (isMouseDown && currentToolEnum != ToolEnum.None)
            {
                pc.EndPointActive(e.Location);
                //currenTool.MBDrag(pc, e.Location);
                pc.Invalidate();
            }
        }

        private void Pc_MouseDown(object o, MouseEventArgs e)
        {
            if (currentToolEnum == ToolEnum.None)
            {
                SelectCheck(o, e);
                return;
            }
            else
            {
                isMouseDown = true;
                pc.StartPointActive(currentToolEnum, e.Location);
            }
            //currenTool.MBDown(pc, e.Location);
        }

        private void SelectCheck(object o, MouseEventArgs e)
        {
            for (int i = pc.painting.elements.Count-1; i >= 0; i--)
            {
                if (pc.painting.elements[i].ContainsPoint(e.Location,offSet))
                {
                    this.Selected = pc.painting.elements[i];
                    OnSelectFromPC();
                    return;
                }
            }
            LB_elements.ClearSelected();
        }

        private void OnSelectFromPC()
        {
            String element;
            for (int i = 0; i < LB_elements.Items.Count; i++)
            {
                element = (String)LB_elements.Items[i];
                if (element == Selected.Name)
                {
                    LB_elements.SetSelected(i, true);
                }
                else
                {
                    LB_elements.SetSelected(i, false);
                }
            }
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
            this.TSitm_select.Tag = ToolEnum.None;
        }

        private void SetToolEventHandlers()
        {
            foreach (ToolStripButton item in TS_Top.Items)
            {
                ToolStripButton temp = item as ToolStripButton;
                // mousedown => checkedchanged => checkstatechanged => click => mouseup
                temp.CheckStateChanged += this.ToolCheckStateChanged;
                item.Click += this.ToolClicked;         //button.checked al veranderd
                this.TSButtons.Add((ToolStripButton)item);
            }
        }
        private new void SizeChanged(object o, EventArgs e)
        {
            pc.Size = SplitPanel_LR.Panel2.ClientSize;
        }

        private void ToolClicked(object o, EventArgs e)
        {
            ToolStripButton btn = o as ToolStripButton;
            //currenTool = tools.ElementAt((int)(ToolEnum)btn.Tag);
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
