using Apostas.Application.AppInterfaces.EntitiesAppInterfaces;
using System;
using System.Collections.Generic;
using Apostas.Domain.Entities;
using Apostas.Domain.Interfaces.EntitiesInterfaces;
using System.Threading.Tasks;

namespace Apostas.Application.App
{

    public class AppApostador : IAppApostador
    {
        IApostador _IApostador;

        public AppApostador(IApostador IApostador)
        {
            _IApostador = IApostador;
        }

        public void Add(Apostador Entitie)
        {
            _IApostador.Add(Entitie);
        }

        public void Delete(int Id)
        {
            _IApostador.Delete(Id);
        }

        public async Task<Apostador> DetailAsync(int Id)
        {
            Apostador apostador = await DetailAsync(Id);
            return apostador;
        }


        public async Task<List<Apostador>> ListAsync()
        {
            List<Apostador> apostadores = await ListAsync();
            return apostadores;
        }

        public void Update(Apostador Entitie)
        {
            _IApostador.Add(Entitie);
        }
    }
}
