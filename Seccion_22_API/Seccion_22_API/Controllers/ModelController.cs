using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Seccion_22_API.Models;
using Seccion_22_API.Repository;
using Seccion_22_API.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seccion_22_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {

        private readonly ItemModelRepository _ModelRepository;

        public ModelController(ItemModelRepository ModelRepository)
        {
            _ModelRepository = ModelRepository;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _ModelRepository.Get(id);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ItemModelRequest request)
        {
            var entity = new ItemModel
            {
                EsCliente = true,
                Nombre = request.Nombre
            };
            await _ModelRepository.AddItemModel(entity);
            return Ok();
        }
        
        [HttpPut]
        public void Put([FromBody]ItemModel model)
        {
            _ModelRepository.UpdateItemModel(model);
        }

        [HttpDelete("{id}")]
        public void Delete (int id)
        {
            _ModelRepository.Delete(id);
        }

    }
}
