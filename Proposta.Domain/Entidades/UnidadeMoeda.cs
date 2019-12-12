using System;
using System.Collections.Generic;
using System.Text;

namespace Proposta.Domain.Entidades
{
    public class UnidadeMoeda : BaseEntidade
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public ICollection<Produto> Produtos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome da Unidade de Medida deve ser preenchido");


            if (string.IsNullOrEmpty(Sigla))
                AdicionarCritica("A Sigla deve ser informada");


            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("A Descrição deve ser informada");
        }
    }
}
