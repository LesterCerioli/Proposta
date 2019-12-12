using System;
using System.Collections.Generic;
using System.Text;

namespace Proposta.Domain.Entidades
{
    public class Linguagem : BaseEntidade
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Secao> Secaos { get; set; }

        public virtual ICollection<Secao> Secoes { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome  deve ser preenchido");


        }
    }
}
