using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF01.Models
{
    internal class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string ISBN { get; set; }

        public decimal Price { get; set; }

        public int Pages { get; set; }
        public int PublishYear { get; set; }

        public bool IsInStock { get; set; }

        // Foreign Keys
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }

        // Navigation Properties
        public Author Author { get; set; }
        public Category Category { get; set; }
    }
}
