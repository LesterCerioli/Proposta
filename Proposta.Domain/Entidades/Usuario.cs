using System;
using System.Collections.Generic;
using System.Text;

namespace Proposta.Domain.Entidades
{
    public class Usuario : BaseEntidade
    {
        public int Id { get; set; }
        public int PerfilUsuarioId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Login { get; set; }
        public bool EhAdministrador { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }


        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome deve ser preenchido");

            if (string.IsNullOrEmpty(Sobrenome))
                AdicionarCritica("O Sobrenome deve ser preenchido");

            if (string.IsNullOrEmpty(Login))
                AdicionarCritica("O Login deve ser preenchido");

            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("O Email deve ser preenchido");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("A Senha deve ser preenchido");
        }
    }
}
