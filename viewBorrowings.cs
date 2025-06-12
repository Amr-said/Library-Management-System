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
using Microsoft.EntityFrameworkCore;
using DocumentFormat.OpenXml.InkML;

namespace Project
{
    public partial class viewBorrowings : Form
    {
        private readonly LibraryContext _context;
        public viewBorrowings()
        {
            InitializeComponent();
            _context = new LibraryContext();
        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            var borrowings = _context.Borrowings
           .Include(b => b.Book)
           .Include(b => b.Customer)
           .Select(b => new
           {
               b.Id,
               BookTitle = b.Book.Title,
               CustomerName = b.Customer.Name,
               b.BorrowDate,
               b.ExpectedReturnDate,
               b.ActualReturnDate
           })
           .ToList();

            dataGridView.DataSource = borrowings;
        }

        private void generatereportbutton_Click(object sender, EventArgs e)
        {
            try
            {
                var borrowings = _context.Borrowings
                    .Include(b => b.Book)
                    .Include(b => b.Customer)
                    //.Where(b => b.BorrowDate >= startDatePicker.Value && b.BorrowDate <= endDatePicker.Value)
                    .Select(b => new
                    {
                        b.Id,
                        BookTitle = b.Book.Title,
                        CustomerName = b.Customer.Name,
                        b.BorrowDate,
                        b.ExpectedReturnDate,
                        b.ActualReturnDate
                    })
                    .ToList();

                if (!borrowings.Any())
                {
                    MessageBox.Show("No borrowings found in the selected date range.");
                    return;
                }

                // إنشاء ملف CSV
                var csv = new System.Text.StringBuilder();
                csv.AppendLine("ID,Book Title,Customer Name,Borrow Date,Expected Return Date,Actual Return Date");
                foreach (var borrowing in borrowings)
                {
                    csv.AppendLine($"{borrowing.Id},\"{borrowing.BookTitle}\",\"{borrowing.CustomerName}\"," +
                                   $"\"{borrowing.BorrowDate:yyyy-MM-dd}\",\"{borrowing.ExpectedReturnDate:yyyy-MM-dd}\"," +
                                   $"\"{(borrowing.ActualReturnDate?.ToString("yyyy-MM-dd") ?? "Not Returned")}\"");
                }

                // حفظ الملف
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CSV Files|*.csv";
                    sfd.FileName = "BorrowingsReport.csv";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllText(sfd.FileName, csv.ToString());
                        MessageBox.Show($"CSV file saved to: {sfd.FileName}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to CSV: " + ex.Message);
            }
        }
    }
}
