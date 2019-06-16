using ShapesLibrary.Interfaces;
using ShapesLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
        public Color NewSelectedColor;
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

        private void buttonColor_Click(object sender, EventArgs e)
        {
            Selection = 8;
            SelectionLabel.Text = "You have selected to change color.";
        }

        private void buttonOpacity_Click(object sender, EventArgs e)
        {
            Selection = 9;
            SelectionLabel.Text = "You have selected to change opacity.";
        }

        private void buttonResize_Click(object sender, EventArgs e)
        {
            Selection = 10;
            SelectionLabel.Text = "You have selected to resize shape.";
        }

        private void buttonResize2_Click(object sender, EventArgs e)
        {
            Selection = 11;
            SelectionLabel.Text = "You have selected to resize shape.";
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
                RectangleShape item = new RectangleShape(NewSelectedColor, e.X - 25, e.Y - 50, 150, 50);
                ItemsList.Add(item);
            }

            if (Selection == 3)
            {
                SquareShape item = new SquareShape(NewSelectedColor, e.X - 25, e.Y - 50, 100, 100);
                ItemsList.Add(item);
            }

            if (Selection == 4)
            {
                LineShape item = new LineShape(NewSelectedColor, e.X - 25, e.Y - 50, 100, 5);
                ItemsList.Add(item);
            }

            if (Selection == 5)
            {
                CircleShape item = new CircleShape(NewSelectedColor, e.X - 25, e.Y - 50, 100, 100);
                ItemsList.Add(item);
            }

            if (Selection == 6)
            {
                EllipseShape item = new EllipseShape(NewSelectedColor, e.X - 25, e.Y - 50, 150, 100);
                ItemsList.Add(item);
            }

            if (Selection == 7)
            {
                PointShape item = new PointShape(NewSelectedColor, e.X - 25, e.Y - 50, 10, 10);
                ItemsList.Add(item);
            }

            if (Selection == 8)
            {
                // !somewhat working -> tova e kato si izbera cvqt da gi risuva s nego :D  
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    NewSelectedColor = colorDialog1.Color;
                }



                foreach (IDrawable drawnItem in ItemsList)
                {
                    if (drawnItem is IShape)
                    {
                        if (((IShape)drawnItem).ContainsPoint(e.X, e.Y))
                        {
                            SelectedItem = drawnItem;
                            if (colorDialog1.ShowDialog() == DialogResult.OK)
                            {
                                drawnItem.ChangeColor(colorDialog1.Color);
                                //   items.Add(item);
                                this.Refresh();
                            }
                        }
                    }
                    Selection = 1;
                }
                SelectedItem = null;
            }

            if (Selection == 9)
            {
                int opValue = int.Parse(textBox1.Text.ToString());
                if (opValue >= 0 && opValue <= 255)
                {
                    int actualOpacityValue = opValue;
                    foreach (IDrawable drawnItem in ItemsList)
                    {
                        if (drawnItem is IShape)
                        {
                            if (((IShape)drawnItem).ContainsPoint(e.X, e.Y))
                            {
                                SelectedItem = drawnItem;
                                NewSelectedColor = Color.FromArgb(actualOpacityValue, NewSelectedColor.R, NewSelectedColor.G, NewSelectedColor.B);
                                SelectedItem.ChangeColor(NewSelectedColor);
                                // za da moje posle da si izbera cvqt s koito da moga da risuvam s 255 za a 
                                NewSelectedColor = colorDialog1.Color;
                            }
                        }
                        Selection = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong input.");
                }
            }

            if (Selection == 10)
            {
                foreach (IDrawable drawnItem in ItemsList)
                {
                    if (drawnItem is IShape)
                    {
                        if (((IShape)drawnItem).ContainsPoint(e.X, e.Y))
                        {
                            SelectedItem = drawnItem;
                            drawnItem.ResizeBigger();
                        }
                    }
                }
            }

            if (Selection == 11)
            {
                foreach (IDrawable drawnItem in ItemsList)
                {
                    if (drawnItem is IShape)
                    {
                        if (((IShape)drawnItem).ContainsPoint(e.X, e.Y))
                        {
                            SelectedItem = drawnItem;
                            drawnItem.ResizeSmaller();
                            
                        }
                    }
                }
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "almostpaint file (*.ap)|*.ap",
                Title = "Save an Almost Paint file",
                FilterIndex = 2
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream stream = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                binaryFormatter.Serialize(stream, ItemsList);
                stream.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
            ItemsList = (List<IDrawable>)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            Selection = 1;
            SelectedItem = null;
            Refresh();
        }


        private void newCanvasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ItemsList = new List<IDrawable>();
            this.SelectedItem = null;
            openFileDialog1.FileName = String.Empty;
            saveFileDialog1.FileName = String.Empty;
            Refresh();
        }

        
    }
}

