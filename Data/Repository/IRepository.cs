using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface IRepository<T, TId> where T : class
    {
        Task<T> GetAsync(TId id);
        Task<List<T>> GetRangeAsync(List<TId> ids); 
        Task<List<T>> GetAllAsync();
    }
}
