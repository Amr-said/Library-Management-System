using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Models;

namespace Project
{
    public partial class addCustomer : Form
    {
        private readonly LibraryContext _context;
        public addCustomer()
        {
            InitializeComponent();
            _context = new LibraryContext();
        }

        private void headerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addCustButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(nametextBox.Text) ||
                    string.IsNullOrWhiteSpace(cardtextBox.Text))
                {
                    MessageBox.Show("Please fill in all required fields (Name and Card Number).");
                    return;
                }


                var customer = new Customer
                {
                    Name = nametextBox.Text.Trim(),
                    Phone = phonetextBox.Text.Trim(),
                    Street = streettextBox.Text.Trim(),
                    City = citytextBox.Text.Trim(),
                    PostalCode = pctextBox.Text.Trim()
                };


                var libraryCard = new LibraryCard
                {
                    CardNumber = cardtextBox.Text.Trim(),
                    IssueDate = issuedateTimePicker.Value,
                    ExpiryDate = expiraydateTimePicker.Value,
                    Customer = customer
                };

                customer.LibraryCard = libraryCard;


                _context.Customers.Add(customer);
                _context.SaveChanges();

                MessageBox.Show("Customer added successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            nametextBox.Clear();
            phonetextBox.Clear();
            streettextBox.Clear();
            citytextBox.Clear();
            pctextBox.Clear();
            cardtextBox.Clear();
            issuedateTimePicker.Value = DateTime.Now;
            expiraydateTimePicker.Value = DateTime.Now.AddYears(1);
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

            issuedateTimePicker.Value = DateTime.Now;
            expiraydateTimePicker.Value = DateTime.Now.AddYears(1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCustomer_Load(object sender, EventArgs e)
        {

        }

        private void expiraylabel_Click(object sender, EventArgs e)
        {

        }
    }
}
