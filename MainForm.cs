using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintPoging
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitMenuStrip();
        }

        private void InitMenuStrip()
        {
            itm_File.DropDownItems.Add("New Painting", null, this.New);
            itm_File.DropDownItems.Add("Exit", null, this.Exit);
            itm_Help.DropDownItems.Add("About", null, this.about);
        }

        private void about(object sender, EventArgs e)
        {
            //TODO about
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void New(object sender, EventArgs e)
        {
            ChildForm cf = new ChildForm();
            cf.MdiParent = this;
            cf.Show();
        }
    }
}
