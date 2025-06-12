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
    public partial class getandUpdateCustomersData : Form
    {
        private readonly LibraryContext _context;
        private int selectedCustomerId = -1;
        public getandUpdateCustomersData()
        {
            InitializeComponent();
            _context = new LibraryContext();
        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            var customers = _context.Customers
                .Include(c => c.LibraryCard)
                .Select(c => new
                {
                    c.Id,
                    c.Name,
                    c.Phone,
                    c.Street,
                    c.City,
                    c.PostalCode,
                    CardNumber = c.LibraryCard.CardNumber,
                    IssueDate = c.LibraryCard.IssueDate,
                    ExpiryDate = c.LibraryCard.ExpiryDate
                })
                .ToList();

            dataGridView.DataSource = customers;

            dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView.DefaultCellStyle.BackColor = Color.White;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCustomerId == -1)
                {
                    MessageBox.Show("Please select a customer to update.");
                    return;
                }

                var customer = _context.Customers
                    .Include(c => c.LibraryCard)
                    .FirstOrDefault(c => c.Id == selectedCustomerId);

                if (customer != null)
                {
                    customer.Name = nameTextBox.Text.Trim();
                    customer.Phone = phoneTextBox.Text.Trim();
                    customer.Street = streetTextBox.Text.Trim();
                    customer.City = cityTextBox.Text.Trim();
                    customer.PostalCode = postalCodeTextBox.Text.Trim();
                    customer.LibraryCard.CardNumber = cardNumberTextBox.Text.Trim();
                    customer.LibraryCard.IssueDate = issueDatePicker.Value;
                    customer.LibraryCard.ExpiryDate = expiryDatePicker.Value;

                    _context.SaveChanges();
                    MessageBox.Show("Customer updated successfully!");
                    viewbutton_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                    selectedCustomerId = Convert.ToInt32(row.Cells["Id"].Value);

                    nameTextBox.Text = row.Cells["Name"].Value?.ToString();
                    phoneTextBox.Text = row.Cells["Phone"].Value?.ToString();
                    streetTextBox.Text = row.Cells["Street"].Value?.ToString();
                    cityTextBox.Text = row.Cells["City"].Value?.ToString();
                    postalCodeTextBox.Text = row.Cells["PostalCode"].Value?.ToString();
                    cardNumberTextBox.Text = row.Cells["CardNumber"].Value?.ToString();
                    issueDatePicker.Value = Convert.ToDateTime(row.Cells["IssueDate"].Value);
                    expiryDatePicker.Value = Convert.ToDateTime(row.Cells["ExpiryDate"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void GetAndUpdateCustomersForm_Load(object sender, EventArgs e)
        {
            issueDatePicker.Value = DateTime.Now;
            expiryDatePicker.Value = DateTime.Now.AddYears(1);
        }

        private void expiryDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
