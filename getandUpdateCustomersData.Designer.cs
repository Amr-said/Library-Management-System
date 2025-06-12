namespace Project
{
    partial class getandUpdateCustomersData
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            headerpanel = new Panel();
            viewandupdatelabel = new Label();
            bodypanel = new Panel();
            expiryDatePicker = new DateTimePicker();
            issueDatePicker = new DateTimePicker();
            cityTextBox = new TextBox();
            streetTextBox = new TextBox();
            postalCodeTextBox = new TextBox();
            cardNumberTextBox = new TextBox();
            phoneTextBox = new TextBox();
            nameTextBox = new TextBox();
            expiraylabel = new Label();
            pclabel = new Label();
            citylabel = new Label();
            streetlabel = new Label();
            issuelabel = new Label();
            cardlabel = new Label();
            phonelabel = new Label();
            updatebutton = new Button();
            viewbutton = new Button();
            dataGridView = new DataGridView();
            namelabel = new Label();
            headerpanel.SuspendLayout();
            bodypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // headerpanel
            // 
            headerpanel.BackColor = Color.Sienna;
            headerpanel.Controls.Add(viewandupdatelabel);
            headerpanel.Location = new Point(0, 0);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(1034, 83);
            headerpanel.TabIndex = 0;
            // 
            // viewandupdatelabel
            // 
            viewandupdatelabel.AutoSize = true;
            viewandupdatelabel.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewandupdatelabel.ForeColor = SystemColors.Control;
            viewandupdatelabel.Location = new Point(267, 22);
            viewandupdatelabel.Name = "viewandupdatelabel";
            viewandupdatelabel.Size = new Size(432, 40);
            viewandupdatelabel.TabIndex = 0;
            viewandupdatelabel.Text = "View and Update Customer Data";
            // 
            // bodypanel
            // 
            bodypanel.BackColor = Color.Chocolate;
            bodypanel.Controls.Add(expiryDatePicker);
            bodypanel.Controls.Add(issueDatePicker);
            bodypanel.Controls.Add(cityTextBox);
            bodypanel.Controls.Add(streetTextBox);
            bodypanel.Controls.Add(postalCodeTextBox);
            bodypanel.Controls.Add(cardNumberTextBox);
            bodypanel.Controls.Add(phoneTextBox);
            bodypanel.Controls.Add(nameTextBox);
            bodypanel.Controls.Add(expiraylabel);
            bodypanel.Controls.Add(pclabel);
            bodypanel.Controls.Add(citylabel);
            bodypanel.Controls.Add(streetlabel);
            bodypanel.Controls.Add(issuelabel);
            bodypanel.Controls.Add(cardlabel);
            bodypanel.Controls.Add(phonelabel);
            bodypanel.Controls.Add(updatebutton);
            bodypanel.Controls.Add(viewbutton);
            bodypanel.Controls.Add(dataGridView);
            bodypanel.Controls.Add(namelabel);
            bodypanel.Font = new Font("Arial Narrow", 12F);
            bodypanel.ForeColor = SystemColors.Control;
            bodypanel.Location = new Point(0, 83);
            bodypanel.Name = "bodypanel";
            bodypanel.Size = new Size(1034, 541);
            bodypanel.TabIndex = 1;
            // 
            // expiryDatePicker
            // 
            expiryDatePicker.Location = new Point(749, 442);
            expiryDatePicker.Name = "expiryDatePicker";
            expiryDatePicker.Size = new Size(250, 30);
            expiryDatePicker.TabIndex = 18;
            expiryDatePicker.ValueChanged += expiryDatePicker_ValueChanged;
            // 
            // issueDatePicker
            // 
            issueDatePicker.Location = new Point(331, 442);
            issueDatePicker.Name = "issueDatePicker";
            issueDatePicker.Size = new Size(250, 30);
            issueDatePicker.TabIndex = 17;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(749, 356);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(125, 30);
            cityTextBox.TabIndex = 16;
            // 
            // streetTextBox
            // 
            streetTextBox.Location = new Point(749, 316);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(125, 30);
            streetTextBox.TabIndex = 15;
            // 
            // postalCodeTextBox
            // 
            postalCodeTextBox.Location = new Point(749, 398);
            postalCodeTextBox.Name = "postalCodeTextBox";
            postalCodeTextBox.Size = new Size(125, 30);
            postalCodeTextBox.TabIndex = 14;
            // 
            // cardNumberTextBox
            // 
            cardNumberTextBox.Location = new Point(331, 398);
            cardNumberTextBox.Name = "cardNumberTextBox";
            cardNumberTextBox.Size = new Size(125, 30);
            cardNumberTextBox.TabIndex = 13;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(331, 356);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(125, 30);
            phoneTextBox.TabIndex = 12;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(331, 316);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 30);
            nameTextBox.TabIndex = 11;
            // 
            // expiraylabel
            // 
            expiraylabel.AutoSize = true;
            expiraylabel.Font = new Font("Arial Narrow", 12F);
            expiraylabel.ForeColor = SystemColors.Control;
            expiraylabel.Location = new Point(637, 448);
            expiraylabel.Name = "expiraylabel";
            expiraylabel.Size = new Size(95, 24);
            expiraylabel.TabIndex = 10;
            expiraylabel.Text = "Expiry Date";
            // 
            // pclabel
            // 
            pclabel.AutoSize = true;
            pclabel.Font = new Font("Arial Narrow", 12F);
            pclabel.ForeColor = SystemColors.Control;
            pclabel.Location = new Point(637, 404);
            pclabel.Name = "pclabel";
            pclabel.Size = new Size(99, 24);
            pclabel.TabIndex = 9;
            pclabel.Text = "Postal Code";
            // 
            // citylabel
            // 
            citylabel.AutoSize = true;
            citylabel.Font = new Font("Arial Narrow", 12F);
            citylabel.ForeColor = SystemColors.Control;
            citylabel.Location = new Point(637, 361);
            citylabel.Name = "citylabel";
            citylabel.Size = new Size(39, 24);
            citylabel.TabIndex = 8;
            citylabel.Text = "City";
            // 
            // streetlabel
            // 
            streetlabel.AutoSize = true;
            streetlabel.Font = new Font("Arial Narrow", 12F);
            streetlabel.ForeColor = SystemColors.Control;
            streetlabel.Location = new Point(637, 322);
            streetlabel.Name = "streetlabel";
            streetlabel.Size = new Size(54, 24);
            streetlabel.TabIndex = 7;
            streetlabel.Text = "Street";
            // 
            // issuelabel
            // 
            issuelabel.AutoSize = true;
            issuelabel.Font = new Font("Arial Narrow", 12F);
            issuelabel.ForeColor = SystemColors.Control;
            issuelabel.Location = new Point(212, 448);
            issuelabel.Name = "issuelabel";
            issuelabel.Size = new Size(89, 24);
            issuelabel.TabIndex = 6;
            issuelabel.Text = "Issue Date";
            // 
            // cardlabel
            // 
            cardlabel.AutoSize = true;
            cardlabel.Font = new Font("Arial Narrow", 12F);
            cardlabel.ForeColor = SystemColors.Control;
            cardlabel.Location = new Point(212, 404);
            cardlabel.Name = "cardlabel";
            cardlabel.Size = new Size(109, 24);
            cardlabel.TabIndex = 5;
            cardlabel.Text = "Card Number";
            // 
            // phonelabel
            // 
            phonelabel.AutoSize = true;
            phonelabel.Font = new Font("Arial Narrow", 12F);
            phonelabel.ForeColor = SystemColors.Control;
            phonelabel.Location = new Point(212, 362);
            phonelabel.Name = "phonelabel";
            phonelabel.Size = new Size(57, 24);
            phonelabel.TabIndex = 4;
            phonelabel.Text = "Phone";
            // 
            // updatebutton
            // 
            updatebutton.FlatStyle = FlatStyle.Popup;
            updatebutton.Font = new Font("Segoe UI", 10.2F);
            updatebutton.ForeColor = SystemColors.Control;
            updatebutton.Location = new Point(36, 413);
            updatebutton.Name = "updatebutton";
            updatebutton.Size = new Size(94, 29);
            updatebutton.TabIndex = 3;
            updatebutton.Text = "Update";
            updatebutton.UseVisualStyleBackColor = true;
            updatebutton.Click += updatebutton_Click;
            // 
            // viewbutton
            // 
            viewbutton.FlatStyle = FlatStyle.Popup;
            viewbutton.Font = new Font("Segoe UI", 10.2F);
            viewbutton.ForeColor = SystemColors.Control;
            viewbutton.Location = new Point(36, 359);
            viewbutton.Name = "viewbutton";
            viewbutton.Size = new Size(94, 29);
            viewbutton.TabIndex = 2;
            viewbutton.Text = "View";
            viewbutton.UseVisualStyleBackColor = true;
            viewbutton.Click += viewbutton_Click;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BackgroundColor = Color.SeaShell;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.GridColor = SystemColors.WindowText;
            dataGridView.Location = new Point(94, 23);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(755, 276);
            dataGridView.TabIndex = 1;
            dataGridView.RowHeaderMouseClick += dataGridView_RowHeaderMouseClick;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Font = new Font("Arial Narrow", 12F);
            namelabel.ForeColor = SystemColors.Control;
            namelabel.Location = new Point(212, 322);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(55, 24);
            namelabel.TabIndex = 0;
            namelabel.Text = "Name";
            // 
            // getandUpdateCustomersData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 618);
            Controls.Add(bodypanel);
            Controls.Add(headerpanel);
            Name = "getandUpdateCustomersData";
            Text = "View and Update Customers Data";
            headerpanel.ResumeLayout(false);
            headerpanel.PerformLayout();
            bodypanel.ResumeLayout(false);
            bodypanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerpanel;
        private Panel bodypanel;
        private Label viewandupdatelabel;
        private Label namelabel;
        private DataGridView dataGridView;
        private Button updatebutton;
        private Button viewbutton;
        private Label expiraylabel;
        private Label pclabel;
        private Label citylabel;
        private Label streetlabel;
        private Label issuelabel;
        private Label cardlabel;
        private Label phonelabel;
        private TextBox cityTextBox;
        private TextBox streetTextBox;
        private TextBox postalCodeTextBox;
        private TextBox cardNumberTextBox;
        private TextBox phoneTextBox;
        private TextBox nameTextBox;
        private DateTimePicker issueDatePicker;
        private DateTimePicker expiryDatePicker;
    }
}