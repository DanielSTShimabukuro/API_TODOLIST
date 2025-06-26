using Domain.Entities.Sectors;
using Domain.Interfaces.Sectors;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Sectors
{
    public class SectorRepository : Repository<Sector>, ISectorRepository
    {
        public SectorRepository(AppDbContext context) : base(context)
        {

        }
    }
}
