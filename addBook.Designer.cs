namespace Project
{
    partial class addBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBook));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            check = new CheckBox();
            Add = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            authorlabel = new Label();
            availabilitylabel = new Label();
            isbnlabel = new Label();
            yearlabel = new Label();
            titlelabel = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 83);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(340, 23);
            label1.Name = "label1";
            label1.Size = new Size(235, 40);
            label1.TabIndex = 0;
            label1.Text = "Add a BooK Tab";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Chocolate;
            panel2.Controls.Add(check);
            panel2.Controls.Add(Add);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(authorlabel);
            panel2.Controls.Add(availabilitylabel);
            panel2.Controls.Add(isbnlabel);
            panel2.Controls.Add(yearlabel);
            panel2.Controls.Add(titlelabel);
            panel2.Location = new Point(415, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(538, 494);
            panel2.TabIndex = 1;
            // 
            // check
            // 
            check.AutoSize = true;
            check.ForeColor = SystemColors.Control;
            check.Location = new Point(261, 272);
            check.Name = "check";
            check.Size = new Size(68, 24);
            check.TabIndex = 13;
            check.Text = "check";
            check.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            Add.FlatStyle = FlatStyle.Popup;
            Add.ForeColor = SystemColors.Control;
            Add.Location = new Point(190, 320);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 12;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(261, 239);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(261, 206);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(261, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // authorlabel
            // 
            authorlabel.AutoSize = true;
            authorlabel.ForeColor = SystemColors.Control;
            authorlabel.Location = new Point(63, 174);
            authorlabel.Name = "authorlabel";
            authorlabel.Size = new Size(98, 20);
            authorlabel.TabIndex = 5;
            authorlabel.Text = "Author Name";
            // 
            // availabilitylabel
            // 
            availabilitylabel.AutoSize = true;
            availabilitylabel.ForeColor = SystemColors.Control;
            availabilitylabel.Location = new Point(63, 270);
            availabilitylabel.Name = "availabilitylabel";
            availabilitylabel.Size = new Size(83, 20);
            availabilitylabel.TabIndex = 4;
            availabilitylabel.Text = "Availability";
            // 
            // isbnlabel
            // 
            isbnlabel.AutoSize = true;
            isbnlabel.ForeColor = SystemColors.Control;
            isbnlabel.Location = new Point(63, 239);
            isbnlabel.Name = "isbnlabel";
            isbnlabel.Size = new Size(41, 20);
            isbnlabel.TabIndex = 3;
            isbnlabel.Text = "ISBN";
            // 
            // yearlabel
            // 
            yearlabel.AutoSize = true;
            yearlabel.ForeColor = SystemColors.Control;
            yearlabel.Location = new Point(63, 209);
            yearlabel.Name = "yearlabel";
            yearlabel.Size = new Size(88, 20);
            yearlabel.TabIndex = 2;
            yearlabel.Text = "Publish Year";
            // 
            // titlelabel
            // 
            titlelabel.AutoSize = true;
            titlelabel.ForeColor = SystemColors.Control;
            titlelabel.Location = new Point(63, 140);
            titlelabel.Name = "titlelabel";
            titlelabel.Size = new Size(76, 20);
            titlelabel.TabIndex = 1;
            titlelabel.Text = "Book Title";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(416, 482);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // addBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 569);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "addBook";
            Text = "Add a Book";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label authorlabel;
        private Label availabilitylabel;
        private Label isbnlabel;
        private Label yearlabel;
        private Label titlelabel;
        private TextBox textBox2;
        private Button Add;
        private TextBox textBox5;
        private TextBox textBox4;
        private CheckBox check;
        private TextBox textBox3;
    }
}