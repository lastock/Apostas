using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apostas.Domain.Interfaces.Generic
{
    public interface InterfaceGeneric<T> where T : class
    {
        void Add(T Entitie);
        void Update(T Entitie);
        void Delete(int Id);
        Task<List<T>> ListAsync();
        Task<T> DetailAsync(int Id);

    }
}
