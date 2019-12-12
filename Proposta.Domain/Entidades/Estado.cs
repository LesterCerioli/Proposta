using System;
using System.Collections.Generic;
using System.Text;

namespace Proposta.Domain.Entidades
{
    public class Estado : BaseEntidade
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public int CodigoIbge { get; set; }
        public int PaisId { get; set; }
        public ICollection<Pais> Paises { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome do Estado deve ser preenchido");

            if (string.IsNullOrEmpty(UF))
                AdicionarCritica("A UF do Estado deve ser preenchida");
        }
    }
}
