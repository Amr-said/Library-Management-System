namespace Project
{
    partial class searchBooks
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
            panel1 = new Panel();
            _search_label = new Label();
            panel2 = new Panel();
            _searchtextBox = new TextBox();
            dataGridView = new DataGridView();
            _Search = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(_search_label);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 83);
            panel1.TabIndex = 0;
            // 
            // _search_label
            // 
            _search_label.AutoSize = true;
            _search_label.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _search_label.ForeColor = SystemColors.Control;
            _search_label.Location = new Point(308, 24);
            _search_label.Name = "_search_label";
            _search_label.Size = new Size(302, 40);
            _search_label.TabIndex = 2;
            _search_label.Text = "Search for a Book Tab";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Chocolate;
            panel2.Controls.Add(_searchtextBox);
            panel2.Controls.Add(dataGridView);
            panel2.Controls.Add(_Search);
            panel2.Location = new Point(0, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(951, 485);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // _searchtextBox
            // 
            _searchtextBox.Location = new Point(341, 351);
            _searchtextBox.Name = "_searchtextBox";
            _searchtextBox.Size = new Size(125, 27);
            _searchtextBox.TabIndex = 5;
            _searchtextBox.TextChanged += _searchtextBox_TextChanged;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BackgroundColor = Color.SeaShell;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(87, 28);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(755, 276);
            dataGridView.TabIndex = 3;
            dataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // _Search
            // 
            _Search.FlatStyle = FlatStyle.Popup;
            _Search.ForeColor = SystemColors.Control;
            _Search.Location = new Point(506, 351);
            _Search.Name = "_Search";
            _Search.Size = new Size(94, 29);
            _Search.TabIndex = 4;
            _Search.Text = "Search";
            _Search.UseVisualStyleBackColor = true;
            _Search.Click += _Search_Click;
            // 
            // searchBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 569);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "searchBooks";
            Text = "Search for a Book";
            Load += searchBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label _search_label;
        private DataGridView dataGridView;
        private Button _Search;
        private TextBox _searchtextBox;
    }
}