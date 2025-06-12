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
    public partial class addBorrowing : Form
    {
        private readonly LibraryContext _context;
        public addBorrowing()
        {
            InitializeComponent();
            _context = new LibraryContext();
            this.Load += addBorrowing_Load;
        }

        private void addBorrowing_Load(object sender, EventArgs e)
        {

            var books = _context.Books
                .Where(b => b.IsAvailable)
                .Select(b => b.Title)
                .ToList();

            if (books.Any())
            {
                bookComboBox.DataSource = books;
                bookComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                bookComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            else
            {
                bookComboBox.DataSource = null;
                bookComboBox.Items.Add("No available books");
                bookComboBox.SelectedIndex = 0;
                bookComboBox.Enabled = false;
                MessageBox.Show("No available books found. Please add books or ensure some are available.");
            }

            
            var customers = _context.Customers
                .Select(c => c.Name)
                .ToList();

            if (customers.Any())
            {
                customerComboBox.DataSource = customers;
                customerComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                customerComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            else
            {
                customerComboBox.DataSource = null;
                customerComboBox.Items.Add("No customers");
                customerComboBox.SelectedIndex = 0;
                customerComboBox.Enabled = false;
                MessageBox.Show("No customers found. Please add customers first.");
            }

            
            borrowDatePicker.Value = DateTime.Now;
            expectedReturnDatePicker.Value = DateTime.Now.AddDays(14);
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (string.IsNullOrWhiteSpace(bookComboBox.Text) || string.IsNullOrWhiteSpace(customerComboBox.Text))
                {
                    MessageBox.Show("Please select a book and a customer.");
                    return;
                }


                var book = _context.Books
                    .FirstOrDefault(b => b.Title == bookComboBox.Text && b.IsAvailable);
                if (book == null)
                {
                    MessageBox.Show("Selected book is not available.");
                    return;
                }

             
                var customer = _context.Customers
                    .FirstOrDefault(c => c.Name == customerComboBox.Text);
                if (customer == null)
                {
                    MessageBox.Show("Selected customer not found.");
                    return;
                }

                
                var overdueBorrowings = _context.Borrowings
                    .Where(b => b.CustomerId == customer.Id && b.ActualReturnDate == null && b.ExpectedReturnDate < DateTime.Now)
                    .Any();
                if (overdueBorrowings)
                {
                    MessageBox.Show("Customer has overdue borrowings and cannot borrow new books.");
                    return;
                }

                
                var borrowing = new Borrowing
                {
                    BookId = book.Id,
                    CustomerId = customer.Id,
                    BorrowDate = borrowDatePicker.Value,
                    ExpectedReturnDate = expectedReturnDatePicker.Value,
                    ActualReturnDate = null
                };

             
                book.IsAvailable = false;

                _context.Borrowings.Add(borrowing);
                _context.SaveChanges();

                MessageBox.Show("Borrowing added successfully!");
                ClearForm();
                
                addBorrowing_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ClearForm()
        {
            bookComboBox.SelectedIndex = -1;
            customerComboBox.SelectedIndex = -1;
            borrowDatePicker.Value = DateTime.Now;
            expectedReturnDatePicker.Value = DateTime.Now.AddDays(14);
        }
    }
}
