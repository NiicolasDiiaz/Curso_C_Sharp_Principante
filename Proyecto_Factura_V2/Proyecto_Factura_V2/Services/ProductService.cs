using Microsoft.EntityFrameworkCore;
using Proyecto_Factura_V2.Context;
using Proyecto_Factura_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V2.Services
{
    public class ProductService : IProductService
    {
        private readonly IDDBBContext _contextoDB;

        public ProductService(IDDBBContext contextoDB)
        {
            _contextoDB = contextoDB;
        }

        public void AddProduct(Product product)
        {
            _contextoDB.Products.Add(product);
            _contextoDB.SaveChanges();
        }

        public Product GetProduct(int ProductId)
        {
            //Base function:
            return _contextoDB.Products.Find(ProductId);

            //Lambda expresion:
            //return _contextoDB.Products.Include(x => x.Branch).Where(x => x.ProductId == ProductId).FirstOrDefault();
        }
        public List<Product> GetProducts()
        {
            return _contextoDB.Products.Select(x => x).ToList();
        }

        public void DeleteProduct(Product product)
        {
            _contextoDB.Products.Remove(product);
            _contextoDB.SaveChanges();
        }
        public void DeleteProduct(int ProductId)
        {
            var product = GetProduct(ProductId);
            DeleteProduct(product);
        }

        public Product UpdateProduct(Product product)
        {
            var productUpdated = _contextoDB.Products.Update(product).Entity;
            _contextoDB.SaveChanges();
            return productUpdated;
        }
    }
}
