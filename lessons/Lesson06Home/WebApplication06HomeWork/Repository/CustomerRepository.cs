using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication06HomeWork.Models;

namespace WebApplication06HomeWork.Repository
{
    public class CustomerRepository : IRepository<Customer, int>
    {
        private static List<Customer> _customers = new List<Customer>();
        public void Devete(Customer data)
        {
            _customers.Remove(data);
        }

        public IEnumerable<Customer> FindAll()
        {
            return _customers;
        }

        public Customer FindById(int id)
        {
             return  _customers.FirstOrDefault(s => s.Id == id);
        }

        public void Save(Customer data)
        {
            _customers.Add(data);
        }
    }
}