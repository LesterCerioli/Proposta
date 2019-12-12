using System;
using System.Collections.Generic;
using System.Text;

namespace Proposta.Domain.Entidades
{
    public class Contato : BaseEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Funcao { get; set; }

        public int ClienteId { get; set; }
        public int TipoContatoId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual TipoContato TiposContato { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome deve ser preenchido");

            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("O Email deve ser preenchido");


            if (string.IsNullOrEmpty(Telefone))
                AdicionarCritica("O Telefone deve ser preenchido");

            if (string.IsNullOrEmpty(Celular))
                AdicionarCritica("O Celular deve ser preenchido");
        }
    }
}
