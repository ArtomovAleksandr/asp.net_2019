using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication06HomeWork.Models
{
    public class Product
    {
        private static int count;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Product()
        {
            Id = ++count;
        }
    }
}