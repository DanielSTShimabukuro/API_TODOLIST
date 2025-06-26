using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Interfaces.Items;
using Domain.Interfaces.Sectors;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly AppDbContext _context;

        public IItemRepository Items { get; }
        public ISectorRepository Sectors { get; }

        public UnitOfWork(AppDbContext context, IItemRepository itemRepository, ISectorRepository sectorRepository) 
        {
            _context = context; 
            Items = itemRepository;
            Sectors = sectorRepository;
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> CompleteAsync()
        {
            return await CommitAsync();
        }

        public void Rollback()
        {
            foreach (var entry in _context.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added: 
                        entry.State = EntityState.Detached; 
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break ;
                }
            }
        }
    }
}
