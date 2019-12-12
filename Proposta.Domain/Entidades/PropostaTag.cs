using System;
using System.Collections.Generic;
using System.Text;

namespace Proposta.Domain.Entidades
{
    public class PropostaTag : BaseEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int UnidadeMedidaId { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
