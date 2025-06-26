using Application.DTOs.Sectors;
using Application.Interfaces.Sectors;
using Domain.Entities.Items;
using Domain.Entities.Sectors;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Sectors
{
    public class SectorService : ISectorService
    {
        private readonly IUnitOfWork _uof;

        public SectorService(IUnitOfWork uof)
        {
            _uof = uof;
        }

        public async Task<Sector> CreateSector(CreateSectorDTO dto)
        {
            Sector sector = new Sector()
            {
                SectorId = Guid.NewGuid(),
                Name = dto.Name
            };

            Sector response;

            if (dto == null) throw new Exception("Request Is Required.");


            response = _uof.Sectors.Create(sector);
            await _uof.CommitAsync();

            return response;
        }

        public async Task<Sector> DeleteSectorById(Guid id)
        {
            Sector sector = await GetSectorById(id);
            Sector response;

            response = _uof.Sectors.Delete(sector);
            await _uof.CommitAsync();

            return response; 
        }

        public async Task<IEnumerable<Sector>> GetAllSectors()
        {
            return await _uof.Sectors.GetAllAsync();
        }

        public async Task<Sector> GetSectorById(Guid id)
        {
            var sector = await _uof.Sectors.GetAsync(sector => sector.SectorId == id);

            if (sector == null) throw new Exception("Item Not Found.");

            return sector;
        }

        public async Task<Sector> UpdateSectorById(Guid id, UpdateSectorDTO dto)
        {
            Sector sector = await GetSectorById(id);
            Sector response;

            sector.Name = dto.Name;

            response = _uof.Sectors.Update(sector);
            await _uof.CommitAsync();

            return response;
        }
    }
}
