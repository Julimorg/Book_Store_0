using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Web_1.Models
{
    public class Books
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author {  get; set; }
        public int PublishYear{get; set; }  
        public double Price { get; set; }   
        public string Cover {  get; set; }

    }
}