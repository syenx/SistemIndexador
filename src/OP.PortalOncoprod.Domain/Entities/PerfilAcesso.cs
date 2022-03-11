using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaIndexador.Domain.Entities
{
    [Table("ksPerfilAcesso")]
    public class PerfilAcesso
    {
        public string perfilAcessoId { get; set; }
        public string perfilAcessoDescricao { get; set; }
        public bool perfilAcessoWFCadastro { get; set; }
        public bool perfilAcessoWFApoio { get; set; }
        public bool perfilAcessoWFFinanceiro { get; set; }
        public bool perfilAcessoWFFiscal { get; set; }
    }
}







