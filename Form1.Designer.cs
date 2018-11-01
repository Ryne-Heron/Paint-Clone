namespace Assignment4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentlyOpenedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar = new System.Windows.Forms.GroupBox();
            this.Chosen_Color_Display = new System.Windows.Forms.TextBox();
            this.eraserComboBox = new System.Windows.Forms.ComboBox();
            this.penComboBox = new System.Windows.Forms.ComboBox();
            this.pencilComboBox = new System.Windows.Forms.ComboBox();
            this.drawLineButton = new System.Windows.Forms.Button();
            this.eraserButton = new System.Windows.Forms.Button();
            this.penButton = new System.Windows.Forms.Button();
            this.pencilButton = new System.Windows.Forms.Button();
            this.colorDialogButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.drawPanel = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1889, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hiToolStripMenuItem
            // 
            this.hiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.recentlyOpenedToolStripMenuItem});
            this.hiToolStripMenuItem.Name = "hiToolStripMenuItem";
            this.hiToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.hiToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newImage_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // recentlyOpenedToolStripMenuItem
            // 
            this.recentlyOpenedToolStripMenuItem.Name = "recentlyOpenedToolStripMenuItem";
            this.recentlyOpenedToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.recentlyOpenedToolStripMenuItem.Text = "Recently Opened";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuBar.Controls.Add(this.Chosen_Color_Display);
            this.menuBar.Controls.Add(this.eraserComboBox);
            this.menuBar.Controls.Add(this.penComboBox);
            this.menuBar.Controls.Add(this.pencilComboBox);
            this.menuBar.Controls.Add(this.drawLineButton);
            this.menuBar.Controls.Add(this.eraserButton);
            this.menuBar.Controls.Add(this.penButton);
            this.menuBar.Controls.Add(this.pencilButton);
            this.menuBar.Controls.Add(this.colorDialogButton);
            this.menuBar.Controls.Add(this.textBox2);
            this.menuBar.Controls.Add(this.textBox3);
            this.menuBar.Controls.Add(this.textBox4);
            this.menuBar.Controls.Add(this.textBox5);
            this.menuBar.Controls.Add(this.textBox6);
            this.menuBar.Controls.Add(this.textBox7);
            this.menuBar.Controls.Add(this.textBox8);
            this.menuBar.Controls.Add(this.textBox9);
            this.menuBar.Controls.Add(this.textBox10);
            this.menuBar.Controls.Add(this.textBox11);
            this.menuBar.Controls.Add(this.textBox12);
            this.menuBar.Controls.Add(this.textBox13);
            this.menuBar.Controls.Add(this.textBox14);
            this.menuBar.Controls.Add(this.textBox15);
            this.menuBar.Controls.Add(this.textBox16);
            this.menuBar.Controls.Add(this.textBox17);
            this.menuBar.Controls.Add(this.textBox18);
            this.menuBar.Controls.Add(this.textBox19);
            this.menuBar.Controls.Add(this.textBox20);
            this.menuBar.Controls.Add(this.textBox21);
            this.menuBar.Controls.Add(this.textBox22);
            this.menuBar.Controls.Add(this.textBox23);
            this.menuBar.Controls.Add(this.textBox24);
            this.menuBar.Controls.Add(this.textBox25);
            this.menuBar.Controls.Add(this.textBox26);
            this.menuBar.Controls.Add(this.textBox27);
            this.menuBar.Controls.Add(this.textBox28);
            this.menuBar.Controls.Add(this.textBox1);
            this.menuBar.Location = new System.Drawing.Point(0, 33);
            this.menuBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.menuBar.Size = new System.Drawing.Size(2108, 144);
            this.menuBar.TabIndex = 1;
            this.menuBar.TabStop = false;
            this.menuBar.Text = "Menu";
            // 
            // Chosen_Color_Display
            // 
            this.Chosen_Color_Display.Cursor = System.Windows.Forms.Cursors.Default;
            this.Chosen_Color_Display.Location = new System.Drawing.Point(181, 112);
            this.Chosen_Color_Display.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Chosen_Color_Display.Name = "Chosen_Color_Display";
            this.Chosen_Color_Display.ReadOnly = true;
            this.Chosen_Color_Display.Size = new System.Drawing.Size(404, 22);
            this.Chosen_Color_Display.TabIndex = 36;
            // 
            // eraserComboBox
            // 
            this.eraserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eraserComboBox.FormattingEnabled = true;
            this.eraserComboBox.Location = new System.Drawing.Point(1144, 86);
            this.eraserComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eraserComboBox.Name = "eraserComboBox";
            this.eraserComboBox.Size = new System.Drawing.Size(151, 24);
            this.eraserComboBox.TabIndex = 35;
            this.eraserComboBox.SelectedIndexChanged += new System.EventHandler(this.eraserComboBox_SelectedIndexChanged);
            // 
            // penComboBox
            // 
            this.penComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.penComboBox.FormattingEnabled = true;
            this.penComboBox.Location = new System.Drawing.Point(968, 86);
            this.penComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.penComboBox.Name = "penComboBox";
            this.penComboBox.Size = new System.Drawing.Size(151, 24);
            this.penComboBox.TabIndex = 34;
            this.penComboBox.SelectedIndexChanged += new System.EventHandler(this.brushComboBox_SelectedIndexChanged);
            // 
            // pencilComboBox
            // 
            this.pencilComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.pencilComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pencilComboBox.FormattingEnabled = true;
            this.pencilComboBox.Location = new System.Drawing.Point(792, 86);
            this.pencilComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pencilComboBox.Name = "pencilComboBox";
            this.pencilComboBox.Size = new System.Drawing.Size(151, 24);
            this.pencilComboBox.TabIndex = 33;
            this.pencilComboBox.SelectedIndexChanged += new System.EventHandler(this.pencilComboBox_SelectedIndexChanged);
            this.pencilComboBox.SelectionChangeCommitted += new System.EventHandler(this.pencilComboBox_SelectedIndexChanged);
            // 
            // drawLineButton
            // 
            this.drawLineButton.Location = new System.Drawing.Point(1319, 23);
            this.drawLineButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawLineButton.Name = "drawLineButton";
            this.drawLineButton.Size = new System.Drawing.Size(152, 68);
            this.drawLineButton.TabIndex = 32;
            this.drawLineButton.Text = "Draw Line";
            this.drawLineButton.UseVisualStyleBackColor = true;
            this.drawLineButton.Click += new System.EventHandler(this.drawLineButton_Click);
            // 
            // eraserButton
            // 
            this.eraserButton.Location = new System.Drawing.Point(1144, 23);
            this.eraserButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(152, 68);
            this.eraserButton.TabIndex = 31;
            this.eraserButton.Text = "Eraser";
            this.eraserButton.UseVisualStyleBackColor = true;
            this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // penButton
            // 
            this.penButton.Location = new System.Drawing.Point(968, 23);
            this.penButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(152, 68);
            this.penButton.TabIndex = 3;
            this.penButton.Text = "Paint Brush";
            this.penButton.UseVisualStyleBackColor = true;
            this.penButton.Click += new System.EventHandler(this.brushButton_Click);
            // 
            // pencilButton
            // 
            this.pencilButton.Location = new System.Drawing.Point(792, 25);
            this.pencilButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pencilButton.Name = "pencilButton";
            this.pencilButton.Size = new System.Drawing.Size(152, 68);
            this.pencilButton.TabIndex = 2;
            this.pencilButton.Text = "Pencil";
            this.pencilButton.UseVisualStyleBackColor = true;
            this.pencilButton.Click += new System.EventHandler(this.pencilButton_Click);
            // 
            // colorDialogButton
            // 
            this.colorDialogButton.Location = new System.Drawing.Point(608, 25);
            this.colorDialogButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorDialogButton.Name = "colorDialogButton";
            this.colorDialogButton.Size = new System.Drawing.Size(164, 68);
            this.colorDialogButton.TabIndex = 30;
            this.colorDialogButton.Text = "More Options";
            this.colorDialogButton.UseVisualStyleBackColor = true;
            this.colorDialogButton.Click += new System.EventHandler(this.colorDialogButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Red;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox2.Location = new System.Drawing.Point(99, 62);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(32, 30);
            this.textBox2.TabIndex = 3;
            this.textBox2.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Yellow;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox3.Location = new System.Drawing.Point(140, 62);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(32, 30);
            this.textBox3.TabIndex = 4;
            this.textBox3.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Lime;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox4.Location = new System.Drawing.Point(181, 62);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(32, 30);
            this.textBox4.TabIndex = 5;
            this.textBox4.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Aqua;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox5.Location = new System.Drawing.Point(223, 62);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(32, 30);
            this.textBox5.TabIndex = 6;
            this.textBox5.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Blue;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox6.Location = new System.Drawing.Point(264, 62);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(32, 30);
            this.textBox6.TabIndex = 7;
            this.textBox6.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Fuchsia;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox7.Location = new System.Drawing.Point(305, 62);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(32, 30);
            this.textBox7.TabIndex = 8;
            this.textBox7.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox8.Location = new System.Drawing.Point(347, 62);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(32, 30);
            this.textBox8.TabIndex = 9;
            this.textBox8.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.SpringGreen;
            this.textBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox9.Location = new System.Drawing.Point(388, 62);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(32, 30);
            this.textBox9.TabIndex = 10;
            this.textBox9.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox10.Location = new System.Drawing.Point(429, 62);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(32, 30);
            this.textBox10.TabIndex = 11;
            this.textBox10.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.textBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox11.Location = new System.Drawing.Point(471, 62);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(32, 30);
            this.textBox11.TabIndex = 12;
            this.textBox11.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.DeepPink;
            this.textBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox12.Location = new System.Drawing.Point(512, 62);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(32, 30);
            this.textBox12.TabIndex = 13;
            this.textBox12.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.SandyBrown;
            this.textBox13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox13.Location = new System.Drawing.Point(553, 62);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(32, 30);
            this.textBox13.TabIndex = 14;
            this.textBox13.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.White;
            this.textBox14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox14.Location = new System.Drawing.Point(16, 62);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(32, 30);
            this.textBox14.TabIndex = 15;
            this.textBox14.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.Silver;
            this.textBox15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox15.Location = new System.Drawing.Point(57, 62);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(32, 30);
            this.textBox15.TabIndex = 16;
            this.textBox15.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.Sienna;
            this.textBox16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox16.Location = new System.Drawing.Point(553, 23);
            this.textBox16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(32, 30);
            this.textBox16.TabIndex = 17;
            this.textBox16.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.BlueViolet;
            this.textBox17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox17.Location = new System.Drawing.Point(512, 23);
            this.textBox17.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(32, 30);
            this.textBox17.TabIndex = 18;
            this.textBox17.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox18.Location = new System.Drawing.Point(471, 23);
            this.textBox18.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox18.Multiline = true;
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(32, 30);
            this.textBox18.TabIndex = 19;
            this.textBox18.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox19.Location = new System.Drawing.Point(429, 23);
            this.textBox19.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(32, 30);
            this.textBox19.TabIndex = 20;
            this.textBox19.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBox20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox20.Location = new System.Drawing.Point(388, 23);
            this.textBox20.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(32, 30);
            this.textBox20.TabIndex = 21;
            this.textBox20.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.Color.DarkKhaki;
            this.textBox21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox21.Location = new System.Drawing.Point(347, 23);
            this.textBox21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(32, 30);
            this.textBox21.TabIndex = 22;
            this.textBox21.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.Color.Purple;
            this.textBox22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox22.Location = new System.Drawing.Point(305, 23);
            this.textBox22.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox22.Multiline = true;
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(32, 30);
            this.textBox22.TabIndex = 23;
            this.textBox22.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.Color.Navy;
            this.textBox23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox23.Location = new System.Drawing.Point(264, 23);
            this.textBox23.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox23.Multiline = true;
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(32, 30);
            this.textBox23.TabIndex = 24;
            this.textBox23.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.Color.Teal;
            this.textBox24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox24.Location = new System.Drawing.Point(223, 23);
            this.textBox24.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox24.Multiline = true;
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(32, 30);
            this.textBox24.TabIndex = 25;
            this.textBox24.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox25
            // 
            this.textBox25.BackColor = System.Drawing.Color.Green;
            this.textBox25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox25.Location = new System.Drawing.Point(181, 23);
            this.textBox25.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox25.Multiline = true;
            this.textBox25.Name = "textBox25";
            this.textBox25.ReadOnly = true;
            this.textBox25.Size = new System.Drawing.Size(32, 30);
            this.textBox25.TabIndex = 26;
            this.textBox25.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox26
            // 
            this.textBox26.BackColor = System.Drawing.Color.Olive;
            this.textBox26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox26.Location = new System.Drawing.Point(140, 23);
            this.textBox26.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox26.Multiline = true;
            this.textBox26.Name = "textBox26";
            this.textBox26.ReadOnly = true;
            this.textBox26.Size = new System.Drawing.Size(32, 30);
            this.textBox26.TabIndex = 27;
            this.textBox26.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox27
            // 
            this.textBox27.BackColor = System.Drawing.Color.Maroon;
            this.textBox27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox27.Location = new System.Drawing.Point(99, 23);
            this.textBox27.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox27.Multiline = true;
            this.textBox27.Name = "textBox27";
            this.textBox27.ReadOnly = true;
            this.textBox27.Size = new System.Drawing.Size(32, 30);
            this.textBox27.TabIndex = 28;
            this.textBox27.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox28
            // 
            this.textBox28.BackColor = System.Drawing.Color.Gray;
            this.textBox28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox28.Location = new System.Drawing.Point(57, 23);
            this.textBox28.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox28.Multiline = true;
            this.textBox28.Name = "textBox28";
            this.textBox28.ReadOnly = true;
            this.textBox28.Size = new System.Drawing.Size(32, 30);
            this.textBox28.TabIndex = 29;
            this.textBox28.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Location = new System.Drawing.Point(16, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(32, 30);
            this.textBox1.TabIndex = 2;
            this.textBox1.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.Color.White;
            this.drawPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.drawPanel.Location = new System.Drawing.Point(16, 185);
            this.drawPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(1867, 738);
            this.drawPanel.TabIndex = 2;
            this.drawPanel.TabStop = false;
            this.drawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseDown);
            this.drawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseMove);
            this.drawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1889, 937);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentlyOpenedToolStripMenuItem;
        private System.Windows.Forms.GroupBox menuBar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button colorDialogButton;
        private System.Windows.Forms.Button pencilButton;
        private System.Windows.Forms.ComboBox penComboBox;
        private System.Windows.Forms.ComboBox pencilComboBox;
        private System.Windows.Forms.Button drawLineButton;
        private System.Windows.Forms.Button eraserButton;
        private System.Windows.Forms.Button penButton;
        private System.Windows.Forms.ComboBox eraserComboBox;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.PictureBox drawPanel;
        private System.Windows.Forms.TextBox Chosen_Color_Display;
    }
}

