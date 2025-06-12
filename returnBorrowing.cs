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
    public partial class returnBorrowing : Form
    {
        private readonly LibraryContext _context;
        public returnBorrowing()
        {
            InitializeComponent();
            _context = new LibraryContext();
            this.Load += returnBorrowing_Load;
        }

        private void returnBorrowing_Load(object sender, EventArgs e)
        {
        
            var borrowings = _context.Borrowings
                .Include(b => b.Book)
                .Include(b => b.Customer)
                .Where(b => b.ActualReturnDate == null)
                .Select(b => $"{b.Book.Title} - {b.Customer.Name} (ID: {b.Id})")
                .ToList();

            returnComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            returnComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(borrowings.ToArray());

            returnComboBox.AutoCompleteCustomSource = collection;
            returnComboBox.DataSource = borrowings;

            actualReturnDatePicker.Value = DateTime.Now;
        }


        private void button_Click(object sender, EventArgs e)
        {
            string selectedBorrowing = returnComboBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(selectedBorrowing))
            {
                MessageBox.Show("Please select a borrowing to return.");
                return;
            }

            int borrowingId = int.Parse(selectedBorrowing.Substring(selectedBorrowing.LastIndexOf("ID: ") + 4).TrimEnd(')'));

            var borrowing = _context.Borrowings
                .Include(b => b.Book)
                .FirstOrDefault(b => b.Id == borrowingId && b.ActualReturnDate == null);

            if (borrowing == null)
            {
                MessageBox.Show("Borrowing not found or already returned.");
                return;
            }

            try
            {
                borrowing.ActualReturnDate = actualReturnDatePicker.Value;
                borrowing.Book.IsAvailable = true;

                _context.SaveChanges();
                MessageBox.Show("Book returned successfully!");
                returnBorrowing_Load(null, null); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
