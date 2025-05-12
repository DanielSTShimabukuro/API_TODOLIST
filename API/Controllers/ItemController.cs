using Application.DTOs.Items;
using Application.Interfaces.Items;
using Domain.Entities.Items;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpPost]
        public async Task<ActionResult<Item>> CreateItem(CreateItemDTO dto)
        {
            return Ok(await _itemService.CreateItem(dto));
        }
    }
}
