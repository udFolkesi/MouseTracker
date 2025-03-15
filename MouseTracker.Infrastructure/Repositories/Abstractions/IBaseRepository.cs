using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseTracker.Infrastructure.Repositories.Abstractions
{
    public interface IBaseRepository<T>
    {
        Task AddAsync(T entity);
    }
}
