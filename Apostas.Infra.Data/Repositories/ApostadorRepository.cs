using Apostas.Domain.Entities;
using Apostas.Domain.Interfaces.EntitiesInterfaces;
using Apostas.Infra.Data.Repositories.Generic;

namespace Apostas.Infra.Data.Repositories
{
    public class ApostadorRepository : GenericRepository<Apostador>, IApostador
    {
    }
}
