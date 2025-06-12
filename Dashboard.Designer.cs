namespace Project
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            searchForABookToolStripMenuItem = new ToolStripMenuItem();
            addABookToolStripMenuItem = new ToolStripMenuItem();
            deleteABookToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            viewCustomersToolStripMenuItem = new ToolStripMenuItem();
            searchForACustomerToolStripMenuItem = new ToolStripMenuItem();
            addACustomerToolStripMenuItem = new ToolStripMenuItem();
            deleteACustomerToolStripMenuItem = new ToolStripMenuItem();
            borrowABookToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            returnABorrowingToolStripMenuItem = new ToolStripMenuItem();
            viewBorrowongsToolStripMenuItem = new ToolStripMenuItem();
            returnABookToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Sienna;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, customersToolStripMenuItem, borrowABookToolStripMenuItem, returnABookToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1220, 48);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewBooksToolStripMenuItem, searchForABookToolStripMenuItem, addABookToolStripMenuItem, deleteABookToolStripMenuItem });
            booksToolStripMenuItem.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            booksToolStripMenuItem.ForeColor = SystemColors.Control;
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(130, 44);
            booksToolStripMenuItem.Text = "Books";
            booksToolStripMenuItem.Click += booksToolStripMenuItem_Click;
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.Image = (Image)resources.GetObject("viewBooksToolStripMenuItem.Image");
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(412, 44);
            viewBooksToolStripMenuItem.Text = "View and Update Books";
            viewBooksToolStripMenuItem.Click += viewBooksToolStripMenuItem_Click;
            // 
            // searchForABookToolStripMenuItem
            // 
            searchForABookToolStripMenuItem.Image = (Image)resources.GetObject("searchForABookToolStripMenuItem.Image");
            searchForABookToolStripMenuItem.Name = "searchForABookToolStripMenuItem";
            searchForABookToolStripMenuItem.Size = new Size(412, 44);
            searchForABookToolStripMenuItem.Text = "Search for a Book ";
            searchForABookToolStripMenuItem.Click += searchForABookToolStripMenuItem_Click;
            // 
            // addABookToolStripMenuItem
            // 
            addABookToolStripMenuItem.Image = (Image)resources.GetObject("addABookToolStripMenuItem.Image");
            addABookToolStripMenuItem.Name = "addABookToolStripMenuItem";
            addABookToolStripMenuItem.Size = new Size(412, 44);
            addABookToolStripMenuItem.Text = "Add a Book ";
            addABookToolStripMenuItem.Click += addABookToolStripMenuItem_Click;
            // 
            // deleteABookToolStripMenuItem
            // 
            deleteABookToolStripMenuItem.Image = (Image)resources.GetObject("deleteABookToolStripMenuItem.Image");
            deleteABookToolStripMenuItem.Name = "deleteABookToolStripMenuItem";
            deleteABookToolStripMenuItem.Size = new Size(412, 44);
            deleteABookToolStripMenuItem.Text = "Delete a Book";
            deleteABookToolStripMenuItem.Click += deleteABookToolStripMenuItem_Click;
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.BackColor = Color.Chocolate;
            customersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewCustomersToolStripMenuItem, searchForACustomerToolStripMenuItem, addACustomerToolStripMenuItem, deleteACustomerToolStripMenuItem });
            customersToolStripMenuItem.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customersToolStripMenuItem.ForeColor = SystemColors.Control;
            customersToolStripMenuItem.Image = (Image)resources.GetObject("customersToolStripMenuItem.Image");
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(187, 44);
            customersToolStripMenuItem.Text = "Customers";
            // 
            // viewCustomersToolStripMenuItem
            // 
            viewCustomersToolStripMenuItem.Image = (Image)resources.GetObject("viewCustomersToolStripMenuItem.Image");
            viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
            viewCustomersToolStripMenuItem.Size = new Size(469, 44);
            viewCustomersToolStripMenuItem.Text = "View and Update Customers";
            viewCustomersToolStripMenuItem.Click += viewCustomersToolStripMenuItem_Click;
            // 
            // searchForACustomerToolStripMenuItem
            // 
            searchForACustomerToolStripMenuItem.Image = (Image)resources.GetObject("searchForACustomerToolStripMenuItem.Image");
            searchForACustomerToolStripMenuItem.Name = "searchForACustomerToolStripMenuItem";
            searchForACustomerToolStripMenuItem.Size = new Size(469, 44);
            searchForACustomerToolStripMenuItem.Text = "Search for a Customer";
            searchForACustomerToolStripMenuItem.Click += searchForACustomerToolStripMenuItem_Click;
            // 
            // addACustomerToolStripMenuItem
            // 
            addACustomerToolStripMenuItem.Image = (Image)resources.GetObject("addACustomerToolStripMenuItem.Image");
            addACustomerToolStripMenuItem.Name = "addACustomerToolStripMenuItem";
            addACustomerToolStripMenuItem.Size = new Size(469, 44);
            addACustomerToolStripMenuItem.Text = "Add a Customer ";
            addACustomerToolStripMenuItem.Click += addACustomerToolStripMenuItem_Click;
            // 
            // deleteACustomerToolStripMenuItem
            // 
            deleteACustomerToolStripMenuItem.Image = (Image)resources.GetObject("deleteACustomerToolStripMenuItem.Image");
            deleteACustomerToolStripMenuItem.Name = "deleteACustomerToolStripMenuItem";
            deleteACustomerToolStripMenuItem.Size = new Size(469, 44);
            deleteACustomerToolStripMenuItem.Text = "Delete a Customer";
            deleteACustomerToolStripMenuItem.Click += deleteACustomerToolStripMenuItem_Click;
            // 
            // borrowABookToolStripMenuItem
            // 
            borrowABookToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, returnABorrowingToolStripMenuItem, viewBorrowongsToolStripMenuItem });
            borrowABookToolStripMenuItem.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            borrowABookToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            borrowABookToolStripMenuItem.Image = (Image)resources.GetObject("borrowABookToolStripMenuItem.Image");
            borrowABookToolStripMenuItem.Name = "borrowABookToolStripMenuItem";
            borrowABookToolStripMenuItem.Size = new Size(237, 44);
            borrowABookToolStripMenuItem.Text = "Borrow a Book";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Image = (Image)resources.GetObject("addToolStripMenuItem.Image");
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(318, 44);
            addToolStripMenuItem.Text = "Add a Borrowing";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // returnABorrowingToolStripMenuItem
            // 
            returnABorrowingToolStripMenuItem.Image = (Image)resources.GetObject("returnABorrowingToolStripMenuItem.Image");
            returnABorrowingToolStripMenuItem.Name = "returnABorrowingToolStripMenuItem";
            returnABorrowingToolStripMenuItem.Size = new Size(318, 44);
            returnABorrowingToolStripMenuItem.Text = "Return a Book";
            returnABorrowingToolStripMenuItem.Click += returnABorrowingToolStripMenuItem_Click;
            // 
            // viewBorrowongsToolStripMenuItem
            // 
            viewBorrowongsToolStripMenuItem.Image = (Image)resources.GetObject("viewBorrowongsToolStripMenuItem.Image");
            viewBorrowongsToolStripMenuItem.Name = "viewBorrowongsToolStripMenuItem";
            viewBorrowongsToolStripMenuItem.Size = new Size(318, 44);
            viewBorrowongsToolStripMenuItem.Text = "View Borrowings";
            viewBorrowongsToolStripMenuItem.Click += viewBorrowongsToolStripMenuItem_Click;
            // 
            // returnABookToolStripMenuItem
            // 
            returnABookToolStripMenuItem.BackColor = Color.Chocolate;
            returnABookToolStripMenuItem.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            returnABookToolStripMenuItem.ForeColor = SystemColors.Control;
            returnABookToolStripMenuItem.Image = (Image)resources.GetObject("returnABookToolStripMenuItem.Image");
            returnABookToolStripMenuItem.Name = "returnABookToolStripMenuItem";
            returnABookToolStripMenuItem.Size = new Size(164, 44);
            returnABookToolStripMenuItem.Text = "Statistics";
            returnABookToolStripMenuItem.Click += returnABookToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitToolStripMenuItem.ForeColor = SystemColors.Control;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(78, 44);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1220, 706);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem borrowABookToolStripMenuItem;
        private ToolStripMenuItem returnABookToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem searchForABookToolStripMenuItem;
        private ToolStripMenuItem addABookToolStripMenuItem;
        private ToolStripMenuItem deleteABookToolStripMenuItem;
        private ToolStripMenuItem viewCustomersToolStripMenuItem;
        private ToolStripMenuItem searchForACustomerToolStripMenuItem;
        private ToolStripMenuItem addACustomerToolStripMenuItem;
        private ToolStripMenuItem deleteACustomerToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem returnABorrowingToolStripMenuItem;
        private ToolStripMenuItem viewBorrowongsToolStripMenuItem;
    }
}