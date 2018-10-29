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
using System.Drawing.Imaging;

namespace Assignment4
{
    public partial class Form2 : Form
    {
        protected Form1 CallingForm;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form)
        {
            InitializeComponent();
            this.CallingForm = form;
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private string current;
        private Form draw;
        public string Current
        {
            get { return current; }
            set { current = value; }
        }
        public Form Draw { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.Filter = "Png (*.png)|*.png";
            if (this.CallingForm.CurrentFile  == "")
            {
                dialog.ShowDialog();
                int width = Convert.ToInt32(this.CallingForm.DrawPanel.Width);
                int height = Convert.ToInt32(this.CallingForm.DrawPanel.Height);
                Bitmap bmp = new Bitmap(width, height);
                this.CallingForm.DrawPanel.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                if (dialog.FileName != "")
                {
                    bmp.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    this.CallingForm.CurrentFile = dialog.FileName;
                }
            }
            else
            {
                int width = Convert.ToInt32(this.CallingForm.DrawPanel.Width);
                int height = Convert.ToInt32(this.CallingForm.DrawPanel.Height);
                Bitmap bmp = new Bitmap(width, height);
                this.CallingForm.DrawPanel.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            this.CallingForm.DrawPanel.Refresh();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.CallingForm.DrawPanel.Refresh();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
