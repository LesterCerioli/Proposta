using System;
using System.Collections.Generic;
using System.Text;

namespace Proposta.Domain.Entidades
{
    public class PerfilUsuario : BaseEntidade
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Nome { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Perfil de Usuário deve ser preenchido");
        }
    }
}
