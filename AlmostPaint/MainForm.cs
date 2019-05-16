﻿using ShapesLibrary.Interfaces;
using ShapesLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AlmostPaint
{
    public partial class PaintMainFrame : Form
    {
        int X;
        int Y;
        public int Selection = 1;
        public IDrawable SelectedItem = null;
        public List<IDrawable> ItemsList = new List<IDrawable>();

        public PaintMainFrame()
        {
            InitializeComponent();
        }

        //buttons
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            Selection = 1;
            SelectionLabel.Text = "You have selected Select tool.";
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            Selection = 2;
            SelectionLabel.Text = "You have selected Rectangle tool.";
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            Selection = 3;
            SelectionLabel.Text = "You have selected Square tool.";
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            Selection = 4;
            SelectionLabel.Text = "You have selected Line tool.";
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            Selection = 5;
            SelectionLabel.Text = "You have selected Circle tool.";
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            Selection = 6;
            SelectionLabel.Text = "You have selected Ellipse tool.";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            Selection = 7;
            SelectionLabel.Text = "You have selected Point tool.";
        }

        private void PaintMainFrame_MouseDown(object sender, MouseEventArgs e)
        {
            if (Selection == 1)
            {
                foreach (IDrawable drawnItem in ItemsList)
                {
                    if (drawnItem is IShape)
                    {
                        if (((IShape)drawnItem).ContainsPoint(e.X, e.Y))
                        {
                            SelectedItem = drawnItem;
                            break;
                        }
                    }
                }
            }

            if (Selection == 2)
            {
                RectangleShape item = new RectangleShape(e.X - 25, e.Y - 50, 150, 50);
                ItemsList.Add(item);
            }

            if(Selection == 3)
            {
                SquareShape item = new SquareShape(e.X - 25, e.Y - 50, 100, 100);
                ItemsList.Add(item);
            }

            if(Selection == 4)
            {
                LineShape item = new LineShape(e.X - 25, e.Y - 50, 100, 5);
                ItemsList.Add(item);
            }

            if(Selection == 5)
            {
                CircleShape item = new CircleShape(e.X - 25, e.Y - 50, 100, 100);
                ItemsList.Add(item);
            }

            if(Selection == 6)
            {
                EllipseShape item = new EllipseShape(e.X - 25, e.Y - 50, 150, 100);
                ItemsList.Add(item);
            }

            if(Selection == 7)
            {
                PointShape item = new PointShape(e.X - 25, e.Y - 50, 10, 10);
                ItemsList.Add(item);
            }

            this.Refresh();
        }

        private void PaintMainFrame_Paint(object sender, PaintEventArgs e)
        {
            foreach (IDrawable item in ItemsList)
            {
                item.DrawMethod(e.Graphics);
            }
        }

        private void PaintMainFrame_MouseUp(object sender, MouseEventArgs e)
        {
            SelectedItem = null;
        }

        private void PaintMainFrame_MouseMove(object sender, MouseEventArgs e)
        {
            if (SelectedItem != null && SelectedItem is ITranslatable)
            {
                int dX = e.X - this.X;
                int dY = e.Y - this.Y;

                ((ITranslatable)SelectedItem).TranslateMethod(dX, dY);
                this.Refresh();
            }

            this.X = e.X;
            this.Y = e.Y;
        }

      
    }
}

