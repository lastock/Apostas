
using System;

namespace Apostas.Domain.Entities
{
    public class Email
    {
        public int EmailId { get; set; }
        public string email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public int ApostadorId { get; set; }
        public virtual Apostador Apostador { get; set; }

    }
}
