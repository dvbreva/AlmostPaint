using ShapesLibrary.Interfaces;
using ShapesLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace AlmostPaint
{
    public partial class PaintMainFrame : Form
    {
        int X;
        int Y;

        public int Selection = 1;

        public IDraw SelectedItem = null;

        public Color NewSelectedColor;
        public Color selectionColor = Color.FromArgb(50, Color.Red);

        public List<IDraw> ItemsList = new List<IDraw>();

        public IDraw itemToCopy = null;

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

        private void buttonChangeName_Click(object sender, EventArgs e)
        {
            Selection = 12;
            SelectionLabel.Text = "You have selected to change name.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selection = 13;
            SelectionLabel.Text = "You have selected to create a group shape.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Selection = 14;
            SelectionLabel.Text = "You have decided to copy a shape.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Selection = 15;
            SelectionLabel.Text = "You have decided to paste a shape.";
        }


        // tool strip commands 
        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selection = 1;
        }

        private void drawARectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selection = 2;
        }

        private void drawASquareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selection = 3;
        }

        private void drawALineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selection = 4;
        }

        private void drawACircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selection = 5;
        }

        private void dranAnEllipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selection = 6;
        }

        private void drawAPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selection = 7;
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selection = 8;
        }

        private void resizeBiggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selection = 10;
        }

        private void resizeSmallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selection = 11;
        }

        private void PaintMainFrame_MouseDown(object sender, MouseEventArgs e)
        {
            
          
            if (Selection == 1)
            {
                foreach (IDraw drawnItem in ItemsList)
                {
                    if (drawnItem is IShape)
                    {
                        if (((IShape)drawnItem).ContainsPoint(e.X, e.Y))
                        {
                            SelectedItem = drawnItem;

                            SelectionLabel.Text = "You have selected a shape of type " + SelectedItem.GetType().Name;

                            if (e.Button == MouseButtons.Right)
                            {
                                MessageBox.Show("This is the info for the selected shape: \n " + drawnItem.GetInfo());
                            }

                            break;
                        }
                    }
                }
            }

            if (Selection == 2)
            {
                RectangleShape item = new RectangleShape(NewSelectedColor, e.X - 25, e.Y - 50, 150, 50, "rectangle unchanged name");
                ItemsList.Add(item);
            }

            if (Selection == 3)
            {
                SquareShape item = new SquareShape(NewSelectedColor, e.X - 25, e.Y - 50, 100, 100, "square unchanged name");
                ItemsList.Add(item);
            }

            if (Selection == 4)
            {
                LineShape item = new LineShape(NewSelectedColor, e.X - 25, e.Y - 50, 100, 5, "line unchanged name");
                ItemsList.Add(item);
            }

            if (Selection == 5)
            {
                CircleShape item = new CircleShape(NewSelectedColor, e.X - 25, e.Y - 50, 100, 100, "circle unchanged name");
                ItemsList.Add(item);
            }

            if (Selection == 6)
            {
                EllipseShape item = new EllipseShape(NewSelectedColor, e.X - 25, e.Y - 50, 150, 100, "ellipse unchanged name");
                ItemsList.Add(item);
            }

            if (Selection == 7)
            {
                PointShape item = new PointShape(NewSelectedColor, e.X - 25, e.Y - 50, 10, 10, "point unchanged name");
                ItemsList.Add(item);
            }

            if (Selection == 8)
            {
                // !somewhat working -> tova e kato si izbera cvqt da gi risuva s nego :D  
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    NewSelectedColor = colorDialog1.Color;
                }



                foreach (IDraw drawnItem in ItemsList)
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
                    foreach (IDraw drawnItem in ItemsList)
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
                foreach (IDraw drawnItem in ItemsList)
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
                foreach (IDraw drawnItem in ItemsList)
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

            if (Selection == 12)
            {
                foreach (IDraw drawnItem in ItemsList)
                {
                    if (drawnItem is IShape)
                    {
                        if (((IShape)drawnItem).ContainsPoint(e.X, e.Y))
                        {
                            SelectedItem = drawnItem;
                            string newValueForName = textBoxChangeName.Text;
                            drawnItem.ChangeName(newValueForName);
                            SelectionLabel.Text = "The new value for the name of this shape is " + newValueForName;
                            
                            break;
                        }
                    }
                }
            }

            if(Selection == 13)
            {
                GroupShape groupShapeItems = new GroupShape();

                if(ItemsList.Count <= 1)
                {
                    MessageBox.Show("You cannot create a group shape if you have only one shape drawn.");
                }
                else
                {
                    foreach (IDraw drawnItem in ItemsList)
                    {
                            if (((IShape)drawnItem).ContainsPoint(e.X, e.Y))
                            {
                                SelectedItem = drawnItem;

                                SelectionLabel.Text = SelectedItem.GetType().Name;

                                groupShapeItems.GroupItems.Add(SelectedItem);
                                
                                //break;
                            }
                    }
                }
            }

            if (Selection == 14)
            {
                    foreach (IDraw drawnItem in ItemsList)
                    {
                        if (drawnItem is IShape)
                        {
                            if (((IShape)drawnItem).ContainsPoint(e.X, e.Y))
                            {
                                SelectedItem = drawnItem;
                                itemToCopy = drawnItem;

                                SelectionLabel.Text = "You have selected to copy a shape of type " + itemToCopy.GetType().Name;
                                
                                break;
                            }
                        }
                    }
                
            }

            if(Selection == 15)
            {
                 foreach (IDraw drawnItem in ItemsList)
                 {
                     if (drawnItem is IShape)
                     {
                         if (((IShape)drawnItem).ContainsPoint(e.X, e.Y))
                         {
                             SelectedItem = drawnItem;
                             itemToCopy = drawnItem;
                             IDraw pastedItem = itemToCopy.CopyShape();
                             ItemsList.Add(pastedItem);

                             SelectionLabel.Text = "You successfully pasted copy shape of type " + itemToCopy.GetType().Name;
                             this.Refresh();
                             break;
                         }
                     }
                 }
                 SelectedItem = null; 
            }

            this.Refresh();
        }

        private void PaintMainFrame_Paint(object sender, PaintEventArgs e)
        {
            foreach (IDraw item in ItemsList)
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
            if (SelectedItem != null && SelectedItem is ITranslate)
            {
                int dX = e.X - this.X;
                int dY = e.Y - this.Y;

                ((ITranslate)SelectedItem).TranslateMethod(dX, dY);
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
            ItemsList = (List<IDraw>)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            Selection = 1;
            SelectedItem = null;
            Refresh();
        }


        private void newCanvasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ItemsList = new List<IDraw>();
            this.SelectedItem = null;
            openFileDialog1.FileName = String.Empty;
            saveFileDialog1.FileName = String.Empty;
            SelectionLabel.Text = "You have started a new project.";
            Refresh();
        }

        // Различни начини на задаване на операциите от потребителя - от клавиатурата
        private void PaintMainFrame_KeyDown(object sender, KeyEventArgs e)
        {
            // copy item 
            if (e.KeyData.ToString() == "C, Shift, Control")
            {
                MessageBox.Show("Please click on the shape you want to copy.");
                Selection = 14;
                SelectionLabel.Text = "copied shape";
            }

            // paste item 
            if (e.KeyData.ToString() == "V, Shift, Control")
            {
                MessageBox.Show("Please click over the shape you've copied to paste it.");
                Selection = 15;
                SelectionLabel.Text = "A successfull copy of the selected shape was made. Please use select tool to check out its properties.";
            }

            // resize bigger
            if (e.KeyData.ToString() == "B, Control")
            {
                MessageBox.Show("You can select a shape you want to make bigger.");
                Selection = 10;
                SelectionLabel.Text = "made shape bigger";
            }

            // resize smaller 
            if (e.KeyData.ToString() == "J, Control")
            {
                MessageBox.Show("You can select a shape you want to make smaller.");
                Selection = 11;
                SelectionLabel.Text = "made shape bigger";
            }

            // if you want to make sure nothing is selected and stop all current actions
            if (e.KeyData.ToString() == "X, Control")
            {
                MessageBox.Show("Selected shape was cleared.");
                Selection = 0;
                SelectionLabel.Text = "nothing selected right now";
            }

            // select shape
            if (e.KeyData.ToString() == "NumPad0")
            {
                MessageBox.Show("You can start selecting shapes.\nRight click on shape to see shape's details.");
                Selection = 1;
                SelectionLabel.Text = "Rectangles are the choosen shape.";
            }

            // draw rectangles 
            if (e.KeyData.ToString() == "R, Control")
            {
                MessageBox.Show("You can start drawing rectangles.");
                Selection = 2;
                SelectionLabel.Text = "Rectangles are the choosen shape.";
            }

            // draw squares
            if (e.KeyData.ToString() == "Q, Control")
            {
                MessageBox.Show("You can start drawing squares.");
                Selection = 3;
                SelectionLabel.Text = "Squares are the choosen shape.";
            }

            // draw circles
            if (e.KeyData.ToString() == "C, Control")
            {
                MessageBox.Show("You can start drawing circles.");
                Selection = 5;
                SelectionLabel.Text = "Circles are the choosen shape.";
            }

            // draw ellipse
            if (e.KeyData.ToString() == "E, Control")
            {
                MessageBox.Show("You can start drawing ellipses.");
                Selection = 6;
                SelectionLabel.Text = "Ellipses are the choosen shape.";
            }

            // draw points 
            if (e.KeyData.ToString() == "P, Control")
            {
                MessageBox.Show("You can start drawing points.");
                Selection = 7;
                SelectionLabel.Text = "Points are the choosen shape.";
            }

            // show color dialog
            if (e.KeyData.ToString() == "D, Control")
            {
                MessageBox.Show("You can now choose another color from color dialog.");
                Selection = 8;
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    NewSelectedColor = colorDialog1.Color;
                }
                SelectionLabel.Text = "You have changed color.";
            }

            // new file 
            if (e.KeyData.ToString() == "N, Control")
            {
                MessageBox.Show("A new canvas is about to be reloaded.");
                newCanvasToolStripMenuItem_Click(sender, e);
                SelectionLabel.Text = "A new canvas was created";
            }

            // open file
            if (e.KeyData.ToString() == "O, Control")
            {
                openToolStripMenuItem_Click(sender, e);
                SelectionLabel.Text = "AlmostPaint File was opened.";
            }

            // save file
            if (e.KeyData.ToString() == "S, Control"){
                saveToolStripMenuItem_Click(sender, e);
                MessageBox.Show("File was successfully saved!");
                SelectionLabel.Text = "AlmostPaint File was saved.";
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can try my functionalities while only using the keyborad. \n" +
                "Follow this commands: \n\n" +
                "Ctrl + X - makes sure there is no sellected shape\n"+ 
                "0 - allows you to start selecting shapes\n"+
                "Ctrl + R - allows you to start drawing rectangles\n" +
                "Ctrl + Q - allows you to start drawing squares\n" +
                "Ctrl + C - allows you to start drawing circles\n" +
                "Ctrl + E - allows you to start dr awing ellipses\n" +
                "Ctrl + P - allows you to start drawing points\n" +
                "Ctrl + B - allows you to resize a shape bigger\n" +
                "Ctrl + J - allows you to resize a shape smaller\n" +
                "Ctrl + D - allows you to open color dialog and set your desired value to the default color\n" +
                "Ctrl + N - will load you a clear canvas\n" +
                "Ctrl + 0 - will allow you to open a AlmostPaint file from file dialog\n" +
                "Ctrl + S - will allow you to save your current canvas\n" +
                "Ctrl + Shift + C - will allow you to copy a selected shape\n" +
                "Ctrl + Shift + V - will allow you to paste a selected shape\n", "Help with keyboard events");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AlmostPaint is my GUI course work. The name is valid representation of the functionality as it resembles Paint but it is not like it. \n\n" +
                "You can switch between keyboard combinations, menu options and buttons here." +
                "You can draw shapes, change their color and opacity, resize them and change their names. If you " +
                "are satisfied you can also save your current canvas. \n\n" +
                "Enjoy!", "Information about Almost Paint");
        }

       
    }
}

