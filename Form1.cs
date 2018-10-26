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

namespace Assignment4
{
    public partial class Form1 : Form
    {
        Graphics g;
        bool startDraw = false;
        int? initX = null;
        int? initY = null;
        int width;
        Color chosenColor = Color.Black;

        public Form1()
        {
            InitializeComponent();
            g = drawPanel.CreateGraphics();
            Chosen_Color_Display.BackColor = chosenColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> pencilList = new List<string>() { "size 1", "size 2", "size 3" };
            List<string> penList = new List<string>() { "size 5", "size 6", "size 7", "size 8" };
            List<string> eraserList = new List<string>() { "size 1", "size 2", "size 3" };
            pencilComboBox.DataSource = pencilList;
            penComboBox.DataSource = penList;
            eraserComboBox.DataSource = eraserList;

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

        private void drawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (startDraw)
            {
                Pen p = new Pen(chosenColor, width);
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
                width = 6;
            }

            if ((string)penComboBox.SelectedItem == "size 7")
            {
                width = 7;
            }

            if ((string)penComboBox.SelectedItem == "size 8")
            {
                width = 8;
            }

        }

        private void colorSelect_Click(object sender, EventArgs e)
        {
            if(sender as TextBox != null)
            {
                chosenColor = ((TextBox)sender).BackColor;
                Chosen_Color_Display.BackColor = chosenColor;
            }
        }

        private void penButton_Click(object sender, EventArgs e)
        {
            width = 5;
        }



        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        private void Color_GotFocus(object sender, EventArgs e)
        {
            if (sender as TextBox != null)
            {
                HideCaret(((TextBox)sender).Handle);
            }
        }
    }
}
