using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SistemaIndexador.Application.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public string usuarioId { get; set; }
        [HiddenInput]
        public string UrlRetorno { get; set; }
        public string usuarioNome { get; set; }
        public bool usuarioAutenticaAD { get; set; }
        public string dominioId { get; set; }

        [Required(ErrorMessage = "Informe o login")]
        [MaxLength(50, ErrorMessage = "O login deve ter até 50 caracteres")]
        public string usuarioLogin { get; set; }
        public string usuarioEmail { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        //[MinLength(8, ErrorMessage = "A senha deve ter pelo menos 8 caracteres")]
        public string usuarioSenha { get; set; }
        public char usuarioSexo { get; set; }
        public string usuarioTipoId { get; set; }
        public string perfilAcessoId { get; set; }
        public bool usuarioAtivo { get; set; }
        public bool permiteAlterarRepreGrpCli { get; set; }
        public bool perHistCli { get; set; }
        public bool perPedReserv { get; set; }
        public bool perOneclick { get; set; }
        public bool perWebMode { get; set; }
        public bool perIpadMode { get; set; }
        public bool perXlsExport { get; set; }
        public char usuarioSimuladorVisualizacao { get; set; }
        public char usuarioSimuladorQuadro { get; set; }
        public string perSacTipo { get; set; }
        public string admPwd { get; set; }
        public string motivoblock { get; set; }
        public DateTime dataBlock { get; set; }
        public int ID7PDV { get; set; }
        

    }
}
