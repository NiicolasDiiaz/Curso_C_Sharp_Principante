using Seccion_22_API.DataAccess;
using Seccion_22_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seccion_22_API.Repository
{
    public class ItemModelRepository : IItemModelRepository
    {
        private readonly IBBDDContext _Context;
        public ItemModelRepository(IBBDDContext Context)
        {
            _Context = Context;
        }

        public async Task AddItemModel(ItemModel model)
        {
            await _Context.ModelItem.AddAsync(model);
            await _Context.SaveChangesAsync();
        }

        public void UpdateItemModel(ItemModel model)
        {
            _Context.ModelItem.Update(model);
            _Context.SaveChanges();
        }


        public async Task<ItemModel>Get(int Id)
        {
            return await _Context.ModelItem.FindAsync(Id);
        }

        public async Task Delete(int id)
        {
            var entity = await Get(id);
            _Context.ModelItem.Remove(entity);
        }
    }
}
