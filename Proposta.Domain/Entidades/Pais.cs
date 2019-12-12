using System;
using System.Collections.Generic;
using System.Text;

namespace Proposta.Domain.Entidades
{
    public class Pais : BaseEntidade
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string CodigoBacen { get; set; }
        public ICollection<Estado> Estados { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome do País deve ser preenchido");

            if (string.IsNullOrEmpty(Codigo))
                AdicionarCritica("O Código do País deve ser preenchido");

            if (string.IsNullOrEmpty(CodigoBacen))
                AdicionarCritica("O Código BACEN deve ser preenchido");
        }
    }
}
