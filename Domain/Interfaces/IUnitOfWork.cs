using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces.Items;
using Domain.Interfaces.Sectors;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        public IItemRepository Items { get; }
        public ISectorRepository Sectors { get; }

        Task<int> CommitAsync();
        
        Task<int> CompleteAsync();

        void Rollback();
    }
}
