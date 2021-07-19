using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto_Factura_V2.Models;
using Proyecto_Factura_V2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductService _productService;

        public ProductsController(IProductService productService, ILogger<ProductsController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {
            _productService.AddProduct(new Models.Product
            {
                Name="Sedal",
                Description="Product for hair",
                Manufacturer="P&G",
                Price=16000,
                DateOfEntry=DateTime.Now
            });

            var products = _productService.GetProducts();

            var product = _productService.GetProduct(1);
            product.Description = "Changed entity";
            _productService.UpdateProduct(product);

            _productService.DeleteProduct(2);
        }
    }
}
