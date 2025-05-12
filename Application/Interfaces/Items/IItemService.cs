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
        Task<Item> CreateItem(CreateItemDTO request);
    }
}
