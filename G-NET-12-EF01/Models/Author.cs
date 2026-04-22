using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF01.Models
{
    internal class Author
    {
        public int Id { get; set; }   // Primary Key by convention

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Bio { get; set; }

        public DateTime DateOfBirth { get; set; }

        // Navigation Property
        public List<Book> Books { get; set; }
    }
}
