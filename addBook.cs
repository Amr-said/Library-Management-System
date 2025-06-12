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
    public partial class addBook : Form
    {
        private readonly LibraryContext _context;
        public addBook()
        {
            InitializeComponent();
            _context = new LibraryContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string authorName = textBox3.Text.Trim();

            if (string.IsNullOrWhiteSpace(authorName))
            {
                MessageBox.Show("Please enter author name.");
                return;
            }

    
            var author = _context.Authors
                .FirstOrDefault(a => a.Name.Trim().ToLower() == authorName.ToLower());

            
            if (author == null)
            {
                author = new Author { Name = authorName };
                _context.Authors.Add(author);
                _context.SaveChanges(); 
            }

            try
            {
                var book = new Book
                {
                    Title = textBox2.Text.Trim(),
                    ISBN = textBox5.Text.Trim(),
                    PublishYear = int.Parse(textBox4.Text),
                    IsAvailable = check.Checked,
                    Authors = new List<Author>()
                };

                book.Authors.Add(author);

                _context.Books.Add(book);
                _context.SaveChanges();

                MessageBox.Show("Book added successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            //LoadBooks(); // method to refresh DataGridView
        }


    }
}
