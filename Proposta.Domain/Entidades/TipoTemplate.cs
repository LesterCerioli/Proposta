using System;
using System.Collections.Generic;
using System.Text;

namespace Proposta.Domain.Entidades
{
    public class TipoTemplate : BaseEntidade
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int TemplateId { get; set; }
        public virtual ICollection<Template> Templates { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();


            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome deve ser preenchido");
        }
    }
}
