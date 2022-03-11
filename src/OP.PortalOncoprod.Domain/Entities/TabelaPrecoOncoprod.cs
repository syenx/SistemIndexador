// Decompiled with JetBrains decompiler
// Type: SistemaIndexador.Domain.Entities.TabelaPrecoOncoprod
// Assembly: SistemaIndexador.Domain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A0EB73C-6866-409A-822D-92B0E4911B88
// Assembly location: C:\Users\redbu\OneDrive\Área de Trabalho\PortalConsultas\bin\SistemaIndexador.Domain.dll

using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaIndexador.Domain.Entities
{
    [Table("ksTabelaPrecoOncoprod2")]
    public class TabelaPrecoOncoprod
    {
        public int id { get; set; }

        public string codigo { get; set; }

        public string dataAlteracao { get; set; }

        public string margemMinima { get; set; }

        public string margemVenda { get; set; }

        public string descricao { get; set; }

        public string apresentacaoQualidade { get; set; }

        public string nomeQuimico { get; set; }

        public string laboratorio { get; set; }

        public string ean { get; set; }

        public string registro { get; set; }

        public string ncm { get; set; }

        public string lista { get; set; }

        public string categoria { get; set; }

        public string tipoArmazenamento { get; set; }

        public string produtoControlado { get; set; }

        public string exclusivoHospitalar { get; set; }

        public string classificacaofiscal { get; set; }

        public string nacionalImportado { get; set; }

        public string ufLaboratorio { get; set; }

        public string observacao { get; set; }

        public string nivel { get; set; }

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
    }
}
