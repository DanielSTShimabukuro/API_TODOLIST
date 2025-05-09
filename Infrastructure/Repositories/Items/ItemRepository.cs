using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Items;
using Domain.Interfaces.Items;
using Infrastructure.Data;

namespace Infrastructure.Repositories.Items
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(AppDbContext context) : base(context)
        {

        }
    }
}
