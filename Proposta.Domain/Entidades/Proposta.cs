using System;
using System.Collections.Generic;
using System.Text;

namespace Proposta.Domain.Entidades
{
    public class Proposta : BaseEntidade
    {

        public int Id { get; set; }
        public int Codigo { get; set; }
        public int Versao { get; set; }
        public string Nome { get; set; }
        public string DataProposta { get; set; }
        public string UrlArquivo { get; set; }
        public int TemplateId { get; set; }
        public virtual Template Template { get; set; }

        public int ClienteId { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }

        public ICollection<PropostaTag> PropostaTags { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome do Produto deve ser preenchido");

            if (string.IsNullOrEmpty(DataProposta))
                AdicionarCritica("A Data da Proposta deve ser informada");

            if (string.IsNullOrEmpty(UrlArquivo))
                AdicionarCritica("A Url do Arquivo deve ser informada");
        }
    }
}
