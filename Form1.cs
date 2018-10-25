using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = drawPanel.CreateGraphics();
        }

        Graphics g;
        bool startDraw = false;
        int? initX = null;
        int? initY = null;
        int width;

        private void drawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (startDraw)
            {
                Pen p = new Pen(Color.Black, width);
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            }
        }

        private void drawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            
            startDraw = true;
            initX = e.X;
            initY = e.Y;
        }

        private void drawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            startDraw = false;
            initX = null;
            initY = null;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void colorDialogButton_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.ShowDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.FullOpen = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            width = 1;
        }

        private void pencilComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)pencilComboBox.SelectedItem == "size 1")
            {
                width = 1;
            }

            if((string)pencilComboBox.SelectedItem == "size 2")
            {
                width = 2;
            }

            if((string)pencilComboBox.SelectedItem == "size 3")
            {
                width = 3;
            } 

        }

        private void penComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)penComboBox.SelectedItem == "size 5")
            {
                width = 5;
            }

            if ((string)penComboBox.SelectedItem == "size 6")
            {
                width = 2;
            }

            if ((string)penComboBox.SelectedItem == "size 7")
            {
                width = 3;
            }

            if ((string)penComboBox.SelectedItem == "size 8")
            {
                width = 8;
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> pencilList = new List<string>() { "size 1", "size 2", "size 3" };
            List<string> penList = new List<string>() { "size 5", "size 6", "size 7", "size 8" };
            List<string> eraserList = new List<string>() { "size 1", "size 2", "size 3" };
            pencilComboBox.DataSource = pencilList;
            penComboBox.DataSource = penList;
            eraserComboBox.DataSource = eraserList;

        }

        private void penButton_Click(object sender, EventArgs e)
        {
            width = 5;
        }
    }
}
