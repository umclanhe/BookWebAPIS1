using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookWebAPISample.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
    }
}