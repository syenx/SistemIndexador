
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaIndexador.Domain.Entities
{
    [Table("ksUsuarioTabelaPreco")]
    public class UsuarioTabelaPreco
    {
        public int usuarioTabPrecoId { get; set; }
        public string usuarioId { get; set; }
        public int grupoId { get; set; }
        public List<UsuarioTabelaPreco> listaUsuarioTabela { get; set; }
    }
}
