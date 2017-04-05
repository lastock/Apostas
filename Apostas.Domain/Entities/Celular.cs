
using System;

namespace Apostas.Domain.Entities
{
    public class Celular
    {
        public int CelularId { get; set; }
        public string celular { get; set; }
        public int ApostadorId { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual Apostador Apostador { get; set; }

    }
}
