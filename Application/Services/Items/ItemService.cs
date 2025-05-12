using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Items;
using Application.Interfaces.Items;
using Domain.Entities.Items;
using Domain.Interfaces;

namespace Application.Services.Items
{
    public class ItemService : IItemService
    {
        private readonly IUnitOfWork _uof;

        public ItemService(IUnitOfWork uof)
        {
            _uof = uof;
        }

        public async Task<Item> CreateItem(CreateItemDTO dto)
        {
            Item item = new Item()
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Description = dto.Description,
                CreateAt = DateTime.UtcNow,
                UpdateAt = DateTime.UtcNow
            };

            Item response;

            if (dto == null)
            {
                new Exception("request is required.");
            }

            response = _uof.Items.Create(item);
            await _uof.CommitAsync();

            return response;
        }
    }
}
