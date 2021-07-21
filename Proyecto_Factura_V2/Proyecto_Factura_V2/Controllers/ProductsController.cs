using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto_Factura_V2.Models;
using Proyecto_Factura_V2.RequestModels;
using Proyecto_Factura_V2.Services;
using Proyecto_Factura_V2.ViewModels;
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
        public ProductViewModel Get(int id) //Deberia ser (int? id) ? Acepto null y lidio con eso
        {
            try
            {
                var product = _productService.GetProduct(id);
                var viewProduct = new ProductViewModel
                {
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    ProductId = product.ProductId
                };
                return viewProduct;
            }
            catch (Exception)
            {

                throw;
            }

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
        [ValidateAntiForgeryToken] //Potection against bots
        public IActionResult Post([FromBody]ProductRequestPost request)
        {
            //if (ModelState.IsValid() ????
            _branchService.AddBranch(new Branch
            {
                Name = "Engativa branch",
                Description = "Branch located in Engativa"
            });

            _productService.AddProduct(new Product
            {
                Name = request.Name,
                Description = request.Description,
                Manufacturer = request.Manufacturer,
                Price = request.Price,
                DateOfEntry = DateTime.Now,
                BranchId = request.BranchId
            });
            return Ok();
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
        [HttpPut]
        [ValidateAntiForgeryToken] //Potection against bots
        public IActionResult Put([FromBody] ProductRequestPut request)
        {
            var product = _productService.GetProduct(request.ProductId);
            product.Name = request.Name;
            product.Description = request.Description;
            product.Manufacturer = request.Manufacturer;
            product.Price = request.Price;
            product.BranchId = request.BranchId;
            _productService.UpdateProduct(product);
            return Ok();
        }

        /// <summary>
        /// Delete product records
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) //Deberia ser (int? id) ? Acepto null y lidio con eso
        {
            _productService.DeleteProduct(id);
            return Ok();
        }

    }
}
