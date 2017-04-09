using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apostas.Application.AppInterfaces.Generic
{
    public interface IApplicationGeneric<T> where T : class
    {
        void Add(T Entitie);
        void Update(T Entitie);
        void Delete(int Id);
        Task<List<T>> ListAsync();
        Task<T> DetailAsync(int Id);
    }
}
