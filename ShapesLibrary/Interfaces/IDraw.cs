using System.Drawing;

namespace ShapesLibrary.Interfaces
{
    public interface IDraw
    {
        void DrawMethod(Graphics g);

        void ChangeColor(Color color);

        void ResizeBigger();

        void ResizeSmaller();

        void ChangeName(string desiredName);

        string GetInfo();

        IDraw CopyShape();

       // void AddSelectionBorder();
    }
}
