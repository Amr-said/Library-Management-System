namespace Project
{
    partial class addBorrowing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBorrowing));
            headerpanel = new Panel();
            addborrowinglabel = new Label();
            bodypanel = new Panel();
            explabel = new Label();
            addbutton = new Button();
            issuelabel = new Label();
            expectedReturnDatePicker = new DateTimePicker();
            btitlelabel = new Label();
            borrowDatePicker = new DateTimePicker();
            cnamelabel = new Label();
            customerComboBox = new ComboBox();
            bookComboBox = new ComboBox();
            sidepictureBox = new PictureBox();
            headerpanel.SuspendLayout();
            bodypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sidepictureBox).BeginInit();
            SuspendLayout();
            // 
            // headerpanel
            // 
            headerpanel.BackColor = Color.Sienna;
            headerpanel.Controls.Add(addborrowinglabel);
            headerpanel.Location = new Point(0, 0);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(952, 83);
            headerpanel.TabIndex = 0;
            // 
            // addborrowinglabel
            // 
            addborrowinglabel.AutoSize = true;
            addborrowinglabel.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addborrowinglabel.ForeColor = SystemColors.Control;
            addborrowinglabel.Location = new Point(325, 25);
            addborrowinglabel.Name = "addborrowinglabel";
            addborrowinglabel.Size = new Size(284, 40);
            addborrowinglabel.TabIndex = 0;
            addborrowinglabel.Text = "Add a Borrowing Tab";
            // 
            // bodypanel
            // 
            bodypanel.BackColor = Color.Chocolate;
            bodypanel.Controls.Add(explabel);
            bodypanel.Controls.Add(addbutton);
            bodypanel.Controls.Add(issuelabel);
            bodypanel.Controls.Add(expectedReturnDatePicker);
            bodypanel.Controls.Add(btitlelabel);
            bodypanel.Controls.Add(borrowDatePicker);
            bodypanel.Controls.Add(cnamelabel);
            bodypanel.Controls.Add(customerComboBox);
            bodypanel.Controls.Add(bookComboBox);
            bodypanel.Location = new Point(415, 83);
            bodypanel.Name = "bodypanel";
            bodypanel.Size = new Size(538, 494);
            bodypanel.TabIndex = 1;
            // 
            // explabel
            // 
            explabel.AutoSize = true;
            explabel.Font = new Font("Segoe UI", 12F);
            explabel.ForeColor = SystemColors.Control;
            explabel.Location = new Point(52, 297);
            explabel.Name = "explabel";
            explabel.Size = new Size(199, 28);
            explabel.TabIndex = 9;
            explabel.Text = "Expected Return Date";
            // 
            // addbutton
            // 
            addbutton.FlatStyle = FlatStyle.Popup;
            addbutton.ForeColor = SystemColors.Control;
            addbutton.Location = new Point(213, 373);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(94, 29);
            addbutton.TabIndex = 4;
            addbutton.Text = "Add";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // issuelabel
            // 
            issuelabel.AutoSize = true;
            issuelabel.Font = new Font("Segoe UI", 12F);
            issuelabel.ForeColor = SystemColors.Control;
            issuelabel.Location = new Point(52, 228);
            issuelabel.Name = "issuelabel";
            issuelabel.Size = new Size(121, 28);
            issuelabel.TabIndex = 8;
            issuelabel.Text = "Borrow Date";
            // 
            // expectedReturnDatePicker
            // 
            expectedReturnDatePicker.Location = new Point(268, 299);
            expectedReturnDatePicker.Name = "expectedReturnDatePicker";
            expectedReturnDatePicker.Size = new Size(250, 27);
            expectedReturnDatePicker.TabIndex = 7;
            // 
            // btitlelabel
            // 
            btitlelabel.AutoSize = true;
            btitlelabel.Font = new Font("Segoe UI", 12F);
            btitlelabel.ForeColor = SystemColors.Control;
            btitlelabel.Location = new Point(52, 156);
            btitlelabel.Name = "btitlelabel";
            btitlelabel.Size = new Size(99, 28);
            btitlelabel.TabIndex = 5;
            btitlelabel.Text = "Book Title";
            // 
            // borrowDatePicker
            // 
            borrowDatePicker.Location = new Point(268, 228);
            borrowDatePicker.Name = "borrowDatePicker";
            borrowDatePicker.Size = new Size(250, 27);
            borrowDatePicker.TabIndex = 1;
            // 
            // cnamelabel
            // 
            cnamelabel.AutoSize = true;
            cnamelabel.Font = new Font("Segoe UI", 12F);
            cnamelabel.ForeColor = SystemColors.Control;
            cnamelabel.Location = new Point(52, 80);
            cnamelabel.Name = "cnamelabel";
            cnamelabel.Size = new Size(153, 28);
            cnamelabel.TabIndex = 0;
            cnamelabel.Text = "Customer Name";
            // 
            // customerComboBox
            // 
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(268, 80);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(250, 28);
            customerComboBox.TabIndex = 2;
            // 
            // bookComboBox
            // 
            bookComboBox.FormattingEnabled = true;
            bookComboBox.Location = new Point(268, 156);
            bookComboBox.Name = "bookComboBox";
            bookComboBox.Size = new Size(250, 28);
            bookComboBox.TabIndex = 3;
            // 
            // sidepictureBox
            // 
            sidepictureBox.Image = (Image)resources.GetObject("sidepictureBox.Image");
            sidepictureBox.Location = new Point(0, 83);
            sidepictureBox.Name = "sidepictureBox";
            sidepictureBox.Size = new Size(416, 491);
            sidepictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            sidepictureBox.TabIndex = 6;
            sidepictureBox.TabStop = false;
            // 
            // addBorrowing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 569);
            Controls.Add(sidepictureBox);
            Controls.Add(bodypanel);
            Controls.Add(headerpanel);
            Name = "addBorrowing";
            Text = "Add a Borrowing";
            headerpanel.ResumeLayout(false);
            headerpanel.PerformLayout();
            bodypanel.ResumeLayout(false);
            bodypanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sidepictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerpanel;
        private Panel bodypanel;
        private Label cnamelabel;
        private ComboBox customerComboBox;
        private ComboBox bookComboBox;
        private Button addbutton;
        private Label btitlelabel;
        private PictureBox sidepictureBox;
        private Label addborrowinglabel;
        private DateTimePicker expectedReturnDatePicker;
        private DateTimePicker borrowDatePicker;
        private Label explabel;
        private Label issuelabel;
    }
}