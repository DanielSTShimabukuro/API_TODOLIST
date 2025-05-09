using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces.Items;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        public IItemRepository Items { get; }

        Task<int> CommitAsync();
        
        Task<int> CompleteAsync();

        void Rollback();
    }
}
