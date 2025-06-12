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
    public partial class deleteBooks : Form
    {
        private readonly LibraryContext _context;
        public deleteBooks()
        {
            InitializeComponent();
            _context = new LibraryContext();
            //deleteComboBox.TextChanged += deleteComboBox_TextChanged;
            //deleteComboBox.TextChanged += deleteComboBox_SelectedIndexChanged;
            this.Load += deleteBooks_Load;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            string selectedTitle = deleteComboBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(selectedTitle))
            {
                MessageBox.Show("Please select a book title to delete.");
                return;
            }

            var book = _context.Books
                .Include(b => b.Authors)
                .FirstOrDefault(b => b.Title == selectedTitle);

            if (book == null)
            {
                MessageBox.Show("Book not found.");
                return;
            }

            _context.Books.Remove(book);
            _context.SaveChanges();
            MessageBox.Show("Book deleted successfully!");
        }

        private void deleteBooks_Load(object sender, EventArgs e)
        {
            var titles = _context.Books.Select(b => b.Title).ToList();

            deleteComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            deleteComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(titles.ToArray());

            deleteComboBox.AutoCompleteCustomSource = collection;

            deleteComboBox.DataSource = titles;
        }

        private void deleteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string input = deleteComboBox.Text.Trim();

            //if (input.Length >= 3)
            //{
            //    var matchedTitles = _context.Books
            //        .Where(b => b.Title.Contains(input))
            //        .Select(b => b.Title)
            //        .ToList();

            //    var autoCompleteCollection = new AutoCompleteStringCollection();
            //    autoCompleteCollection.AddRange(matchedTitles.ToArray());

            //    deleteComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //    deleteComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //    deleteComboBox.AutoCompleteCustomSource = autoCompleteCollection;
            //}
        }

        private void deleteBooks_Load_1(object sender, EventArgs e)
        {

        }
        //private void deleteComboBox_TextChanged(object sender, EventArgs e)
        //{
        //    string input = deleteComboBox.Text.Trim();

        //    if (input.Length >= 3)
        //    {
        //        var matchedTitles = _context.Books
        //            .Where(b => b.Title.Contains(input))
        //            .Select(b => b.Title)
        //            .ToList();

        //        var autoCompleteCollection = new AutoCompleteStringCollection();
        //        autoCompleteCollection.AddRange(matchedTitles.ToArray());

        //        deleteComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //        deleteComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //        deleteComboBox.AutoCompleteCustomSource = autoCompleteCollection;
        //    }
        //}
    }
}
