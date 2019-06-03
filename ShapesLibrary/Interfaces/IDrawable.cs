﻿using System.Drawing;

namespace ShapesLibrary.Interfaces
{
    public interface IDrawable
    {
        void DrawMethod(Graphics g);

        void ChangeColor(Color color);
    }
}