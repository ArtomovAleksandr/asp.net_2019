using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication06HomeWork.Models
{
    public class Customer
    {
        private static int count;
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Customer()
        {
            Id = ++count;
        }
    }
}