using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        public Task<T> GetByIdAsync(int id);
        public Task<List<T>> GetAsync();
        public Task<T> CreateAsync(T entity);
        public Task<T> UpdateAsync(T entity);
        public Task<T> DeleteAsync(T entity);
    }
}
