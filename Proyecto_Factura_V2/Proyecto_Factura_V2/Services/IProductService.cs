using Proyecto_Factura_V2.Context;
using Proyecto_Factura_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V2.Services
{
    public interface IProductService
    {
        void AddProduct(Product product);

        Product GetProduct(int ProductId);
        List<Product> GetProducts();

        void DeleteProduct(Product product);
        void DeleteProduct(int ProductId);

        Product UpdateProduct(Product product);
    }
}
