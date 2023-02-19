using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.NetStandard.Services
{
    public interface IDataService<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int Id);
        void DeleteWholeDatabase();
        Task<T> Create(T Entity);
        Task<IEnumerable<T>> CreateRange(IEnumerable<T> Entity);
        Task<T> Update(int Id, T Entity);
        Task<bool> Delete(int Id);
        Task<bool> DeleteRange(IEnumerable<int> Ids);
        Task<IEnumerable<T>> UpdateRange(IEnumerable<T> EntitiesToUpdate);

    }
}