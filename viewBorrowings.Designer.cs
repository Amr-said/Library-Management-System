namespace Project
{
    partial class viewBorrowings
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
            viewlabel = new Label();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            viewbutton = new Button();
            generatereportbutton = new Button();
            headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // headerpanel
            // 
            headerpanel.BackColor = Color.Sienna;
            headerpanel.Controls.Add(viewlabel);
            headerpanel.Controls.Add(panel2);
            headerpanel.ForeColor = SystemColors.Control;
            headerpanel.Location = new Point(0, 0);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(952, 83);
            headerpanel.TabIndex = 0;
            // 
            // viewlabel
            // 
            viewlabel.AutoSize = true;
            viewlabel.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewlabel.Location = new Point(380, 25);
            viewlabel.Name = "viewlabel";
            viewlabel.Size = new Size(154, 40);
            viewlabel.TabIndex = 2;
            viewlabel.Text = "View Data ";
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 494);
            panel2.TabIndex = 1;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BackgroundColor = Color.SeaShell;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(89, 119);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(755, 276);
            dataGridView.TabIndex = 1;
            // 
            // viewbutton
            // 
            viewbutton.FlatStyle = FlatStyle.Popup;
            viewbutton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewbutton.ForeColor = SystemColors.Control;
            viewbutton.Location = new Point(311, 436);
            viewbutton.Name = "viewbutton";
            viewbutton.Size = new Size(94, 29);
            viewbutton.TabIndex = 2;
            viewbutton.Text = "View Data";
            viewbutton.UseVisualStyleBackColor = true;
            viewbutton.Click += viewbutton_Click;
            // 
            // generatereportbutton
            // 
            generatereportbutton.FlatStyle = FlatStyle.Popup;
            generatereportbutton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generatereportbutton.ForeColor = SystemColors.Control;
            generatereportbutton.Location = new Point(463, 436);
            generatereportbutton.Name = "generatereportbutton";
            generatereportbutton.Size = new Size(179, 29);
            generatereportbutton.TabIndex = 3;
            generatereportbutton.Text = "Generate Excel File";
            generatereportbutton.UseVisualStyleBackColor = true;
            generatereportbutton.Click += generatereportbutton_Click;
            // 
            // viewBorrowings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(952, 569);
            Controls.Add(generatereportbutton);
            Controls.Add(viewbutton);
            Controls.Add(dataGridView);
            Controls.Add(headerpanel);
            Name = "viewBorrowings";
            Text = "View Borrowings";
            headerpanel.ResumeLayout(false);
            headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerpanel;
        private Panel panel2;
        private DataGridView dataGridView;
        private Label viewlabel;
        private Button viewbutton;
        private Button generatereportbutton;
    }
}