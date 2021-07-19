using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto_Factura_V2.Models;
using Proyecto_Factura_V2.RequestModels;
using Proyecto_Factura_V2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V2.Controllers
{
    [ApiController]
    //¡¡¡¡¡¡¡¿Como queda la ruta?!!!!!
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductService _productService;
        private readonly IBranchService _branchService;

        public ProductsController(IProductService productService, IBranchService branchService, ILogger<ProductsController> logger)
        {
            _productService = productService;
            _branchService = branchService;
            _logger = logger;
        }

        /// <summary>
        /// Get products from de database
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("{id}")]
        public void Get(int id)
        {
            var product = _productService.GetProduct(id);
        }

        /// <summary>
        /// Insert new products
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// {
        ///     "Name" : "Sedal",
        ///     "Description" : "Product for hair",
        ///     "Manufacturer" : "P&G",
        ///     "Price" : 16000,
        ///     "BranchId" : 1
        /// }
        /// </remarks>
        [HttpPost]
        public void Post([FromBody]ProductRequest request)
        {
            _branchService.AddBranch(new Branch
            {
                Name = "Engativa branch",
                Description = "Branch located in Engativa"
            });

            _productService.AddProduct(new Product
            {
                Name = "Sedal",
                Description = "Product for hair",
                Manufacturer = "P&G",
                Price = 16000,
                DateOfEntry = DateTime.Now,
                BranchId = 1
            });
        }

        /// <summary>
        /// Update product records
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// {
        ///     "Name" : "Sedal",
        ///     "Description" : "Product for hair",
        ///     "Manufacturer" : "P&G",
        ///     "Price" : 16000,
        ///     "BranchId" : 1
        /// }
        /// </remarks>
        /// <param name="id"></param>
        [HttpPut("{id}")]
        public void Put(int id)
        {
            var product = _productService.GetProduct(id);
            product.Description = "Description changed!";
            _productService.UpdateProduct(product);
        }

        /// <summary>
        /// Delete product records
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.DeleteProduct(id);
        }

    }
}
