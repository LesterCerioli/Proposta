using System;
using System.Collections.Generic;
using System.Text;

namespace Proposta.Domain.Entidades
{
    public class TipoSecao : BaseEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool EhObrigatorio { get; set; }
        public string Formato { get; set; }

        public virtual ICollection<Secao> Secaos { get; set; }


        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome deve ser preenchido");

            if (string.IsNullOrEmpty(Formato))
                AdicionarCritica("O Formato deve ser preenchido");
        }
    }
}
