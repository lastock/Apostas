using System;
using System.Collections.Generic;
using System.Text;

namespace Apostas.Domain.Interfaces.Generic
{
    public interface InterfaceGeneric<T> where T : class
    {
        void Add(T Entitie);
        void update(T Entitie);
        void Delete(int Id);
        List<T> List();

    }
}
