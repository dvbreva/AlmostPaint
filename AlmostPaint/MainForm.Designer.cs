﻿namespace AlmostPaint
{
    partial class PaintMainFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintMainFrame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShapesPanel = new System.Windows.Forms.Panel();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.ShapesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintMainFrame_Paint);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ShapesPanel
            // 
            this.ShapesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ShapesPanel.Controls.Add(this.buttonPoint);
            this.ShapesPanel.Controls.Add(this.buttonEllipse);
            this.ShapesPanel.Controls.Add(this.buttonCircle);
            this.ShapesPanel.Controls.Add(this.buttonLine);
            this.ShapesPanel.Controls.Add(this.buttonSquare);
            this.ShapesPanel.Controls.Add(this.buttonRectangle);
            this.ShapesPanel.Controls.Add(this.buttonSelect);
            this.ShapesPanel.Location = new System.Drawing.Point(0, 23);
            this.ShapesPanel.Name = "ShapesPanel";
            this.ShapesPanel.Size = new System.Drawing.Size(832, 42);
            this.ShapesPanel.TabIndex = 2;
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ControlsPanel.Location = new System.Drawing.Point(0, 64);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(44, 230);
            this.ControlsPanel.TabIndex = 3;
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Location = new System.Drawing.Point(9, 428);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(69, 13);
            this.SelectionLabel.TabIndex = 4;
            this.SelectionLabel.Text = "selection info";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(12, 4);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 31);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(93, 4);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(75, 31);
            this.buttonRectangle.TabIndex = 1;
            this.buttonRectangle.Text = "Rectangle";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(174, 4);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(75, 31);
            this.buttonSquare.TabIndex = 2;
            this.buttonSquare.Text = "Square";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(255, 4);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(75, 31);
            this.buttonLine.TabIndex = 3;
            this.buttonLine.Text = "Line";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(336, 4);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(75, 31);
            this.buttonCircle.TabIndex = 4;
            this.buttonCircle.Text = "Circle";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Location = new System.Drawing.Point(417, 4);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(75, 31);
            this.buttonEllipse.TabIndex = 5;
            this.buttonEllipse.Text = "Ellipse";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Location = new System.Drawing.Point(498, 4);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(75, 31);
            this.buttonPoint.TabIndex = 6;
            this.buttonPoint.Text = "Point";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // PaintMainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.ControlsPanel);
            this.Controls.Add(this.ShapesPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PaintMainFrame";
            this.Text = "Almost Paint";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintMainFrame_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintMainFrame_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintMainFrame_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintMainFrame_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ShapesPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel ShapesPanel;
        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonCircle;
    }
}

