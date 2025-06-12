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
    public partial class deleteCustomer : Form
    {
        private readonly LibraryContext _context;
        public deleteCustomer()
        {
            InitializeComponent();
            _context = new LibraryContext();
            this.Load += DeleteCustomerForm_Load;
        }

        private void DeleteCustomerForm_Load(object sender, EventArgs e)
        {
            var names = _context.Customers.Select(c => c.Name).ToList();

            deletecomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            deletecomboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(names.ToArray());

            deletecomboBox.AutoCompleteCustomSource = collection;
            deletecomboBox.DataSource = names;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            string selectedName = deletecomboBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(selectedName))
            {
                MessageBox.Show("Please select a customer name to delete.");
                return;
            }

            var customer = _context.Customers
                .Include(c => c.LibraryCard)
                .FirstOrDefault(c => c.Name == selectedName);

            if (customer == null)
            {
                MessageBox.Show("Customer not found.");
                return;
            }

            try
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
                MessageBox.Show("Customer deleted successfully!");

                DeleteCustomerForm_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        

        private void deletecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
