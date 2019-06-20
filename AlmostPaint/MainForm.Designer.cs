namespace AlmostPaint
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
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCanvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawARectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawASquareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawALineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawACircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dranAnEllipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawAPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeBiggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeSmallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShapesPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonChangeName = new System.Windows.Forms.Button();
            this.textBoxChangeName = new System.Windows.Forms.TextBox();
            this.buttonResize = new System.Windows.Forms.Button();
            this.buttonResize2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonOpacity = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.ShapesPanel.SuspendLayout();
            this.ControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.commandsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintMainFrame_Paint);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.newCanvasToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.openToolStripMenuItem.Text = "Open ";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // newCanvasToolStripMenuItem
            // 
            this.newCanvasToolStripMenuItem.Name = "newCanvasToolStripMenuItem";
            this.newCanvasToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.newCanvasToolStripMenuItem.Text = "New canvas";
            this.newCanvasToolStripMenuItem.Click += new System.EventHandler(this.newCanvasToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.drawARectangleToolStripMenuItem,
            this.drawASquareToolStripMenuItem,
            this.drawALineToolStripMenuItem,
            this.drawACircleToolStripMenuItem,
            this.dranAnEllipseToolStripMenuItem,
            this.drawAPointToolStripMenuItem,
            this.changeColorToolStripMenuItem,
            this.resizeBiggerToolStripMenuItem,
            this.resizeSmallerToolStripMenuItem});
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.commandsToolStripMenuItem.Text = "Commands";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // drawARectangleToolStripMenuItem
            // 
            this.drawARectangleToolStripMenuItem.Name = "drawARectangleToolStripMenuItem";
            this.drawARectangleToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.drawARectangleToolStripMenuItem.Text = "Draw a rectangle";
            this.drawARectangleToolStripMenuItem.Click += new System.EventHandler(this.drawARectangleToolStripMenuItem_Click);
            // 
            // drawASquareToolStripMenuItem
            // 
            this.drawASquareToolStripMenuItem.Name = "drawASquareToolStripMenuItem";
            this.drawASquareToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.drawASquareToolStripMenuItem.Text = "Draw a square";
            this.drawASquareToolStripMenuItem.Click += new System.EventHandler(this.drawASquareToolStripMenuItem_Click);
            // 
            // drawALineToolStripMenuItem
            // 
            this.drawALineToolStripMenuItem.Name = "drawALineToolStripMenuItem";
            this.drawALineToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.drawALineToolStripMenuItem.Text = "Draw a line";
            this.drawALineToolStripMenuItem.Click += new System.EventHandler(this.drawALineToolStripMenuItem_Click);
            // 
            // drawACircleToolStripMenuItem
            // 
            this.drawACircleToolStripMenuItem.Name = "drawACircleToolStripMenuItem";
            this.drawACircleToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.drawACircleToolStripMenuItem.Text = "Draw a circle";
            this.drawACircleToolStripMenuItem.Click += new System.EventHandler(this.drawACircleToolStripMenuItem_Click);
            // 
            // dranAnEllipseToolStripMenuItem
            // 
            this.dranAnEllipseToolStripMenuItem.Name = "dranAnEllipseToolStripMenuItem";
            this.dranAnEllipseToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.dranAnEllipseToolStripMenuItem.Text = "Dran an ellipse";
            this.dranAnEllipseToolStripMenuItem.Click += new System.EventHandler(this.dranAnEllipseToolStripMenuItem_Click);
            // 
            // drawAPointToolStripMenuItem
            // 
            this.drawAPointToolStripMenuItem.Name = "drawAPointToolStripMenuItem";
            this.drawAPointToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.drawAPointToolStripMenuItem.Text = "Draw a point";
            this.drawAPointToolStripMenuItem.Click += new System.EventHandler(this.drawAPointToolStripMenuItem_Click);
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.changeColorToolStripMenuItem.Text = "Change color";
            this.changeColorToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // resizeBiggerToolStripMenuItem
            // 
            this.resizeBiggerToolStripMenuItem.Name = "resizeBiggerToolStripMenuItem";
            this.resizeBiggerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.resizeBiggerToolStripMenuItem.Text = "Resize bigger";
            this.resizeBiggerToolStripMenuItem.Click += new System.EventHandler(this.resizeBiggerToolStripMenuItem_Click);
            // 
            // resizeSmallerToolStripMenuItem
            // 
            this.resizeSmallerToolStripMenuItem.Name = "resizeSmallerToolStripMenuItem";
            this.resizeSmallerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.resizeSmallerToolStripMenuItem.Text = "Resize smaller";
            this.resizeSmallerToolStripMenuItem.Click += new System.EventHandler(this.resizeSmallerToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ShapesPanel
            // 
            this.ShapesPanel.AutoSize = true;
            this.ShapesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ShapesPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShapesPanel.BackgroundImage")));
            this.ShapesPanel.Controls.Add(this.button1);
            this.ShapesPanel.Controls.Add(this.buttonPoint);
            this.ShapesPanel.Controls.Add(this.buttonEllipse);
            this.ShapesPanel.Controls.Add(this.buttonCircle);
            this.ShapesPanel.Controls.Add(this.buttonLine);
            this.ShapesPanel.Controls.Add(this.buttonSquare);
            this.ShapesPanel.Controls.Add(this.buttonRectangle);
            this.ShapesPanel.Controls.Add(this.buttonSelect);
            this.ShapesPanel.Location = new System.Drawing.Point(0, 23);
            this.ShapesPanel.Name = "ShapesPanel";
            this.ShapesPanel.Size = new System.Drawing.Size(832, 57);
            this.ShapesPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(591, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create Group Shape";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPoint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPoint.FlatAppearance.BorderSize = 2;
            this.buttonPoint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonPoint.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPoint.Location = new System.Drawing.Point(510, 4);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(75, 39);
            this.buttonPoint.TabIndex = 6;
            this.buttonPoint.Text = "Point";
            this.buttonPoint.UseVisualStyleBackColor = false;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEllipse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEllipse.FlatAppearance.BorderSize = 2;
            this.buttonEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEllipse.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEllipse.Location = new System.Drawing.Point(429, 4);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(75, 39);
            this.buttonEllipse.TabIndex = 5;
            this.buttonEllipse.Text = "Ellipse";
            this.buttonEllipse.UseVisualStyleBackColor = false;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCircle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCircle.FlatAppearance.BorderSize = 2;
            this.buttonCircle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonCircle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCircle.Location = new System.Drawing.Point(348, 4);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(75, 39);
            this.buttonCircle.TabIndex = 4;
            this.buttonCircle.Text = "Circle";
            this.buttonCircle.UseVisualStyleBackColor = false;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLine.FlatAppearance.BorderSize = 2;
            this.buttonLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonLine.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLine.Location = new System.Drawing.Point(267, 4);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(75, 39);
            this.buttonLine.TabIndex = 3;
            this.buttonLine.Text = "Line";
            this.buttonLine.UseVisualStyleBackColor = false;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSquare.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSquare.FlatAppearance.BorderSize = 2;
            this.buttonSquare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSquare.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSquare.Location = new System.Drawing.Point(186, 4);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(75, 39);
            this.buttonSquare.TabIndex = 2;
            this.buttonSquare.Text = "Square";
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRectangle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRectangle.FlatAppearance.BorderSize = 2;
            this.buttonRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonRectangle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRectangle.Location = new System.Drawing.Point(105, 4);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(75, 39);
            this.buttonRectangle.TabIndex = 1;
            this.buttonRectangle.Text = "Rectangle";
            this.buttonRectangle.UseVisualStyleBackColor = false;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSelect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelect.Location = new System.Drawing.Point(24, 4);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 39);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "SELECT";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ControlsPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ControlsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ControlsPanel.BackgroundImage")));
            this.ControlsPanel.Controls.Add(this.button3);
            this.ControlsPanel.Controls.Add(this.button2);
            this.ControlsPanel.Controls.Add(this.buttonChangeName);
            this.ControlsPanel.Controls.Add(this.textBoxChangeName);
            this.ControlsPanel.Controls.Add(this.buttonResize2);
            this.ControlsPanel.Controls.Add(this.textBox1);
            this.ControlsPanel.Controls.Add(this.buttonResize);
            this.ControlsPanel.Controls.Add(this.buttonOpacity);
            this.ControlsPanel.Controls.Add(this.buttonColor);
            this.ControlsPanel.Location = new System.Drawing.Point(0, 75);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(87, 380);
            this.ControlsPanel.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "Paste";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonChangeName
            // 
            this.buttonChangeName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChangeName.BackgroundImage")));
            this.buttonChangeName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeName.Location = new System.Drawing.Point(13, 152);
            this.buttonChangeName.Name = "buttonChangeName";
            this.buttonChangeName.Size = new System.Drawing.Size(69, 40);
            this.buttonChangeName.TabIndex = 6;
            this.buttonChangeName.Text = "Change name";
            this.buttonChangeName.UseVisualStyleBackColor = true;
            this.buttonChangeName.Click += new System.EventHandler(this.buttonChangeName_Click);
            // 
            // textBoxChangeName
            // 
            this.textBoxChangeName.Location = new System.Drawing.Point(13, 126);
            this.textBoxChangeName.Name = "textBoxChangeName";
            this.textBoxChangeName.Size = new System.Drawing.Size(69, 20);
            this.textBoxChangeName.TabIndex = 5;
            // 
            // buttonResize
            // 
            this.buttonResize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonResize.BackgroundImage")));
            this.buttonResize.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResize.Location = new System.Drawing.Point(12, 196);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(69, 40);
            this.buttonResize.TabIndex = 3;
            this.buttonResize.Text = " + ";
            this.buttonResize.UseVisualStyleBackColor = true;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // buttonResize2
            // 
            this.buttonResize2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonResize2.BackgroundImage")));
            this.buttonResize2.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResize2.Location = new System.Drawing.Point(12, 240);
            this.buttonResize2.Name = "buttonResize2";
            this.buttonResize2.Size = new System.Drawing.Size(69, 40);
            this.buttonResize2.TabIndex = 4;
            this.buttonResize2.Text = "-";
            this.buttonResize2.UseVisualStyleBackColor = true;
            this.buttonResize2.Click += new System.EventHandler(this.buttonResize2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buttonOpacity
            // 
            this.buttonOpacity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpacity.BackgroundImage")));
            this.buttonOpacity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOpacity.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpacity.Location = new System.Drawing.Point(12, 81);
            this.buttonOpacity.Name = "buttonOpacity";
            this.buttonOpacity.Size = new System.Drawing.Size(69, 40);
            this.buttonOpacity.TabIndex = 1;
            this.buttonOpacity.Text = "Change Opacity";
            this.buttonOpacity.UseVisualStyleBackColor = true;
            this.buttonOpacity.Click += new System.EventHandler(this.buttonOpacity_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.Transparent;
            this.buttonColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonColor.BackgroundImage")));
            this.buttonColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonColor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonColor.Location = new System.Drawing.Point(12, 11);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(69, 40);
            this.buttonColor.TabIndex = 0;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectionLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectionLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SelectionLabel.Location = new System.Drawing.Point(0, 525);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(71, 14);
            this.SelectionLabel.TabIndex = 4;
            this.SelectionLabel.Text = "selection info";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // PaintMainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(832, 539);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.ShapesPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ControlsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PaintMainFrame";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Almost Paint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintMainFrame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaintMainFrame_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintMainFrame_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintMainFrame_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintMainFrame_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ShapesPanel.ResumeLayout(false);
            this.ControlsPanel.ResumeLayout(false);
            this.ControlsPanel.PerformLayout();
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
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonOpacity;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCanvasToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Button buttonResize2;
        private System.Windows.Forms.Button buttonChangeName;
        private System.Windows.Forms.TextBox textBoxChangeName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawARectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawASquareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawALineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawACircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dranAnEllipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawAPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeBiggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeSmallerToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

