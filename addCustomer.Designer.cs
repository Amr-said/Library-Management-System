namespace Project
{
    partial class addCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCustomer));
            headerpanel = new Panel();
            addCustomerlabel = new Label();
            sidepanel = new Panel();
            nametextBox = new TextBox();
            expiraydateTimePicker = new DateTimePicker();
            issuedateTimePicker = new DateTimePicker();
            cardtextBox = new TextBox();
            pctextBox = new TextBox();
            citytextBox = new TextBox();
            streettextBox = new TextBox();
            phonetextBox = new TextBox();
            addCustButton = new Button();
            expiraylabel = new Label();
            issuelabel = new Label();
            custcardlabel = new Label();
            custpclabel = new Label();
            custcitylabel = new Label();
            custstreetlabel = new Label();
            custphonelabel = new Label();
            Custnamelabel = new Label();
            sidepictureBox = new PictureBox();
            headerpanel.SuspendLayout();
            sidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sidepictureBox).BeginInit();
            SuspendLayout();
            // 
            // headerpanel
            // 
            headerpanel.BackColor = Color.Sienna;
            headerpanel.Controls.Add(addCustomerlabel);
            headerpanel.Location = new Point(0, 0);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(952, 83);
            headerpanel.TabIndex = 0;
            headerpanel.Paint += headerpanel_Paint;
            // 
            // addCustomerlabel
            // 
            addCustomerlabel.AutoSize = true;
            addCustomerlabel.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCustomerlabel.ForeColor = SystemColors.Control;
            addCustomerlabel.Location = new Point(329, 22);
            addCustomerlabel.Name = "addCustomerlabel";
            addCustomerlabel.Size = new Size(279, 40);
            addCustomerlabel.TabIndex = 3;
            addCustomerlabel.Text = "Add a Customer Tab";
            // 
            // sidepanel
            // 
            sidepanel.BackColor = Color.Chocolate;
            sidepanel.Controls.Add(nametextBox);
            sidepanel.Controls.Add(expiraydateTimePicker);
            sidepanel.Controls.Add(issuedateTimePicker);
            sidepanel.Controls.Add(cardtextBox);
            sidepanel.Controls.Add(pctextBox);
            sidepanel.Controls.Add(citytextBox);
            sidepanel.Controls.Add(streettextBox);
            sidepanel.Controls.Add(phonetextBox);
            sidepanel.Controls.Add(addCustButton);
            sidepanel.Controls.Add(expiraylabel);
            sidepanel.Controls.Add(issuelabel);
            sidepanel.Controls.Add(custcardlabel);
            sidepanel.Controls.Add(custpclabel);
            sidepanel.Controls.Add(custcitylabel);
            sidepanel.Controls.Add(custstreetlabel);
            sidepanel.Controls.Add(custphonelabel);
            sidepanel.Controls.Add(Custnamelabel);
            sidepanel.Location = new Point(415, 83);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(538, 494);
            sidepanel.TabIndex = 1;
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(233, 39);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(125, 27);
            nametextBox.TabIndex = 17;
            // 
            // expiraydateTimePicker
            // 
            expiraydateTimePicker.Location = new Point(233, 302);
            expiraydateTimePicker.Name = "expiraydateTimePicker";
            expiraydateTimePicker.Size = new Size(250, 27);
            expiraydateTimePicker.TabIndex = 16;
            // 
            // issuedateTimePicker
            // 
            issuedateTimePicker.Location = new Point(233, 266);
            issuedateTimePicker.Name = "issuedateTimePicker";
            issuedateTimePicker.Size = new Size(250, 27);
            issuedateTimePicker.TabIndex = 15;
            // 
            // cardtextBox
            // 
            cardtextBox.Location = new Point(233, 228);
            cardtextBox.Name = "cardtextBox";
            cardtextBox.Size = new Size(125, 27);
            cardtextBox.TabIndex = 14;
            // 
            // pctextBox
            // 
            pctextBox.Location = new Point(233, 191);
            pctextBox.Name = "pctextBox";
            pctextBox.Size = new Size(125, 27);
            pctextBox.TabIndex = 13;
            // 
            // citytextBox
            // 
            citytextBox.Location = new Point(233, 154);
            citytextBox.Name = "citytextBox";
            citytextBox.Size = new Size(125, 27);
            citytextBox.TabIndex = 12;
            // 
            // streettextBox
            // 
            streettextBox.Location = new Point(233, 116);
            streettextBox.Name = "streettextBox";
            streettextBox.Size = new Size(125, 27);
            streettextBox.TabIndex = 11;
            // 
            // phonetextBox
            // 
            phonetextBox.Location = new Point(233, 78);
            phonetextBox.Name = "phonetextBox";
            phonetextBox.Size = new Size(125, 27);
            phonetextBox.TabIndex = 10;
            // 
            // addCustButton
            // 
            addCustButton.FlatStyle = FlatStyle.Popup;
            addCustButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCustButton.ForeColor = SystemColors.Control;
            addCustButton.Location = new Point(155, 356);
            addCustButton.Name = "addCustButton";
            addCustButton.Size = new Size(136, 29);
            addCustButton.TabIndex = 8;
            addCustButton.Text = "Add Customer";
            addCustButton.UseVisualStyleBackColor = true;
            addCustButton.Click += addCustButton_Click;
            // 
            // expiraylabel
            // 
            expiraylabel.AutoSize = true;
            expiraylabel.Font = new Font("Arial Narrow", 13.8F);
            expiraylabel.ForeColor = SystemColors.Control;
            expiraylabel.Location = new Point(54, 302);
            expiraylabel.Name = "expiraylabel";
            expiraylabel.Size = new Size(107, 27);
            expiraylabel.TabIndex = 7;
            expiraylabel.Text = "Expiry Date";
            expiraylabel.Click += expiraylabel_Click;
            // 
            // issuelabel
            // 
            issuelabel.AutoSize = true;
            issuelabel.Font = new Font("Arial Narrow", 13.8F);
            issuelabel.ForeColor = SystemColors.Control;
            issuelabel.Location = new Point(54, 266);
            issuelabel.Name = "issuelabel";
            issuelabel.Size = new Size(98, 27);
            issuelabel.TabIndex = 6;
            issuelabel.Text = "Issue Date";
            // 
            // custcardlabel
            // 
            custcardlabel.AutoSize = true;
            custcardlabel.Font = new Font("Arial Narrow", 13.8F);
            custcardlabel.ForeColor = SystemColors.Control;
            custcardlabel.Location = new Point(54, 228);
            custcardlabel.Name = "custcardlabel";
            custcardlabel.Size = new Size(123, 27);
            custcardlabel.TabIndex = 5;
            custcardlabel.Text = "Card Number";
            // 
            // custpclabel
            // 
            custpclabel.AutoSize = true;
            custpclabel.Font = new Font("Arial Narrow", 13.8F);
            custpclabel.ForeColor = SystemColors.Control;
            custpclabel.Location = new Point(54, 191);
            custpclabel.Name = "custpclabel";
            custpclabel.Size = new Size(112, 27);
            custpclabel.TabIndex = 4;
            custpclabel.Text = "Postal Code";
            // 
            // custcitylabel
            // 
            custcitylabel.AutoSize = true;
            custcitylabel.Font = new Font("Arial Narrow", 13.8F);
            custcitylabel.ForeColor = SystemColors.Control;
            custcitylabel.Location = new Point(54, 152);
            custcitylabel.Name = "custcitylabel";
            custcitylabel.Size = new Size(44, 27);
            custcitylabel.TabIndex = 3;
            custcitylabel.Text = "City";
            // 
            // custstreetlabel
            // 
            custstreetlabel.AutoSize = true;
            custstreetlabel.Font = new Font("Arial Narrow", 13.8F);
            custstreetlabel.ForeColor = SystemColors.Control;
            custstreetlabel.Location = new Point(54, 116);
            custstreetlabel.Name = "custstreetlabel";
            custstreetlabel.Size = new Size(61, 27);
            custstreetlabel.TabIndex = 2;
            custstreetlabel.Text = "Street";
            // 
            // custphonelabel
            // 
            custphonelabel.AutoSize = true;
            custphonelabel.Font = new Font("Arial Narrow", 13.8F);
            custphonelabel.ForeColor = SystemColors.Control;
            custphonelabel.Location = new Point(54, 78);
            custphonelabel.Name = "custphonelabel";
            custphonelabel.Size = new Size(65, 27);
            custphonelabel.TabIndex = 1;
            custphonelabel.Text = "Phone";
            // 
            // Custnamelabel
            // 
            Custnamelabel.AutoSize = true;
            Custnamelabel.Font = new Font("Arial Narrow", 13.8F);
            Custnamelabel.ForeColor = SystemColors.Control;
            Custnamelabel.Location = new Point(54, 39);
            Custnamelabel.Name = "Custnamelabel";
            Custnamelabel.Size = new Size(62, 27);
            Custnamelabel.TabIndex = 0;
            Custnamelabel.Text = "Name";
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
            // addCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 569);
            Controls.Add(sidepictureBox);
            Controls.Add(sidepanel);
            Controls.Add(headerpanel);
            Name = "addCustomer";
            Text = "Add a Customer";
            Load += addCustomer_Load;
            headerpanel.ResumeLayout(false);
            headerpanel.PerformLayout();
            sidepanel.ResumeLayout(false);
            sidepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sidepictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerpanel;
        private Panel sidepanel;
        private PictureBox sidepictureBox;
        private Label addCustomerlabel;
        private DateTimePicker expiraydateTimePicker;
        private DateTimePicker issuedateTimePicker;
        private TextBox cardtextBox;
        private TextBox pctextBox;
        private TextBox citytextBox;
        private TextBox streettextBox;
        private TextBox phonetextBox;
        private Button addCustButton;
        private Label expiraylabel;
        private Label issuelabel;
        private Label custcardlabel;
        private Label custpclabel;
        private Label custcitylabel;
        private Label custstreetlabel;
        private Label custphonelabel;
        private Label Custnamelabel;
        private TextBox nametextBox;
    }
}