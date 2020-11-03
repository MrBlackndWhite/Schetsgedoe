using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintPoging
{
    public partial class ChildForm : Form
    {
        PaintingControl pc;
        IPaintTool currenTool;
        ResourceManager rsm = new ResourceManager("PaintPoging.Properties.Resources",
            Assembly.GetExecutingAssembly());
        
        public ChildForm()
        {
            InitializeComponent();
        }

        private void SizeChanged(object o, EventArgs e)
        {
            pc.Size = SplitPanel_LR.Panel2.ClientSize;
        }



        private void Clear(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
