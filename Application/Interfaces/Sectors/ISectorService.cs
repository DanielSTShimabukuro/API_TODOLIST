using Application.DTOs.Sectors;
using Domain.Entities.Sectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Sectors
{
    public interface ISectorService
    {
        Task<Sector> CreateSector(CreateSectorDTO dto);
        Task<IEnumerable<Sector>> GetAllSectors();
        Task<Sector> GetSectorById(Guid id);
        Task<Sector> UpdateSectorById(Guid id, UpdateSectorDTO dto);
        Task<Sector> DeleteSectorById(Guid id);
    }
}
