using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Items;
using Domain.Entities.Items;

namespace Application.Interfaces.Items
{
    public interface IItemService
    {
        Task<Item> CreateItem(CreateItemDTO dto);
        Task<IEnumerable<Item>> GetAllItems();
        Task<Item> GetItemById(Guid id);
        Task<Item> UpdateItem(Guid id, UpdateItemDTO dto);
        Task<Item> DeleteItem(Guid id);
    }
}
