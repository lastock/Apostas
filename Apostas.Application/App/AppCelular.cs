using Apostas.Application.AppInterfaces.EntitiesAppInterfaces;
using System;
using System.Collections.Generic;
using Apostas.Domain.Entities;
using Apostas.Domain.Interfaces.EntitiesInterfaces;
using Apostas.Domain.Interfaces.Generic;
using System.Threading.Tasks;

namespace Apostas.Application.App
{
    public class AppCelular : ICelular
    {
        ICelular _ICelular;

        public AppCelular(ICelular ICelular)
        {
            _ICelular = ICelular;
        }

        public void Add(Celular Entitie)
        {
            _ICelular.Add(Entitie);
        }

        public void Delete(int Id)
        {
            _ICelular.Delete(Id);
        }

        public async Task<Celular> DetailAsync(int Id)
        {
            Celular Cel = await DetailAsync(Id);
            return Cel;
        }

        public async Task<List<Celular>> ListAsync()
        {
            List<Celular> cels = await ListAsync();
            return cels;
        }

        public void Update(Celular Entitie)
        {
            _ICelular.Update(Entitie);
        }
    }
}
