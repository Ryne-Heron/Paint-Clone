/***************************************************
* 
*   Programmers: Salman Mohammed, Ryne Heron
* 
*        Course: CSCI 473
*       
*    Assignment: 4
*          Date: November 1, 2018
* 
**************************************************/

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        Graphics g, g1;
        bool startDraw = false;
        bool somethingDrawn = false;
        int? initX = null;
        int? initY = null;
        int finalX = 0;
        int finalY = 0;
        int width;
        Color chosenColor = Color.Black;
        int lastPencilWidth = 1; //saves the most recent pencil width
        int lastBrushWidth = 5; //saves the most recent brush width
        String currentFile = "";
        Bitmap bmp = null;
        Stack<Bitmap> undoStack;
        Stack<Bitmap> redoStack;
        bool drawLineSet = false;
        bool eraserSet = false;
        Color bkg;
       

        public Form1()
        {
            InitializeComponent();
            this.Text = "Paint Clone";
            bmp = new Bitmap(drawPanel.ClientSize.Width, drawPanel.ClientSize.Height);
            g = drawPanel.CreateGraphics();
            g1 = Graphics.FromImage(bmp);
            Chosen_Color_Display.BackColor = chosenColor;
            bkg = drawPanel.BackColor;

            undoStack = new Stack<Bitmap>();
            redoStack = new Stack<Bitmap>();
            undoStack.Push(new Bitmap(bmp));
        }

        public string CurrentFile
        {
            get => currentFile;
            set { currentFile = value; }
        }
        public PictureBox DrawPanel
        {
            get => drawPanel;
            set { drawPanel = value; }
        }


        /***************************************************
         * 
         *  Form1_Load()
         * 
         *  Purpose: Initializes some components and variables
         * 
        **************************************************/
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> pencilList = new List<string>() { "size 1", "size 2", "size 3" };
            List<string> penList = new List<string>() { "size 5", "size 6", "size 7", "size 8" };
            List<string> eraserList = new List<string>() { "size 1", "size 2", "size 3" };
            pencilComboBox.DataSource = pencilList;
            penComboBox.DataSource = penList;
            eraserComboBox.DataSource = eraserList;

            width = 1; //pencil of width 1 is the default

            //All this just to make the cursor disappear
            textBox1.GotFocus += Color_GotFocus;
            textBox2.GotFocus += Color_GotFocus;
            textBox3.GotFocus += Color_GotFocus;
            textBox4.GotFocus += Color_GotFocus;
            textBox5.GotFocus += Color_GotFocus;
            textBox6.GotFocus += Color_GotFocus;
            textBox7.GotFocus += Color_GotFocus;
            textBox8.GotFocus += Color_GotFocus;
            textBox9.GotFocus += Color_GotFocus;
            textBox10.GotFocus += Color_GotFocus;
            textBox11.GotFocus += Color_GotFocus;
            textBox12.GotFocus += Color_GotFocus;
            textBox13.GotFocus += Color_GotFocus;
            textBox14.GotFocus += Color_GotFocus;
            textBox15.GotFocus += Color_GotFocus;
            textBox16.GotFocus += Color_GotFocus;
            textBox17.GotFocus += Color_GotFocus;
            textBox18.GotFocus += Color_GotFocus;
            textBox19.GotFocus += Color_GotFocus;
            textBox20.GotFocus += Color_GotFocus;
            textBox21.GotFocus += Color_GotFocus;
            textBox22.GotFocus += Color_GotFocus;
            textBox23.GotFocus += Color_GotFocus;
            textBox24.GotFocus += Color_GotFocus;
            textBox25.GotFocus += Color_GotFocus;
            textBox26.GotFocus += Color_GotFocus;
            textBox27.GotFocus += Color_GotFocus;
            textBox28.GotFocus += Color_GotFocus;

            Chosen_Color_Display.GotFocus += Color_GotFocus;
        }

        /***************************************************
        * 
        *   drawPanel_MouseMove()
        * 
        *   Purpose: An mouse movment event handler for drawPanel.
        *       A pen is used to draw lines between every
        *       point the mouse moves over in order to
        *       implement free drawing. The pen can be
        *       set to any color or it can be an "eraser"
        * 
        **************************************************/
        private void drawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawLineSet == false)
            {
                if (startDraw)
                {
                    if (eraserSet == true)
                    {
                        Pen p = new Pen(bkg, width);
                        p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
                        g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                        g1.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                        initX = e.X;
                        initY = e.Y;
                    }
                    else
                    {
                        Pen p = new Pen(chosenColor, width);
                        p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
                        g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                        g1.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                        initX = e.X;
                        initY = e.Y;
                    }
                }
            }
        }

        /***************************************************
        * 
        *   drawPanel_MouseDown()
        * 
        *   Purpose: A mousedown event handler for drawPanel.
        *       It sets the points for the spot where the mouse
        *       is initially click down. Marks the beginning
        *       of drawing of some sort. If 'Draw Line' is not
        *       selected, a dot will be drawn at this point
        * 
        **************************************************/
        private void drawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            startDraw = true;
            initX = e.X;
            initY = e.Y;

            if (drawLineSet == false)
            {
                Pen p = new Pen(chosenColor, width);
                p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
                g.DrawLine(p, new Point(e.X, e.Y), new Point(e.X + 1, e.Y + 1));
                g1.DrawLine(p, new Point(e.X, e.Y), new Point(e.X + 1, e.Y + 1));

            }
        }

        /***************************************************
        * 
        *   drawPanel_MouseUp()
        * 
        *   Purpose: A mouseup event handler for drawPanel.
        *       It sets the points for the spot where the mouse
        *       is released. This is the end of some kind
        *       of drawing. 
        * 
        **************************************************/
        private void drawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            startDraw = false;
            finalX = e.X;
            finalY = e.Y;
            somethingDrawn = true;
            if (((PictureBox)sender) != null) 
            {
                undoStack.Push(new Bitmap(bmp));
            }
            

            if (drawLineSet == true)
            {
                Pen p = new Pen(chosenColor, width);
                p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
                g.DrawLine(p, (float)initX, (float)initY, (float)finalX, (float)finalY);
                g1.DrawLine(p, (float)initX, (float)initY, (float)finalX, (float)finalY);

            }
        }

        /***************************************************
        * 
        *   undoButton_Click()
        * 
        *   Purpose: Should undo the last drawing action
        *       made to the drawPanel. Uses the undoStack
        *       to store the previous versions of the image.
        *       Pushes images popped from undoStack onto redoStack
        * 
        **************************************************/
        private void undoButton_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                Bitmap tempBmp = undoStack.Pop();

                drawPanel.Image = tempBmp;

                drawPanel.Update();
                Console.WriteLine("Undo Stack " + undoStack.Count);

                redoStack.Push(tempBmp);
            }
        }

        /***************************************************
        * 
        *   redoButton_Click()
        * 
        *   Purpose: Should redo the last drawing action
        *       reversed by undo. Uses the redoStack
        *       to store the previous versions of the image.
        *       Pushes images popped from redoStack onto undoStack
        * 
        **************************************************/
        private void redoButton_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                Bitmap tempBmp = redoStack.Pop();

                drawPanel.Image = tempBmp;


                drawPanel.Update();
                Console.WriteLine("Redo Stack: " + redoStack.Count);

                undoStack.Push(tempBmp);
            }
        }

        /***************************************************
        * 
        *   colorDialogButton_Click()
        * 
        *   Purpose: Opens the color dialog. If a color
        *       is selected, it will be used when drawing
        * 
        **************************************************/
        private void colorDialogButton_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.ShowDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.FullOpen = true;

            chosenColor = MyDialog.Color;
            Chosen_Color_Display.BackColor = chosenColor;
        }

        /***************************************************
        * 
        *   PencilButton_Click()
        * 
        *   Purpose: Selects the pencil for drawing
        * 
        **************************************************/
        private void pencilButton_Click(object sender, EventArgs e)
        {
            width = lastPencilWidth;
            drawLineSet = false;
            eraserSet = false;
            
        }

        /***************************************************
        * 
        *   brushButton_Click()
        * 
        *   Purpose: Selects the brush for drawing
        * 
        **************************************************/
        private void brushButton_Click(object sender, EventArgs e)
        {
            width = lastBrushWidth;
            drawLineSet = false;
            eraserSet = false;
        }

        /***************************************************
        * 
        *   pencilComboBox_SelectedIndexChanged()
        * 
        *   Purpose: Selects the width for drawing with
        *       the pencil
        * 
        **************************************************/
        private void pencilComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)pencilComboBox.SelectedItem == "size 1")
            {
                width = 1;
                lastPencilWidth = 1;
            }

            if ((string)pencilComboBox.SelectedItem == "size 2")
            {
                width = 2;
                lastPencilWidth = 2;
            }

            if ((string)pencilComboBox.SelectedItem == "size 3")
            {
                width = 3;
                lastPencilWidth = 3;
            }

        }

        /***************************************************
        * 
        *   brushComboBox_SelectedIndexChanged()
        * 
        *   Purpose: Selects the width for drawing with
        *       the brush
        * 
        **************************************************/
        private void brushComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)penComboBox.SelectedItem == "size 5")
            {
                width = 5;
                lastBrushWidth = 5;
            }

            if ((string)penComboBox.SelectedItem == "size 6")
            {
                width = 6;
                lastBrushWidth = 6;
            }

            if ((string)penComboBox.SelectedItem == "size 7")
            {
                width = 7;
                lastBrushWidth = 7;
            }

            if ((string)penComboBox.SelectedItem == "size 8")
            {
                width = 8;
                lastBrushWidth = 8;
            }

        }

        /***************************************************
        * 
        *   colorSelect_Click()
        * 
        *   Purpose: The eventhandler used to select one
        *       of the 28 colorboxes
        * 
        **************************************************/
        private void colorSelect_Click(object sender, EventArgs e)
        {
            if (sender as TextBox != null)
            {
                chosenColor = ((TextBox)sender).BackColor;
                Chosen_Color_Display.BackColor = chosenColor;
            }
        }

        /***************************************************
        * 
        *   saveImage_Click()
        * 
        *   Purpose: Will check if the user has saved this
        *       file already. If not, it will prompt the user
        *       to name and save the file at a location
        * 
        **************************************************/
        private void saveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.Filter = "Png (*.png)|*.png";
            
            var bitMapGraphics = Graphics.FromImage(bmp);
            var rect = drawPanel.RectangleToScreen(drawPanel.ClientRectangle);
            bitMapGraphics.CopyFromScreen(rect.Location, Point.Empty, drawPanel.Size);
            
            if (currentFile == "" || ((ToolStripMenuItem)(sender)).Text == "Save As")
            { 
                dialog.ShowDialog();
                if (dialog.FileName != "")
                {
                    bmp.Save(dialog.FileName, ImageFormat.Png);
                    currentFile = dialog.FileName;
                }
            }
            else
            {
                bmp.Save(currentFile, ImageFormat.Png);
            }
        }

        /***************************************************
        * 
        *   newImage_Click()
        * 
        *   Purpose: First checks if anything has been drawn
        *       on drawPanel. If there has been, it prompts
        *       the user whether they want to save or not. Otherwise,
        *       it will clear drawPanel
        * 
        **************************************************/
        private void newImage_Click(object sender, EventArgs e)
        {
            Bitmap bmp2 = null;
            if (somethingDrawn == true)
            {
                 Form f2 = new Form2(this);
                 f2.Show();
                 somethingDrawn = false;
            }

            else
            {
                drawPanel.Refresh();
                currentFile = "";
            }
        }

        //necessary to get rid of blinking text cursor in textboxes
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        /***************************************************
        * 
        *   Color_GotFocus()
        * 
        *   Purpose: Removes the text cursor from a component
        * 
        **************************************************/
        private void Color_GotFocus(object sender, EventArgs e)
        {
            if (sender as TextBox != null)
            {
                HideCaret(((TextBox)sender).Handle);
            }
        }

        /***************************************************
        * 
        *   openToolStripMenuItem_Click()
        * 
        *   Purpose: Opens up a dialog that allows the user
        *       to select a file to open in drawPanel.
        * 
        **************************************************/
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                //open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bit = new Bitmap(open.FileName);
                    drawPanel.Image = bit;
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }

        }

        /***************************************************
        * 
        *   drawLineButton_Click()
        * 
        *   Purpose: Selects the 'Draw Line' tool for drawing
        * 
        **************************************************/
        private void drawLineButton_Click(object sender, EventArgs e)
        {
            drawLineSet = true;

        }

        /***************************************************
        * 
        *   eraserButton_Click()
        * 
        *   Purpose: Selects the 'Eraser' tool for erasing
        * 
        **************************************************/
        private void eraserButton_Click(object sender, EventArgs e)
        {
            eraserSet = true;
            width = 3;
        }


        /***************************************************
        * 
        *   Form1_KeyDown()
        * 
        *   Purpose: Handles key events for the entire form.
        *       Handles events for undo and redo that
        *       are treated the same as clicking
        *       the undo/redo buttons
        * 
        **************************************************/
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {

                if (undoStack.Count > 0)
                {
                    Bitmap tempBmp = undoStack.Pop();

                    drawPanel.Image = tempBmp;

                    drawPanel.Update();
                    Console.WriteLine("Undo Stack " + undoStack.Count);

                    redoStack.Push(tempBmp);
                }
            }

                if (e.Control && e.KeyCode == Keys.X)
                {
                    
                    if (redoStack.Count > 0)
                    {
                        Bitmap tempBmp = redoStack.Pop();

                        drawPanel.Image = tempBmp;


                        drawPanel.Update();
                        Console.WriteLine("Redo Stack: " + redoStack.Count);

                        undoStack.Push(tempBmp);
                    }
                }
            }
        

        /***************************************************
        * 
        *   eraserComboBox_SelectedIndexChanged()
        * 
        *   Purpose: Selects the width for erasing with the
        *       eraser
        * 
        **************************************************/
        private void eraserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)eraserComboBox.SelectedItem == "size 1")
            {
                width = 3;
                
            }

            if ((string)eraserComboBox.SelectedItem == "size 2")
            {
                width = 4;
               
            }

            if ((string)eraserComboBox.SelectedItem == "size 3")
            {
                width = 5;
                
            }
        }
    }
}


