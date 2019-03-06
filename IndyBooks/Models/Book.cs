﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace IndyBooks.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SKU { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        //TODO: Add Navigtion Property according to ERD Diagram

        public Writer Author { get; set; }
    }
}
