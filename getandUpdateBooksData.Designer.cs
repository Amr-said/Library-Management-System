namespace Project
{
    partial class getandUpdateBooksData
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
            headerpanel = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            availabilitylabel = new Label();
            authorlabel = new Label();
            yearlabel = new Label();
            isbnlabel = new Label();
            titlelabel = new Label();
            availabilitycheckBox = new CheckBox();
            titletextBox = new TextBox();
            authortextBox = new TextBox();
            isbntextBox = new TextBox();
            yeartextBox = new TextBox();
            _updateButton = new Button();
            View = new Button();
            dataGridView = new DataGridView();
            headerpanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // headerpanel
            // 
            headerpanel.BackColor = Color.Sienna;
            headerpanel.Controls.Add(label1);
            headerpanel.Location = new Point(0, 0);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(951, 83);
            headerpanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Sienna;
            label1.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(267, 25);
            label1.Name = "label1";
            label1.Size = new Size(389, 40);
            label1.TabIndex = 0;
            label1.Text = "View and Update Books Data";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Chocolate;
            panel2.Controls.Add(availabilitylabel);
            panel2.Controls.Add(authorlabel);
            panel2.Controls.Add(yearlabel);
            panel2.Controls.Add(isbnlabel);
            panel2.Controls.Add(titlelabel);
            panel2.Controls.Add(availabilitycheckBox);
            panel2.Controls.Add(titletextBox);
            panel2.Controls.Add(authortextBox);
            panel2.Controls.Add(isbntextBox);
            panel2.Controls.Add(yeartextBox);
            panel2.Controls.Add(_updateButton);
            panel2.Controls.Add(View);
            panel2.Controls.Add(dataGridView);
            panel2.Location = new Point(0, 83);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(951, 485);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // availabilitylabel
            // 
            availabilitylabel.AutoSize = true;
            availabilitylabel.Font = new Font("Arial Narrow", 13.8F);
            availabilitylabel.ForeColor = SystemColors.Control;
            availabilitylabel.Location = new Point(591, 415);
            availabilitylabel.Name = "availabilitylabel";
            availabilitylabel.Size = new Size(98, 27);
            availabilitylabel.TabIndex = 13;
            availabilitylabel.Text = "Availability";
            // 
            // authorlabel
            // 
            authorlabel.AutoSize = true;
            authorlabel.Font = new Font("Arial Narrow", 13.8F);
            authorlabel.ForeColor = SystemColors.Control;
            authorlabel.Location = new Point(591, 368);
            authorlabel.Name = "authorlabel";
            authorlabel.Size = new Size(121, 27);
            authorlabel.TabIndex = 12;
            authorlabel.Text = "Author Name";
            // 
            // yearlabel
            // 
            yearlabel.AutoSize = true;
            yearlabel.Font = new Font("Arial Narrow", 13.8F);
            yearlabel.ForeColor = SystemColors.Control;
            yearlabel.Location = new Point(591, 323);
            yearlabel.Name = "yearlabel";
            yearlabel.Size = new Size(116, 27);
            yearlabel.TabIndex = 11;
            yearlabel.Text = "Publish Year";
            // 
            // isbnlabel
            // 
            isbnlabel.AutoSize = true;
            isbnlabel.Font = new Font("Arial Narrow", 13.8F);
            isbnlabel.ForeColor = SystemColors.Control;
            isbnlabel.Location = new Point(297, 366);
            isbnlabel.Name = "isbnlabel";
            isbnlabel.Size = new Size(56, 27);
            isbnlabel.TabIndex = 10;
            isbnlabel.Text = "ISBN";
            // 
            // titlelabel
            // 
            titlelabel.AutoSize = true;
            titlelabel.Font = new Font("Arial Narrow", 13.8F);
            titlelabel.ForeColor = SystemColors.Control;
            titlelabel.Location = new Point(297, 322);
            titlelabel.Name = "titlelabel";
            titlelabel.Size = new Size(94, 27);
            titlelabel.TabIndex = 9;
            titlelabel.Text = "Book Title";
            // 
            // availabilitycheckBox
            // 
            availabilitycheckBox.AutoSize = true;
            availabilitycheckBox.Location = new Point(724, 422);
            availabilitycheckBox.Name = "availabilitycheckBox";
            availabilitycheckBox.Size = new Size(18, 17);
            availabilitycheckBox.TabIndex = 8;
            availabilitycheckBox.UseVisualStyleBackColor = true;
            availabilitycheckBox.CheckedChanged += availabilitycheckBox_CheckedChanged;
            // 
            // titletextBox
            // 
            titletextBox.Location = new Point(393, 322);
            titletextBox.Name = "titletextBox";
            titletextBox.Size = new Size(125, 27);
            titletextBox.TabIndex = 7;
            titletextBox.TextChanged += titletextBox_TextChanged;
            // 
            // authortextBox
            // 
            authortextBox.Location = new Point(724, 368);
            authortextBox.Name = "authortextBox";
            authortextBox.Size = new Size(125, 27);
            authortextBox.TabIndex = 5;
            authortextBox.TextChanged += authortextBox_TextChanged;
            // 
            // isbntextBox
            // 
            isbntextBox.Location = new Point(393, 366);
            isbntextBox.Name = "isbntextBox";
            isbntextBox.Size = new Size(125, 27);
            isbntextBox.TabIndex = 4;
            isbntextBox.TextChanged += isbntextBox_TextChanged;
            // 
            // yeartextBox
            // 
            yeartextBox.Location = new Point(724, 322);
            yeartextBox.Name = "yeartextBox";
            yeartextBox.Size = new Size(125, 27);
            yeartextBox.TabIndex = 3;
            yeartextBox.TextChanged += yeartextBox_TextChanged;
            // 
            // _updateButton
            // 
            _updateButton.FlatStyle = FlatStyle.Popup;
            _updateButton.ForeColor = SystemColors.Control;
            _updateButton.Location = new Point(94, 366);
            _updateButton.Name = "_updateButton";
            _updateButton.Size = new Size(94, 29);
            _updateButton.TabIndex = 2;
            _updateButton.Text = "Update Data";
            _updateButton.UseVisualStyleBackColor = true;
            _updateButton.Click += _updateButton_Click;
            // 
            // View
            // 
            View.FlatStyle = FlatStyle.Popup;
            View.ForeColor = SystemColors.Control;
            View.Location = new Point(94, 320);
            View.Name = "View";
            View.Size = new Size(94, 29);
            View.TabIndex = 1;
            View.Text = "View Data";
            View.UseVisualStyleBackColor = true;
            View.Click += View_Click;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BackgroundColor = Color.SeaShell;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.GridColor = Color.Tomato;
            dataGridView.Location = new Point(94, 23);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(755, 276);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.RowHeaderMouseClick += dataGridView_RowHeaderMouseClick_1;
            // 
            // getandUpdateBooksData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 569);
            Controls.Add(panel2);
            Controls.Add(headerpanel);
            Name = "getandUpdateBooksData";
            Text = "View and Update Books Data";
            Load += getandUpdateBooksData_Load;
            headerpanel.ResumeLayout(false);
            headerpanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerpanel;
        private Panel panel2;
        private DataGridView dataGridView;
        private Label label1;
        private Button View;
        private Button _updateButton;
        private CheckBox checkBox1;
        private TextBox titletextBox;
        private CheckBox availabilitycheckBox;
        private TextBox isbntextBox;
        private TextBox authortextBox;
        private TextBox yeartextBox;
        private Label availabilitylabel;
        private Label authorlabel;
        private Label yearlabel;
        private Label isbnlabel;
        private Label titlelabel;
    }
}