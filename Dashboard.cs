using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void addABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBook addbook = new addBook();
            addbook.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getandUpdateBooksData getdata = new getandUpdateBooksData();
            getdata.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void searchForABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchBooks search = new searchBooks();
            search.Show();
        }

        private void deleteABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteBooks delete = new deleteBooks();
            delete.Show();

        }

        private void addACustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCustomer Customer = new addCustomer();
            Customer.Show();
        }

        private void deleteACustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteCustomer dCustomer = new deleteCustomer();
            dCustomer.Show();
        }

        private void searchForACustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchCustomer searchcust = new searchCustomer();
            searchcust.Show();
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getandUpdateCustomersData getCustomdate = new getandUpdateCustomersData();
            getCustomdate.Show();
        }

        private void returnABorrowingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnBorrowing returnb = new returnBorrowing();
            returnb.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBorrowing borrowing = new addBorrowing();
            borrowing.Show();
        }

        private void returnABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Statistics stats = new Statistics();
            //stats.Show();
            StatisticsForm stat = new StatisticsForm();
            stat.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewBorrowongsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBorrowings view = new viewBorrowings();
            view.Show();
        }
    }
}
