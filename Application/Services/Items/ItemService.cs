﻿using System;
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
                UpdateAt = DateTime.UtcNow,
                SectorId = dto.SectorId
            };

            Item response;

            if (dto == null) throw new Exception("Request Is Required.");
            

            response = _uof.Items.Create(item);
            await _uof.CommitAsync();

            return response;
        }

        public async Task<IEnumerable<Item>> GetAllItems()
        {
            return await _uof.Items.GetAllAsync();
        }

        public async Task<Item> GetItemById(Guid id)
        {
            var item = await _uof.Items.GetAsync(item => item.Id == id);

            if (item == null) throw new Exception("Item Not Found.");

            return item;
        }

        public async Task<Item> UpdateItem(Guid id, UpdateItemDTO dto)
        {
            Item item = await GetItemById(id);
            Item response;

            item.Name = dto.Name;
            item.Description = dto.Description;
            item.UpdateAt = DateTime.UtcNow;
            item.SectorId = dto.SectorId;

            response = _uof.Items.Update(item);
            await _uof.CommitAsync();

            return response;
        }

        public async Task<Item> DeleteItem(Guid id)
        {
            Item item = await GetItemById(id);
            Item response;

            response = _uof.Items.Delete(item);
            await _uof.CommitAsync();

            return response;
        }
    }
}
