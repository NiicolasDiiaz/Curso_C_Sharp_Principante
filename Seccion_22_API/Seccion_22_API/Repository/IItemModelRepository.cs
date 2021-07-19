using Seccion_22_API.DataAccess;
using Seccion_22_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seccion_22_API.Repository
{
    public interface IItemModelRepository
    {

        Task AddItemModel(ItemModel model);

        Task<ItemModel> Get(int Id);

        void UpdateItemModel(ItemModel model);
        Task Delete(int id);

    }
}
