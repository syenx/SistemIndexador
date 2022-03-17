using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaIndexador.Application.ViewModels
{
    public class TabelaPrecoOncoprodViewModel_v4
    {

        [Key]
        public int Id { get; set; }

        [DisplayName("Código")]
        public string codigo { get; set; }
        [DisplayName("Data Auteração")]
        public string dataAlteracao { get; set; }
        [DisplayName("Margem Minima")]
        public string margemMinima { get; set; }
        [DisplayName("Margem Venda")]
        public string margemVenda { get; set; }
        [DisplayName("Descrição")]
        public string descricao { get; set; }
        [DisplayName("Qualidade")]
        public string apresentacaoQualidade { get; set; }
        [DisplayName("Nome Químico")]
        public string nomeQuimico { get; set; }
        [DisplayName("Laboratório")]
        public string laboratorio { get; set; }
        [DisplayName("EAN")]
        public string ean { get; set; }
        [DisplayName("Registro")]
        public string registro { get; set; }
        [DisplayName("CNM")]
        public string ncm { get; set; }
        [DisplayName("Lista")]
        public string lista { get; set; }
        [DisplayName("Categoria")]
        public string categoria { get; set; }
        [DisplayName("Tipo Armazenamento")]
        public string tipoArmazenamento { get; set; }
        [DisplayName("Controlado")]
        public string produtoControlado { get; set; }
        [DisplayName("Exclusivo Hospitalar")]
        public string exclusivoHospitalar { get; set; }
        [DisplayName("Classificação Fiscal")]
        public string classificacaofiscal { get; set; }
        [DisplayName("NACIONAL / IMPORTADO")]
        public string nacionalImportado { get; set; }
        [DisplayName("Laboratório")]
        public string ufLaboratorio { get; set; }
        [DisplayName("OBS")]
        public string observacao { get; set; }
        [DisplayName("Nível")]
        public string nivel { get; set; }
        [DisplayName("% Aumento")]
        public string aumento { get; set; }
        [DisplayName("OncoProd RS")]
        public string oncoProdRS { get; set; }
        [DisplayName("OncoProd PE")]
        public string oncoProdPE { get; set; }
        [DisplayName("OncoProd SP ICMS 13,3%")]
        public string oncoprodSP_ICMS133 { get; set; }
        [DisplayName("OncoProd SP ICMS 17 %")]
        public string oncoprodSP_ICMS17 { get; set; }
        [DisplayName("OncoProd SP Clientes GO")]
        public string oncoprodSP_ClienteGO { get; set; }
        [DisplayName("OncoProd SP ICMS 17,5%")]
        public string oncoprodSP_ICMS175 { get; set; }
        [DisplayName("OncoProd SP ICMS 18%")]
        public string oncoprodSP_ICMS18 { get; set; }
        [DisplayName("OncoProd SP Clientes SP")]
        public string oncoprodSP_ClienteSP { get; set; }
        [DisplayName("OncoProd SP ICMS 20%")]
        public string oncoprodSP_ICMS20 { get; set; }
        [DisplayName("OncoProd DF ICMS 13,3%")]
        public string oncoprodDF_ICMS133 { get; set; }
        [DisplayName("OncoProd DF ICMS 17%")]
        public string oncoprodDF_ICMS17 { get; set; }
        [DisplayName("OncoProd DF Clientes DF")]
        public string oncoprodDF_ClientesDF { get; set; }
        [DisplayName("OncoProd DF Clientes GO")]
        public string oncoprodDF_ClientesGO { get; set; }
        [DisplayName("OncoProd DF ICMS 17,5%")]
        public string oncoprodDF_ICMS175 { get; set; }
        [DisplayName("OncoProd DF ICMS 18%")]
        public string oncoprodDF_ICMS18 { get; set; }
        [DisplayName("OncoProd DF ICMS 20%")]
        public string oncoprodDF_ICMS20 { get; set; }
        [DisplayName("OncoProd ES Clientes ES")]
        public string oncoprodES_ClientesES { get; set; }
        [DisplayName("OncoProd ES Clientes SP")]
        public string oncoprodES_ClientesSP { get; set; }
        [DisplayName("OncoProd ES Clientes GO")]
        public string oncoprodES_ClientesGO { get; set; }
        [DisplayName("Pessoa Fisica 0%")]
        public string pf_0 { get; set; }
        [DisplayName("Pessoa Fisica 12%")]
        public string pf_12 { get; set; }
        [DisplayName("Pessoa Fisica 13,3%")]
        public string pf_133 { get; set; }
        [DisplayName("Pessoa Fisica 17%")]
        public string pf_17 { get; set; }
        [DisplayName("Pessoa Fisica 17,5%")]
        public string pf_175 { get; set; }
        [DisplayName("Pessoa Fisica 18%")]
        public string pf_18 { get; set; }
        [DisplayName("Pessoa Fisica 20%")]
        public string pf_20 { get; set; }
        [DisplayName("PMC 0%")]
        public string PMC_0 { get; set; }
        [DisplayName("PMC 12%")]
        public string PMC_12 { get; set; }
        [DisplayName("PMC 13,3%")]
        public string PMC_133 { get; set; }
        [DisplayName("PMC 17%")]
        public string PMC_17 { get; set; }
        [DisplayName("PMC 17,5%")]
        public string PMC_175 { get; set; }
        [DisplayName("PMC 18%")]
        public string PMC_18 { get; set; }
        [DisplayName("PMC 20%")]
        public string PMC_20 { get; set; }
        [DisplayName("Observação / Sobre")]
        public string obs { get; set; }
  
        public string AcessoGerente { get; set; }
        public List<UsuarioTabelaRegrasDMSViewModel> PaginasAcessos { get; set; }

    }
}
