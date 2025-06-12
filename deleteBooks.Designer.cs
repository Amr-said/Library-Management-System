namespace Project
{
    partial class deleteBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteBooks));
            headerpanel = new Panel();
            deletelabel = new Label();
            sidepanel = new Panel();
            deletebutton = new Button();
            deleteComboBox = new ComboBox();
            sidepictureBox = new PictureBox();
            headerpanel.SuspendLayout();
            sidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sidepictureBox).BeginInit();
            SuspendLayout();
            // 
            // headerpanel
            // 
            headerpanel.BackColor = Color.Sienna;
            headerpanel.Controls.Add(deletelabel);
            headerpanel.Location = new Point(0, 0);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(952, 83);
            headerpanel.TabIndex = 0;
            // 
            // deletelabel
            // 
            deletelabel.AutoSize = true;
            deletelabel.BackColor = Color.Sienna;
            deletelabel.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletelabel.ForeColor = SystemColors.Control;
            deletelabel.Location = new Point(358, 28);
            deletelabel.Name = "deletelabel";
            deletelabel.Size = new Size(250, 40);
            deletelabel.TabIndex = 3;
            deletelabel.Text = "Delete a book Tab";
            // 
            // sidepanel
            // 
            sidepanel.BackColor = Color.Chocolate;
            sidepanel.Controls.Add(deletebutton);
            sidepanel.Controls.Add(deleteComboBox);
            sidepanel.Location = new Point(415, 83);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(538, 494);
            sidepanel.TabIndex = 2;
            // 
            // deletebutton
            // 
            deletebutton.FlatStyle = FlatStyle.Popup;
            deletebutton.ForeColor = SystemColors.Control;
            deletebutton.Location = new Point(230, 167);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(94, 29);
            deletebutton.TabIndex = 3;
            deletebutton.Text = "Delete";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // deleteComboBox
            // 
            deleteComboBox.FormattingEnabled = true;
            deleteComboBox.Location = new Point(96, 232);
            deleteComboBox.Name = "deleteComboBox";
            deleteComboBox.Size = new Size(374, 28);
            deleteComboBox.TabIndex = 2;
            deleteComboBox.SelectedIndexChanged += deleteComboBox_SelectedIndexChanged;
            // 
            // sidepictureBox
            // 
            sidepictureBox.Image = (Image)resources.GetObject("sidepictureBox.Image");
            sidepictureBox.Location = new Point(0, 84);
            sidepictureBox.Name = "sidepictureBox";
            sidepictureBox.Size = new Size(416, 490);
            sidepictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            sidepictureBox.TabIndex = 4;
            sidepictureBox.TabStop = false;
            // 
            // deleteBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 569);
            Controls.Add(sidepictureBox);
            Controls.Add(sidepanel);
            Controls.Add(headerpanel);
            Name = "deleteBooks";
            Text = "Delete a Book";
            Load += deleteBooks_Load_1;
            headerpanel.ResumeLayout(false);
            headerpanel.PerformLayout();
            sidepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sidepictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerpanel;
        private Panel sidepanel;
        private Label deletelabel;
        private PictureBox sidepictureBox;
        private ComboBox deleteComboBox;
        private Button deletebutton;
    }
}