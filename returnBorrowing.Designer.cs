namespace Project
{
    partial class returnBorrowing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(returnBorrowing));
            headingpanel = new Panel();
            headlabel = new Label();
            sidepanel = new Panel();
            returnbutton = new Button();
            returnComboBox = new ComboBox();
            actualReturnDatePicker = new DateTimePicker();
            actualreturnlabel = new Label();
            borrowlabel = new Label();
            sidepictureBox = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            headingpanel.SuspendLayout();
            sidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sidepictureBox).BeginInit();
            SuspendLayout();
            // 
            // headingpanel
            // 
            headingpanel.BackColor = Color.Sienna;
            headingpanel.Controls.Add(headlabel);
            headingpanel.Location = new Point(0, 0);
            headingpanel.Name = "headingpanel";
            headingpanel.Size = new Size(952, 83);
            headingpanel.TabIndex = 0;
            // 
            // headlabel
            // 
            headlabel.AutoSize = true;
            headlabel.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headlabel.ForeColor = SystemColors.Control;
            headlabel.Location = new Point(345, 26);
            headlabel.Name = "headlabel";
            headlabel.Size = new Size(256, 40);
            headlabel.TabIndex = 0;
            headlabel.Text = "Return a Book Tab";
            // 
            // sidepanel
            // 
            sidepanel.BackColor = Color.Chocolate;
            sidepanel.Controls.Add(returnbutton);
            sidepanel.Controls.Add(returnComboBox);
            sidepanel.Controls.Add(actualReturnDatePicker);
            sidepanel.Controls.Add(actualreturnlabel);
            sidepanel.Controls.Add(borrowlabel);
            sidepanel.Location = new Point(415, 83);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(538, 494);
            sidepanel.TabIndex = 1;
            // 
            // returnbutton
            // 
            returnbutton.Location = new Point(204, 304);
            returnbutton.Name = "returnbutton";
            returnbutton.Size = new Size(94, 29);
            returnbutton.TabIndex = 5;
            returnbutton.Text = "Return";
            returnbutton.UseVisualStyleBackColor = true;
            returnbutton.Click += button_Click;
            // 
            // returnComboBox
            // 
            returnComboBox.FormattingEnabled = true;
            returnComboBox.Location = new Point(262, 162);
            returnComboBox.Name = "returnComboBox";
            returnComboBox.Size = new Size(250, 28);
            returnComboBox.TabIndex = 4;
            // 
            // actualReturnDatePicker
            // 
            actualReturnDatePicker.Location = new Point(262, 219);
            actualReturnDatePicker.Name = "actualReturnDatePicker";
            actualReturnDatePicker.Size = new Size(250, 27);
            actualReturnDatePicker.TabIndex = 3;
            // 
            // actualreturnlabel
            // 
            actualreturnlabel.AutoSize = true;
            actualreturnlabel.Font = new Font("Arial Narrow", 12F);
            actualreturnlabel.ForeColor = SystemColors.Control;
            actualreturnlabel.Location = new Point(72, 219);
            actualreturnlabel.Name = "actualreturnlabel";
            actualreturnlabel.Size = new Size(149, 24);
            actualreturnlabel.TabIndex = 1;
            actualreturnlabel.Text = "Actual Return Date";
            // 
            // borrowlabel
            // 
            borrowlabel.AutoSize = true;
            borrowlabel.Font = new Font("Arial Narrow", 12F);
            borrowlabel.ForeColor = SystemColors.Control;
            borrowlabel.Location = new Point(72, 162);
            borrowlabel.Name = "borrowlabel";
            borrowlabel.Size = new Size(62, 24);
            borrowlabel.TabIndex = 0;
            borrowlabel.Text = "Borrow";
            // 
            // sidepictureBox
            // 
            sidepictureBox.Image = (Image)resources.GetObject("sidepictureBox.Image");
            sidepictureBox.Location = new Point(0, 83);
            sidepictureBox.Name = "sidepictureBox";
            sidepictureBox.Size = new Size(416, 491);
            sidepictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            sidepictureBox.TabIndex = 2;
            sidepictureBox.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // returnBorrowing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 569);
            Controls.Add(sidepictureBox);
            Controls.Add(sidepanel);
            Controls.Add(headingpanel);
            Name = "returnBorrowing";
            Text = "Return Borrowings";
            headingpanel.ResumeLayout(false);
            headingpanel.PerformLayout();
            sidepanel.ResumeLayout(false);
            sidepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sidepictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headingpanel;
        private Panel sidepanel;
        private PictureBox sidepictureBox;
        private Label headlabel;
        private ComboBox returnComboBox;
        private DateTimePicker actualReturnDatePicker;
        private Label actualreturnlabel;
        private Label borrowlabel;
        private Button returnbutton;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}