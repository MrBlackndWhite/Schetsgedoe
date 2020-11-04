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
            this.TS = new System.Windows.Forms.ToolStrip();
            this.TSmisc_seperator = new System.Windows.Forms.ToolStripSeparator();
            this.TSitm_clear = new System.Windows.Forms.ToolStripButton();
            this.TSitm_rotate = new System.Windows.Forms.ToolStripButton();
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
            this.TS.SuspendLayout();
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
            this.SplitPanel_LR.Panel2.Controls.Add(this.TS);
            this.SplitPanel_LR.Size = new System.Drawing.Size(816, 490);
            this.SplitPanel_LR.SplitterDistance = 120;
            this.SplitPanel_LR.SplitterWidth = 2;
            this.SplitPanel_LR.TabIndex = 0;
            // 
            // TS
            // 
            this.TS.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSitm_clear,
            this.TSitm_rotate,
            this.TSmisc_seperator,
            this.TSitm_Pen,
            this.TSitm_Line,
            this.TSitm_Rectangle,
            this.TSitm_FillRectangle,
            this.TSitm_Text,
            this.TSitm_Eraser,
            this.TSitm_Circle});
            this.TS.Location = new System.Drawing.Point(0, 0);
            this.TS.Name = "TS";
            this.TS.Size = new System.Drawing.Size(692, 27);
            this.TS.TabIndex = 0;
            this.TS.Text = "toolStrip1";
            // 
            // TSmisc_seperator
            // 
            this.TSmisc_seperator.Name = "TSmisc_seperator";
            this.TSmisc_seperator.Size = new System.Drawing.Size(6, 27);
            // 
            // TSitm_clear
            // 
            this.TSitm_clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_clear.Enabled = false;
            this.TSitm_clear.Image = ((System.Drawing.Image)(resources.GetObject("TSitm_clear.Image")));
            this.TSitm_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSitm_clear.Name = "TSitm_clear";
            this.TSitm_clear.Size = new System.Drawing.Size(29, 24);
            this.TSitm_clear.Text = "Clear Panel";
            // 
            // TSitm_rotate
            // 
            this.TSitm_rotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_rotate.Enabled = false;
            this.TSitm_rotate.Image = ((System.Drawing.Image)(resources.GetObject("TSitm_rotate.Image")));
            this.TSitm_rotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSitm_rotate.Name = "TSitm_rotate";
            this.TSitm_rotate.Size = new System.Drawing.Size(29, 24);
            this.TSitm_rotate.Text = "Rotate";
            // 
            // TSitm_Pen
            // 
            this.TSitm_Pen.BackColor = System.Drawing.Color.White;
            this.TSitm_Pen.CheckOnClick = true;
            this.TSitm_Pen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_Pen.ForeColor = System.Drawing.Color.Transparent;
            this.TSitm_Pen.Image = global::PaintPoging.Properties.Resources.pen;
            this.TSitm_Pen.ImageTransparentColor = System.Drawing.Color.MediumSeaGreen;
            this.TSitm_Pen.Name = "TSitm_Pen";
            this.TSitm_Pen.Size = new System.Drawing.Size(29, 24);
            this.TSitm_Pen.Tag = "";
            this.TSitm_Pen.Text = "Pen";
            // 
            // TSitm_Line
            // 
            this.TSitm_Line.BackColor = System.Drawing.Color.White;
            this.TSitm_Line.CheckOnClick = true;
            this.TSitm_Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_Line.ForeColor = System.Drawing.Color.Transparent;
            this.TSitm_Line.Image = global::PaintPoging.Properties.Resources.line;
            this.TSitm_Line.ImageTransparentColor = System.Drawing.Color.MediumSeaGreen;
            this.TSitm_Line.Name = "TSitm_Line";
            this.TSitm_Line.Size = new System.Drawing.Size(29, 24);
            this.TSitm_Line.Tag = "line";
            this.TSitm_Line.Text = "Line";
            this.TSitm_Line.ToolTipText = "Line";
            // 
            // TSitm_Rectangle
            // 
            this.TSitm_Rectangle.BackColor = System.Drawing.Color.White;
            this.TSitm_Rectangle.CheckOnClick = true;
            this.TSitm_Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_Rectangle.ForeColor = System.Drawing.Color.Transparent;
            this.TSitm_Rectangle.Image = global::PaintPoging.Properties.Resources.rect;
            this.TSitm_Rectangle.ImageTransparentColor = System.Drawing.Color.MediumSeaGreen;
            this.TSitm_Rectangle.Name = "TSitm_Rectangle";
            this.TSitm_Rectangle.Size = new System.Drawing.Size(29, 24);
            this.TSitm_Rectangle.Tag = "rect";
            this.TSitm_Rectangle.Text = "Rectangle";
            // 
            // TSitm_FillRectangle
            // 
            this.TSitm_FillRectangle.BackColor = System.Drawing.Color.White;
            this.TSitm_FillRectangle.CheckOnClick = true;
            this.TSitm_FillRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_FillRectangle.ForeColor = System.Drawing.Color.Transparent;
            this.TSitm_FillRectangle.Image = global::PaintPoging.Properties.Resources.fillrect;
            this.TSitm_FillRectangle.ImageTransparentColor = System.Drawing.Color.MediumSeaGreen;
            this.TSitm_FillRectangle.Name = "TSitm_FillRectangle";
            this.TSitm_FillRectangle.Size = new System.Drawing.Size(29, 24);
            this.TSitm_FillRectangle.Tag = "fillrect";
            this.TSitm_FillRectangle.Text = "Fill Rectangle";
            // 
            // TSitm_Text
            // 
            this.TSitm_Text.BackColor = System.Drawing.Color.White;
            this.TSitm_Text.CheckOnClick = true;
            this.TSitm_Text.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_Text.ForeColor = System.Drawing.Color.Transparent;
            this.TSitm_Text.Image = global::PaintPoging.Properties.Resources.text;
            this.TSitm_Text.ImageTransparentColor = System.Drawing.Color.MediumSeaGreen;
            this.TSitm_Text.Name = "TSitm_Text";
            this.TSitm_Text.Size = new System.Drawing.Size(29, 24);
            this.TSitm_Text.Tag = "text";
            this.TSitm_Text.Text = "Text";
            // 
            // TSitm_Eraser
            // 
            this.TSitm_Eraser.BackColor = System.Drawing.Color.White;
            this.TSitm_Eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TSitm_Eraser.CheckOnClick = true;
            this.TSitm_Eraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_Eraser.ForeColor = System.Drawing.Color.Transparent;
            this.TSitm_Eraser.Image = global::PaintPoging.Properties.Resources.eraser;
            this.TSitm_Eraser.ImageTransparentColor = System.Drawing.Color.MediumSeaGreen;
            this.TSitm_Eraser.Name = "TSitm_Eraser";
            this.TSitm_Eraser.Size = new System.Drawing.Size(29, 24);
            this.TSitm_Eraser.Tag = "eraser";
            this.TSitm_Eraser.Text = "Eraser";
            // 
            // TSitm_Circle
            // 
            this.TSitm_Circle.BackColor = System.Drawing.Color.White;
            this.TSitm_Circle.CheckOnClick = true;
            this.TSitm_Circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSitm_Circle.ForeColor = System.Drawing.Color.Transparent;
            this.TSitm_Circle.Image = global::PaintPoging.Properties.Resources.circle;
            this.TSitm_Circle.ImageTransparentColor = System.Drawing.Color.MediumSeaGreen;
            this.TSitm_Circle.Name = "TSitm_Circle";
            this.TSitm_Circle.Size = new System.Drawing.Size(29, 24);
            this.TSitm_Circle.Tag = "circle";
            this.TSitm_Circle.Text = "Circle";
            this.TSitm_Circle.ToolTipText = "Circle";
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
            this.TS.ResumeLayout(false);
            this.TS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitPanel_LR;
        private System.Windows.Forms.ToolStrip TS;
        private System.Windows.Forms.ToolStripButton TSitm_clear;
        private System.Windows.Forms.ToolStripButton TSitm_rotate;
        private System.Windows.Forms.ToolStripSeparator TSmisc_seperator;
        private System.Windows.Forms.ToolStripButton TSitm_Pen;
        private System.Windows.Forms.ToolStripButton TSitm_Line;
        private System.Windows.Forms.ToolStripButton TSitm_Rectangle;
        private System.Windows.Forms.ToolStripButton TSitm_FillRectangle;
        private System.Windows.Forms.ToolStripButton TSitm_Text;
        private System.Windows.Forms.ToolStripButton TSitm_Eraser;
        private System.Windows.Forms.ToolStripButton TSitm_Circle;
    }
}