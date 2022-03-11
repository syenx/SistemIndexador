using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIndexador.Application.ViewModels
{
    public class UsuarioTabelaPrecoViewModel
    {
        [Key]

        public int Id { get; set; }

        [DisplayName("usuarioTabPrecoId")]
        public int usuarioTabPrecoId { get; set; }

        [DisplayName("usuarioId")]
        public string usuarioId { get; set; }

        [DisplayName("grupoId")]
        public string grupoId { get; set; }

        public List<UsuarioTabelaPrecoViewModel> listaUsuarioTabela { get; set; }
        public List<GrupoSistemaTabelaPrecoViewModel> listaGrupo{ get; set; }
    }
}
