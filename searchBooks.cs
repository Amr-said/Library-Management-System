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
    public partial class searchBooks : Form
    {
        private readonly LibraryContext _context;
        public searchBooks()
        {
            InitializeComponent();
            _context = new LibraryContext();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _Search_Click(object sender, EventArgs e)
        {
            string title = _searchtextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a book title to search.");
                return;
            }

            var books = _context.Books
                .Include(b => b.Authors)
                .Where(b => b.Title.Contains(title))
                .Select(b => new
                {
                    b.Id,
                    b.Title,
                    b.PublishYear,
                    b.ISBN,
                    b.IsAvailable,
                    Authors = string.Join(", ", b.Authors.Select(a => a.Name))
                })
                .ToList();

            if (books.Any())
            {
                dataGridView.DataSource = books;
            }
            else
            {
                MessageBox.Show("No books found with that title.");
                dataGridView.DataSource = null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void _searchtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBooks_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
