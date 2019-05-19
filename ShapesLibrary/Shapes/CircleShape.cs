using ShapesLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary.Shapes
{
    public class CircleShape : IDrawable, ITranslatable, IShape
    {
        private Color _color;
        private int x;
        private int y;
        private int shapeWidth;
        private int shapeHeight;

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


        public CircleShape(Color Color, int X, int Y, int width, int height)
        {
            this.Color = Color;
            this.X = X;
            this.Y = Y;
            this.ShapeWidth = width;
            this.ShapeHeight = height;

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
            Pen p = new Pen(Color.Black);
            g.FillEllipse(new SolidBrush(this.Color), X, Y, ShapeWidth, ShapeHeight);
            g.DrawEllipse(p, X, Y, ShapeWidth, ShapeHeight);
        }

        public void TranslateMethod(int dX, int dY)
        {
            this.X += dX;
            this.Y += dY;
        }

    }
}
