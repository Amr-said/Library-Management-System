using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project
{
    public partial class StatisticsForm : Form
    {
        private readonly LibraryContext _context;

        public StatisticsForm()
        {
            InitializeComponent();
            _context = new LibraryContext();

        }
        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            var topBooks = _context.Borrowings
                .GroupBy(b => b.Book.Title)
                .Select(g => new
                {
                    Title = g.Key,
                    Count = g.Count()
                })
                .OrderByDescending(x => x.Count)
                .Take(5)
                .ToList();

     
            piechart.Series.Clear();
            piechart.Titles.Clear();

            piechart.Titles.Add("Top 5 Borrowed Books");
            piechart.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);

            Series series = new Series
            {
                Name = "Books",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie,
                Font = new Font("Arial", 12, FontStyle.Bold), 
                LabelForeColor = Color.White 
            };

            foreach (var book in topBooks)
            {
                var point = series.Points.AddXY(book.Title, book.Count);

            }

            piechart.Series.Add(series);
        }

        private void piechart_Click(object sender, EventArgs e)
        {
        }
    }
}
