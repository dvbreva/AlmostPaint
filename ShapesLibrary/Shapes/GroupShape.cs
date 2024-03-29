﻿using ShapesLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary.Shapes
{
    public class GroupShape : IDraw, ITranslate, IShape
    {
        public List<IDraw> GroupItems { get; set; }

        public GroupShape()
        {
            this.GroupItems = new List<IDraw>();
        } 


        public void ChangeColor(Color color)
        {
            throw new NotImplementedException();
        }

        public void ChangeName(string desiredName)
        {
            throw new NotImplementedException();
        }

        public bool ContainsPoint(int X, int Y)
        {
            throw new NotImplementedException();
        }

        public void DrawMethod(Graphics g)
        {
            throw new NotImplementedException();
        }

        public string GetInfo()
        {
            throw new NotImplementedException();
        }

        public void ResizeBigger()
        {
            throw new NotImplementedException();
        }

        public void ResizeSmaller()
        {
            throw new NotImplementedException();
        }

        public void TranslateMethod(int dX, int dY)
        {
            throw new NotImplementedException();
        }


        public IDraw CopyShape()
        {
            throw new NotImplementedException();
        }
    }
}
