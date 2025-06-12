using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int PublishYear { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }

        public virtual List<Borrowing> Borrowings { get; set; }
        public virtual List<Author> Authors { get; set; }
    }
}
