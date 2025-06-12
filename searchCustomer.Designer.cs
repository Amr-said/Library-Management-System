namespace Project
{
    partial class searchCustomer
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
            headerlabel = new Label();
            bodypanel = new Panel();
            searchtextBox = new TextBox();
            searchcustbutton = new Button();
            dataGridView = new DataGridView();
            headerpanel.SuspendLayout();
            bodypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // headerpanel
            // 
            headerpanel.BackColor = Color.Sienna;
            headerpanel.Controls.Add(headerlabel);
            headerpanel.Location = new Point(0, 0);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(951, 83);
            headerpanel.TabIndex = 0;
            headerpanel.Paint += headerpanel_Paint;
            // 
            // headerlabel
            // 
            headerlabel.AutoSize = true;
            headerlabel.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerlabel.ForeColor = SystemColors.Control;
            headerlabel.Location = new Point(290, 23);
            headerlabel.Name = "headerlabel";
            headerlabel.Size = new Size(359, 40);
            headerlabel.TabIndex = 0;
            headerlabel.Text = "Search for a Customer Tab";
            // 
            // bodypanel
            // 
            bodypanel.BackColor = Color.Chocolate;
            bodypanel.Controls.Add(searchtextBox);
            bodypanel.Controls.Add(searchcustbutton);
            bodypanel.Controls.Add(dataGridView);
            bodypanel.Location = new Point(0, 83);
            bodypanel.Name = "bodypanel";
            bodypanel.Size = new Size(951, 484);
            bodypanel.TabIndex = 1;
            // 
            // searchtextBox
            // 
            searchtextBox.Location = new Point(341, 351);
            searchtextBox.Name = "searchtextBox";
            searchtextBox.Size = new Size(125, 27);
            searchtextBox.TabIndex = 2;
            searchtextBox.TextChanged += searchtextBox_TextChanged;
            // 
            // searchcustbutton
            // 
            searchcustbutton.FlatStyle = FlatStyle.Popup;
            searchcustbutton.ForeColor = SystemColors.Control;
            searchcustbutton.Location = new Point(506, 351);
            searchcustbutton.Name = "searchcustbutton";
            searchcustbutton.Size = new Size(94, 29);
            searchcustbutton.TabIndex = 1;
            searchcustbutton.Text = "Search";
            searchcustbutton.UseVisualStyleBackColor = true;
            searchcustbutton.Click += searchcustbutton_Click;
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
            dataGridView.TabIndex = 0;
            // 
            // searchCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 569);
            Controls.Add(bodypanel);
            Controls.Add(headerpanel);
            Name = "searchCustomer";
            Text = "search for a Customer";
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
        private TextBox searchtextBox;
        private Button searchcustbutton;
        private DataGridView dataGridView;
        private Label headerlabel;
    }
}