using Apostas.Application.AppInterfaces.EntitiesAppInterfaces;
using Apostas.Domain.Interfaces.EntitiesInterfaces;
using System.Collections.Generic;
using Apostas.Domain.Entities;
using System;
using Apostas.Application.AppInterfaces.Generic;
using System.Threading.Tasks;

namespace Apostas.Application.App
{
    public class AppEmail : IAppEmail
    {
        IEmail _IEmail;

        public AppEmail(IEmail IEmail)
        {
            _IEmail = IEmail;
        }

        public void Add(Email Entitie)
        {
            _IEmail.Add(Entitie);
        }

        public void Delete(int Id)
        {
            _IEmail.Delete(Id);
        }

        public async Task<Email> DetailAsync(int Id)
        {
            Email email = await DetailAsync(Id);
            return email;

        }


        public async Task<List<Email>> ListAsync()
        {
            List<Email> emails = await ListAsync();
            return emails;

        }

        public void Update(Email Entitie)
        {
            _IEmail.Update(Entitie);
        }
    }
}
