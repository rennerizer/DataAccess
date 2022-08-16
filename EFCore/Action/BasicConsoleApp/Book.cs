﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
