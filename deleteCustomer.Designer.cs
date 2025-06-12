namespace Project
{
    partial class deleteCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteCustomer));
            headerpanel = new Panel();
            deletecustlabel = new Label();
            sidepanel = new Panel();
            deletebutton = new Button();
            deletecomboBox = new ComboBox();
            sidepictureBox = new PictureBox();
            headerpanel.SuspendLayout();
            sidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sidepictureBox).BeginInit();
            SuspendLayout();
            // 
            // headerpanel
            // 
            headerpanel.BackColor = Color.Sienna;
            headerpanel.Controls.Add(deletecustlabel);
            headerpanel.Location = new Point(0, 0);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(952, 83);
            headerpanel.TabIndex = 0;
            // 
            // deletecustlabel
            // 
            deletecustlabel.AutoSize = true;
            deletecustlabel.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletecustlabel.ForeColor = SystemColors.Control;
            deletecustlabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            deletecustlabel.Location = new Point(312, 25);
            deletecustlabel.Name = "deletecustlabel";
            deletecustlabel.Size = new Size(310, 40);
            deletecustlabel.TabIndex = 0;
            deletecustlabel.Text = "Delete a Customer Tab";
            // 
            // sidepanel
            // 
            sidepanel.BackColor = Color.Chocolate;
            sidepanel.Controls.Add(deletebutton);
            sidepanel.Controls.Add(deletecomboBox);
            sidepanel.Location = new Point(415, 83);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(538, 494);
            sidepanel.TabIndex = 1;
            // 
            // deletebutton
            // 
            deletebutton.FlatStyle = FlatStyle.Popup;
            deletebutton.ForeColor = SystemColors.Control;
            deletebutton.Location = new Point(230, 167);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(94, 29);
            deletebutton.TabIndex = 1;
            deletebutton.Text = "Delete";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // deletecomboBox
            // 
            deletecomboBox.FormattingEnabled = true;
            deletecomboBox.Location = new Point(96, 232);
            deletecomboBox.Name = "deletecomboBox";
            deletecomboBox.RightToLeft = RightToLeft.Yes;
            deletecomboBox.Size = new Size(374, 28);
            deletecomboBox.TabIndex = 0;
            deletecomboBox.SelectedIndexChanged += deletecomboBox_SelectedIndexChanged;
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
            // deleteCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 569);
            Controls.Add(sidepictureBox);
            Controls.Add(sidepanel);
            Controls.Add(headerpanel);
            Name = "deleteCustomer";
            Text = "Delete a Customer";
            headerpanel.ResumeLayout(false);
            headerpanel.PerformLayout();
            sidepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sidepictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerpanel;
        private Panel sidepanel;
        private PictureBox sidepictureBox;
        private Label deletecustlabel;
        private Button deletebutton;
        private ComboBox deletecomboBox;
    }
}