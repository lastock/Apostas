using System;
using System.Collections.Generic;
using System.Text;

namespace Apostas.Domain.Entities
{
    public class Apostador
    {
        public int ApostadorId { get; set; }
        public string Senha { get; set; }
        public string login { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<Email> Emails { get; set; }
        public virtual IEnumerable<Celular> Celulares { get; set; }

    }
}
