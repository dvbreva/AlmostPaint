﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ShapesLibrary.Interfaces;
using System.Windows.Forms;

namespace ShapesLibrary.Shapes
{
    [Serializable]
    public class PointShape : IDraw, ITranslate, IShape
    {
        private Color _color;
        private int x;
        private int y;
        private int shapeWidth;
        private int shapeHeight;
        private string shapeName;

        public Color Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public int ShapeWidth
        {
            get
            {
                return this.shapeWidth;
            }
            set
            {
                this.shapeWidth = value;
            }
        }

        public int ShapeHeight
        {
            get
            {
                return this.shapeHeight;
            }
            set
            {
                this.shapeHeight = value;
            }
        }

        private string ShapeName
        {
            get
            {
                return this.shapeName;
            }
            set
            {
                this.shapeName = value;
            }
        }


        public PointShape(Color Color, int X, int Y, int width, int height, string name)
        {
            this.Color = Color;
            this.X = X;
            this.Y = Y;
            this.ShapeWidth = width;
            this.ShapeHeight = height;
            this.ShapeName = name;
        }

        public void ChangeColor(Color color)
        {
            this.Color = color;
        }

        public bool ContainsPoint(int X, int Y)
        {
            return X > this.X && Y > this.Y && X < (this.X + this.ShapeWidth) && Y < (this.Y + this.ShapeHeight);
        }

        public void DrawMethod(Graphics g)
        {
            Pen p = new Pen(Color.Black, 3);
            g.FillEllipse(new SolidBrush(Color.Black), X, Y, ShapeWidth, ShapeHeight);
            g.DrawEllipse(p, X, Y, ShapeWidth, ShapeHeight);
        }

        public void TranslateMethod(int dX, int dY)
        {
            this.X += dX;
            this.Y += dY;
        }

        public void ResizeBigger()
        {
            MessageBox.Show("You cannot make this dot bigger.");
        }

        public void ResizeSmaller()
        {
            MessageBox.Show("You cannot make this dot smaller.");
        }

        public void ChangeName(string desiredName)
        {
            this.ShapeName = desiredName;
        }

        public string GetInfo()
        {
            return "\n > Shape name : " + this.ShapeName
                + "\n > Shape width : " + this.ShapeWidth
                + "\n > Shape height : " + this.ShapeHeight
                + "\n > Shape color : " + this.Color
                + "\n > Shape coordinates (x,y) : " + "(" + this.X + "," + this.Y + ")";
        }


        public IDraw CopyShape()
        {
            PointShape copiedPointShape = new PointShape(Color, X, Y, ShapeWidth, ShapeHeight, ShapeName);

            return copiedPointShape;
        }
    }
}
