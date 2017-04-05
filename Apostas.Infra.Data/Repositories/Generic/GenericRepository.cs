using Apostas.Domain.Interfaces.Generic;
using Apostas.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Apostas.Infra.Data.Repositories.Generic
{
    public class GenericRepository<T> : InterfaceGeneric<T>, IDisposable where T : class
    {
        private DbContextOptionsBuilder<ContextBase> _OptionBuilder;

        public GenericRepository()
        {
            _OptionBuilder = new DbContextOptionsBuilder<ContextBase>();
        }
        ~GenericRepository()
        {
            Dispose(false);
        }
        public void Add(T Entitie)
        {
            using (var banco = new DbContext(_OptionBuilder.Options))
            {
                banco.Add(Entitie);
                banco.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (var banco = new DbContext(_OptionBuilder.Options))
            {
                var Objeto = banco.Set<T>().Find(Id);
                banco.Remove(Objeto);
                banco.SaveChanges();
            }
        }


        public async Task <List<T>> List()
        {
            using (var banco = new DbContext(_OptionBuilder.Options))
            {
                return await banco.Set<T>().ToListAsync<T>();
            }
        }

        public void update(T Entitie)
        {
            using (var banco = new DbContext(_OptionBuilder.Options))
            {
                banco.Update(Entitie);
                banco.SaveChanges();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose (bool Status)
        {
            if (!Status) return;
        }

        List<T> InterfaceGeneric<T>.List()
        {
            throw new NotImplementedException();
        }
    }
}
