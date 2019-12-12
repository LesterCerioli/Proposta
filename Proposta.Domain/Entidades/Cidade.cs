using System;
using System.Collections.Generic;
using System.Text;

namespace Proposta.Domain.Entidades
{
    public class Cidade : BaseEntidade
    {
        public int Id1 { get; set; }
        public string NomeCidade { get; set; }
        public int CodigoIbge { get; set; }
        public int EstadoId { get; set; }
        

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(NomeCidade))
                AdicionarCritica("O Nome da Cidade deve ser preenchido");
        }
    }
}
