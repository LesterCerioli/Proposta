using System;
using System.Collections.Generic;
using System.Text;

namespace Proposta.Domain.Entidades
{
    public class Moeda : BaseEntidade
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("A Moeda deve ser informada");
        }
    }
}
