using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Items;

namespace Domain.Interfaces.Items
{
    public interface IItemRepository : IRepository<Item>
    {
        
    }
}
