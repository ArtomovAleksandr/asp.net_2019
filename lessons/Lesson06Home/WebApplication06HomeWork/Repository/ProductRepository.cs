using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication06HomeWork.Models;

namespace WebApplication06HomeWork.Repository
{
    public class ProductRepository : IRepository<Product, int>
    {
        private static List<Product> _products = new List<Product>();
        public void Devete(Product data)
        {
            _products.Remove(data);
        }

        public IEnumerable<Product> FindAll()
        {
            return _products;
        }

        public Product FindById(int id)
        {
           return _products.FirstOrDefault(s => s.Id == id);
        }

        public void Save(Product data)
        {
            _products.Add(data);
        }
    }
}