using System;
using System.Collections.Generic;
using System.Text;

namespace Proposta.Domain.Entidades
{
    public class Produto : BaseEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int UnidadeMedidaId { get; set; }
        public ICollection<UnidadeMoeda> UnidadeMoedas { get; set; }
        

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome do Produto deve ser informado");

            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("A Descrição deve ser informado");

        }
    }
}
