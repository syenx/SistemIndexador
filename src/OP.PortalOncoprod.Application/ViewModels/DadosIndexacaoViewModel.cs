
using SistemaIndexador.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaIndexador.Application.ViewModels
{
    public class DadosIndexacaoViewModel
    {
        ITabelaRegrasDMSAppService _tabelaRegrasDMSAppService;

        public DadosIndexacaoViewModel()
        {
        }

        public string matricula { get; set; }
        public string cpf { get; set; }
        public string ref_a { get; set; }
        public string ref_b { get; set; }
        public string validade { get; set; }

        public List<string> TipoDoc { get; set; }
        public string TipoDocSelected { get; set; }

    }
}
