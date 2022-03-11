// Decompiled with JetBrains decompiler
// Type: SistemaIndexador.Application.ViewModels.TabelaPrecoOncoprodViewModel
// Assembly: SistemaIndexador.Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8ACDBE2E-618F-4D71-B415-7B62351E8B68
// Assembly location: C:\Users\redbu\OneDrive\Área de Trabalho\PortalConsultas\bin\SistemaIndexador.Application.dll

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaIndexador.Application.ViewModels
{
    public class TabelaPrecoOncoprodViewModel
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Código")]
        public string codigo { get; set; }

        [DisplayName("Data Alteração")]
        public string dataAlteracao { get; set; }

        [DisplayName("Margem Minima")]
        public string margemMinima { get; set; }

        [DisplayName("Margem Venda")]
        public string margemVenda { get; set; }

        [DisplayName("Descrição")]
        public string descricao { get; set; }

        [DisplayName("Quantidade")]
        public string apresentacaoQualidade { get; set; }

        [DisplayName("Nome Químico")]
        public string nomeQuimico { get; set; }

        [DisplayName("Laboratório")]
        public string laboratorio { get; set; }

        [DisplayName("EAN")]
        public string ean { get; set; }

        [DisplayName("Registro")]
        public string registro { get; set; }

        [DisplayName("NCM")]
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

        public string oncoProdRS_17_SC { get; set; }

        public string oncoProdRS_175_RS { get; set; }

        public string oncoProdRS_18_PR { get; set; }

        public string oncoProdPE_17_AL { get; set; }

        public string oncoProdPE_18_BA_CE_MA_PB_PE_PI_RN_SE { get; set; }

        public string oncoprodSP_12_SP_MG { get; set; }

        public string oncoprodSP_17_AC_AL_GO_MS_MT_PA_RR { get; set; }

        public string oncoprodSP_175_RO { get; set; }

        public string oncoprodSP_18_AM_AP_BA_CE_MA_MG_PB_PI_RN_SE_TO { get; set; }

        public string oncoprodSP_18_SP { get; set; }

        public string oncoprodSP_20_RJ { get; set; }

        public string oncoprodDF_12_SP_MG { get; set; }

        public string oncoprodDF_17_AC_AL_GO_MS_MT_PA_RR { get; set; }

        public string oncoprodDF_17_DF { get; set; }

        public string oncoprodDF_17_GO { get; set; }

        public string oncoprodDF_175_RO { get; set; }

        public string oncoprodDF_18_AM_AP_BA_CE_MA_MG_PB_PI_RN_SE_TO_SP { get; set; }

        public string oncoprodDF_20_RJ { get; set; }

        public string oncoprodES_12_SP_MG { get; set; }

        public string oncoprodES_17_ES { get; set; }

        public string oncoprodES_18_SP { get; set; }

        public string oncoprodES_20_RJ { get; set; }

        public string pf_0 { get; set; }

        public string pf_12 { get; set; }

        public string pf_17 { get; set; }

        public string pf_175 { get; set; }

        public string pf_18 { get; set; }

        public string pf_20 { get; set; }

        public string PMC_0 { get; set; }

        public string PMC_12 { get; set; }

        public string PMC_17 { get; set; }

        public string PMC_175 { get; set; }

        public string PMC_18 { get; set; }

        public string PMC_20 { get; set; }

        public string indicacao { get; set; }

        public string AcessoGerente { get; set; }

        public List<UsuarioTabelaPrecoViewModel> PaginasAcessos { get; set; }
    }
}
