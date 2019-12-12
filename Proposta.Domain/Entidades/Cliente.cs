using System;
using System.Collections.Generic;
using System.Text;

namespace Proposta.Domain.Entidades
{
    public class Cliente : BaseEntidade
    {

        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }

        public virtual ICollection<Contato> Contatos { get; set; }
        public virtual ICollection<Proposta> Propostas { get; set; }


        public override void Validate()
        {


            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(RazaoSocial))
                AdicionarCritica("A Razão Social deve ser preenchida");

            if (string.IsNullOrEmpty(RazaoSocial))
                AdicionarCritica("A Razão Social deve ser preenchida");

            if (string.IsNullOrEmpty(CNPJ))
                AdicionarCritica("O CNPJ deve ser preenchido");






        }
    }
}
