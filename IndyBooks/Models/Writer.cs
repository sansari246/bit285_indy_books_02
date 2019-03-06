using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IndyBooks.Models
{
    public class Writer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}