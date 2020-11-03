namespace PaintPoging
{
    partial class ChildForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildForm));
            this.SplitPanel_LR = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSitm_clear = new System.Windows.Forms.ToolStripButton();
            this.TSitm_rotate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSitm_Pen = new System.Windows.Forms.ToolStripButton();
            this.TSitm_Line = new System.Windows.Forms.ToolStripButton();
            this.TSitm_Rectangle = new System.Windows.Forms.ToolStripButton();
            this.TSitm_FillRectangle = new System.Windows.Forms.ToolStripButton();
            this.TSitm_Text = new System.Windows.Forms.ToolStripButton();
            this.TSitm_Eraser = new System.Windows.Forms.ToolStripButton();
            this.TSitm_Circle = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPanel_LR)).BeginInit();
            this.SplitPanel_LR.Panel2.SuspendLayout();
            this.SplitPanel_LR.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitPanel_LR
            // 
            this.SplitPanel_LR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitPanel_LR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitPanel_LR.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitPanel_LR.IsSplitterFixed = true;
            this.SplitPanel_LR.Location = new System.Drawing.Point(0, 0);
            this.SplitPanel_LR.Name = "SplitPanel_LR";
            // 
            // SplitPanel_LR.Panel1
            // 
            this.SplitPanel_LR.Panel1.AutoScroll = true;
            this.SplitPanel_LR.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            // 
            // SplitPanel_LR.Panel2
            // 
            this.SplitPanel_LR.Panel2.Controls.Add(this.toolStrip1);
            this.SplitPanel_LR.Size = new System.Drawing.Size(816, 490);
            this.SplitPanel_LR.SplitterDistance = 120;
            this.SplitPanel_LR.SplitterWidth = 2;
            this.SplitPanel_LR.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSitm_clear,
            this.TSitm_rotate,
            this.toolStripSeparator1,
            this.TSitm_Pen,
            this.TSitm_Line,
            this.TSitm_Rectangle,
            this.TSitm_FillRectangle,
            this.TSitm_Text,
            this.TSitm_Eraser,
            this.TSitm_Circle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(692, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSitm_clear
            // 
            this.TSitm_clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_clear.Image = ((System.Drawing.Image)(resources.GetObject("TSitm_clear.Image")));
            this.TSitm_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSitm_clear.Name = "TSitm_clear";
            this.TSitm_clear.Size = new System.Drawing.Size(29, 28);
            this.TSitm_clear.Text = "Clear Panel";
            // 
            // TSitm_rotate
            // 
            this.TSitm_rotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_rotate.Image = ((System.Drawing.Image)(resources.GetObject("TSitm_rotate.Image")));
            this.TSitm_rotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSitm_rotate.Name = "TSitm_rotate";
            this.TSitm_rotate.Size = new System.Drawing.Size(29, 28);
            this.TSitm_rotate.Text = "Rotate";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // TSitm_Pen
            // 
            this.TSitm_Pen.CheckOnClick = true;
            this.TSitm_Pen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_Pen.Image = global::PaintPoging.Properties.Resources.pen;
            this.TSitm_Pen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSitm_Pen.Name = "TSitm_Pen";
            this.TSitm_Pen.Size = new System.Drawing.Size(29, 28);
            this.TSitm_Pen.Text = "toolStripButton1";
            // 
            // TSitm_Line
            // 
            this.TSitm_Line.CheckOnClick = true;
            this.TSitm_Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_Line.Image = global::PaintPoging.Properties.Resources.line;
            this.TSitm_Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSitm_Line.Name = "TSitm_Line";
            this.TSitm_Line.Size = new System.Drawing.Size(29, 28);
            this.TSitm_Line.Text = "toolStripButton1";
            // 
            // TSitm_Rectangle
            // 
            this.TSitm_Rectangle.CheckOnClick = true;
            this.TSitm_Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_Rectangle.Image = global::PaintPoging.Properties.Resources.rect;
            this.TSitm_Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSitm_Rectangle.Name = "TSitm_Rectangle";
            this.TSitm_Rectangle.Size = new System.Drawing.Size(29, 28);
            this.TSitm_Rectangle.Text = "toolStripButton1";
            // 
            // TSitm_FillRectangle
            // 
            this.TSitm_FillRectangle.CheckOnClick = true;
            this.TSitm_FillRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_FillRectangle.Image = global::PaintPoging.Properties.Resources.fillrect;
            this.TSitm_FillRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSitm_FillRectangle.Name = "TSitm_FillRectangle";
            this.TSitm_FillRectangle.Size = new System.Drawing.Size(29, 28);
            this.TSitm_FillRectangle.Text = "toolStripButton1";
            // 
            // TSitm_Text
            // 
            this.TSitm_Text.CheckOnClick = true;
            this.TSitm_Text.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_Text.Image = global::PaintPoging.Properties.Resources.text;
            this.TSitm_Text.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSitm_Text.Name = "TSitm_Text";
            this.TSitm_Text.Size = new System.Drawing.Size(29, 28);
            this.TSitm_Text.Text = "toolStripButton1";
            // 
            // TSitm_Eraser
            // 
            this.TSitm_Eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TSitm_Eraser.CheckOnClick = true;
            this.TSitm_Eraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_Eraser.Image = global::PaintPoging.Properties.Resources.eraser;
            this.TSitm_Eraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSitm_Eraser.Name = "TSitm_Eraser";
            this.TSitm_Eraser.Size = new System.Drawing.Size(29, 28);
            this.TSitm_Eraser.Text = "toolStripButton1";
            // 
            // TSitm_Circle
            // 
            this.TSitm_Circle.CheckOnClick = true;
            this.TSitm_Circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_Circle.Image = global::PaintPoging.Properties.Resources.circle;
            this.TSitm_Circle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSitm_Circle.Name = "TSitm_Circle";
            this.TSitm_Circle.Size = new System.Drawing.Size(29, 28);
            this.TSitm_Circle.Text = "Draw a Circle";
            this.TSitm_Circle.ToolTipText = "Draw a Circle";
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 490);
            this.Controls.Add(this.SplitPanel_LR);
            this.Name = "ChildForm";
            this.Text = "PaintWindow";
            this.SplitPanel_LR.Panel2.ResumeLayout(false);
            this.SplitPanel_LR.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPanel_LR)).EndInit();
            this.SplitPanel_LR.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitPanel_LR;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSitm_clear;
        private System.Windows.Forms.ToolStripButton TSitm_rotate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSitm_Pen;
        private System.Windows.Forms.ToolStripButton TSitm_Line;
        private System.Windows.Forms.ToolStripButton TSitm_Rectangle;
        private System.Windows.Forms.ToolStripButton TSitm_FillRectangle;
        private System.Windows.Forms.ToolStripButton TSitm_Text;
        private System.Windows.Forms.ToolStripButton TSitm_Eraser;
        private System.Windows.Forms.ToolStripButton TSitm_Circle;
    }
}