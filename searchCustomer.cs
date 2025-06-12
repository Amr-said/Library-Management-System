using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project
{
    public partial class searchCustomer : Form
    {
        private readonly LibraryContext _context;
        public searchCustomer()
        {
            InitializeComponent();
            _context = new LibraryContext();
        }

        private void headerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchcustbutton_Click(object sender, EventArgs e)
        {
            string searchText = searchtextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a name or card number to search.");
                return;
            }

            try
            {
                var customers = _context.Customers
                    .Include(c => c.LibraryCard)
                    .Where(c => c.Name.ToLower().Contains(searchText.ToLower()) ||
                                (c.LibraryCard != null && c.LibraryCard.CardNumber.ToLower().Contains(searchText.ToLower())))
                    .Select(c => new
                    {
                        c.Id,
                        c.Name,
                        c.Phone,
                        c.Street,
                        c.City,
                        c.PostalCode,
                        CardNumber = c.LibraryCard != null ? c.LibraryCard.CardNumber : "N/A",
                        IssueDate = c.LibraryCard != null ? c.LibraryCard.IssueDate : (DateTime?)null,
                        ExpiryDate = c.LibraryCard != null ? c.LibraryCard.ExpiryDate : (DateTime?)null
                    })
                    .ToList();

                if (customers.Any())
                {
                    dataGridView.DataSource = customers;
                }
                else
                {
                    MessageBox.Show("No customers found.");
                    dataGridView.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
        }

        private void SearchCustomersForm_Load(object sender, EventArgs e)
        {

            var totalCustomers = _context.Customers.Count();
            if (totalCustomers == 0)
            {
                MessageBox.Show("Warning: No customers exist in the database.");
            }
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
