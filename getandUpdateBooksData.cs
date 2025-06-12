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
    public partial class getandUpdateBooksData : Form
    {
        private readonly LibraryContext _context;

        private int selectedBookId = -1;

        public getandUpdateBooksData()
        {
            InitializeComponent();
            _context = new LibraryContext();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
            var booksWithAuthors = _context.Books
                .Include(b => b.Authors)
                .Select(b => new
                {
                    b.Id,
                    b.Title,
                    b.ISBN,
                    b.PublishYear,
                    b.IsAvailable,
                    AuthorNames = string.Join(", ", b.Authors.Select(a => $"{a.Name} (ID:{a.Id})"))
                })
                .ToList();

            dataGridView.DataSource = booksWithAuthors;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void titletextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void isbntextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yeartextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void authortextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void availabilitycheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void _updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedBookId == -1)
                {
                    MessageBox.Show("Please select a row to update.");
                    return;
                }

                var book = _context.Books.Include(b => b.Authors).FirstOrDefault(b => b.Id == selectedBookId);

                if (book != null)
                {
                    book.Title = titletextBox.Text;
                    book.ISBN = isbntextBox.Text;
                    book.PublishYear = int.Parse(yeartextBox.Text);
                    book.IsAvailable = availabilitycheckBox.Checked;


                    _context.SaveChanges();

                    MessageBox.Show("Book updated successfully.");


                    var booksWithAuthors = _context.Books
                        .Include(b => b.Authors)
                        .Select(b => new
                        {
                            b.Id,
                            b.Title,
                            b.ISBN,
                            b.PublishYear,
                            b.IsAvailable,
                            AuthorNames = string.Join(", ", b.Authors.Select(a => $"{a.Name} (ID:{a.Id})"))
                        })
                        .ToList();

                    dataGridView.DataSource = booksWithAuthors;
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView.Rows[e.RowIndex];


                    selectedBookId = Convert.ToInt32(row.Cells["Id"].Value);

                    titletextBox.Text = row.Cells["Title"].Value.ToString();
                    isbntextBox.Text = row.Cells["ISBN"].Value.ToString();
                    yeartextBox.Text = row.Cells["PublishYear"].Value.ToString();
                    authortextBox.Text = row.Cells["AuthorNames"].Value.ToString();

                    bool isAvailable = Convert.ToBoolean(row.Cells["IsAvailable"].Value);
                    availabilitycheckBox.Checked = isAvailable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void getandUpdateBooksData_Load(object sender, EventArgs e)
        {

        }
    }
}
