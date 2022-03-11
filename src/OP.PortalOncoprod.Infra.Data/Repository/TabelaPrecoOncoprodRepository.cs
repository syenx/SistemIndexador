// Decompiled with JetBrains decompiler
// Type: SistemaIndexador.Infra.Data.Repository.TabelaPrecoOncoprodRepository
// Assembly: SistemaIndexador.Infra.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1F67B7BB-2225-4DB4-A5BF-8DE3064A74CC
// Assembly location: C:\Users\redbu\OneDrive\Área de Trabalho\PortalConsultas\bin\SistemaIndexador.Infra.Data.dll

using Dapper;
using SistemaIndexador.Domain.DTO;
using SistemaIndexador.Domain.Entities;
using SistemaIndexador.Domain.Interfaces.Repository;
using SistemaIndexador.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace SistemaIndexador.Infra.Data.Repository
{
    public class TabelaPrecoOncoprodRepository :
      SistemaIndexador.Infra.Data.Repository.Repository<TabelaPrecoOncoprod>,
      ITabelaPrecoOncoprodRepository,
      IRepository<TabelaPrecoOncoprod>,
      IDisposable
    {
        public TabelaPrecoOncoprodRepository(PortalOncoprodContext context)
          : base(context)
        {
        }

        public TabelaPrecoOncoprod ObterPorDescricao(string descricao) => this.Buscar((Expression<Func<TabelaPrecoOncoprod, bool>>)(t => t.descricao == descricao)).FirstOrDefault<TabelaPrecoOncoprod>();

        public TabelaPrecoOncoprod ObterPorId(int id) => this.Buscar((Expression<Func<TabelaPrecoOncoprod, bool>>)(t => t.id == id)).FirstOrDefault<TabelaPrecoOncoprod>();

        public TabelaPrecoOncoprod ObterPorLaboratorio(string laboratorio) => this.Buscar((Expression<Func<TabelaPrecoOncoprod, bool>>)(t => t.laboratorio == laboratorio)).FirstOrDefault<TabelaPrecoOncoprod>();

        public TabelaPrecoOncoprod ObterPorNomeQuimico(string nomeQuimico) => this.Buscar((Expression<Func<TabelaPrecoOncoprod, bool>>)(t => t.nomeQuimico == nomeQuimico)).FirstOrDefault<TabelaPrecoOncoprod>();

        public void ObterPorCodigo(string id)
        {
            DbConnection connection = this.Db.Database.Connection;
            string sql = "\r\n\r\nSELECT id\r\n,codigo\r\n,dataAlteracao\r\n,margemMinima\r\n,margemVenda\r\n,descricao\r\n,apresentacaoQualidade\r\n,nomeQuimico\r\n,laboratorio\r\n,ean\r\n,registro\r\n,ncm\r\n,lista\r\n,categoria\r\n,tipoArmazenamento\r\n,produtoControlado\r\n,exclusivoHospitalar\r\n,classificacaofiscal\r\n,nacionalImportado\r\n,ufLaboratorio\r\n,observacao\r\n,nivel\r\n,aumento\r\n,oncoProdRS_17_SC\r\n,oncoProdRS_175_RS\r\n,oncoProdRS_18_PR\r\n,oncoProdPE_17_AL\r\n,oncoProdPE_18_BA_CE_MA_PB_PE_PI_RN_SE\r\n,oncoprodSP_12_SP_MG\r\n,oncoprodSP_17_AC_AL_GO_MS_MT_PA_RR\r\n,oncoprodSP_175_RO\r\n,oncoprodSP_18_AM_AP_BA_CE_MA_MG_PB_PI_RN_SE_TO\r\n,oncoprodSP_18_SP\r\n,oncoprodSP_20_RJ\r\n,oncoprodDF_12_SP_MG\r\n,oncoprodDF_17_AC_AL_GO_MS_MT_PA_RR\r\n,oncoprodDF_17_DF\r\n,oncoprodDF_17_GO\r\n,oncoprodDF_175_RO\r\n,oncoprodDF_18_AM_AP_BA_CE_MA_MG_PB_PI_RN_SE_TO_SP\r\n,oncoprodDF_20_RJ\r\n,oncoprodES_12_SP_MG\r\n,oncoprodES_17_ES\r\n,oncoprodES_18_SP\r\n,oncoprodES_20_RJ\r\n,pf_0\r\n,pf_12\r\n,pf_17\r\n,pf_175\r\n,pf_18\r\n,pf_20\r\n,PMC_0\r\n,PMC_12\r\n,PMC_17\r\n,PMC_175\r\n,PMC_18\r\n,PMC_20\r\n,indicacao\r\n  FROM [ksTabelaPrecoOncoprod_v5] (nolock)\r\n        WHERE\r\n                            (codigo = '@codigo')";
            connection.QueryMultiple(sql, (object)new
            {
                codigo = id
            }).Read<TabelaPrecoOncoprod>();
            connection.Close();
        }

        public new void ExcluirExcel()
        {
            DbConnection connection = this.Db.Database.Connection;
            connection.Execute("DELETE FROM ksTabelaPrecoOncoprod_v5");
            connection.Close();
        }

        public Paged<TabelaPrecoOncoprod> ObterTodos(
          string descricao,
          int pageSize,
          int pageNumber)
        {
            DbConnection connection = this.Db.Database.Connection;
            string sql = "\r\nSELECT id\r\n,codigo\r\n,dataAlteracao\r\n,margemMinima\r\n,margemVenda\r\n,descricao\r\n,apresentacaoQualidade\r\n,nomeQuimico\r\n,laboratorio\r\n,ean\r\n,registro\r\n,ncm\r\n,lista\r\n,categoria\r\n,tipoArmazenamento\r\n,produtoControlado\r\n,exclusivoHospitalar\r\n,classificacaofiscal\r\n,nacionalImportado\r\n,ufLaboratorio\r\n,observacao\r\n,nivel\r\n,aumento\r\n,oncoProdRS_17_SC\r\n,oncoProdRS_175_RS\r\n,oncoProdRS_18_PR\r\n,oncoProdPE_17_AL\r\n,oncoProdPE_18_BA_CE_MA_PB_PE_PI_RN_SE\r\n,oncoprodSP_12_SP_MG\r\n,oncoprodSP_17_AC_AL_GO_MS_MT_PA_RR\r\n,oncoprodSP_175_RO\r\n,oncoprodSP_18_AM_AP_BA_CE_MA_MG_PB_PI_RN_SE_TO\r\n,oncoprodSP_18_SP\r\n,oncoprodSP_20_RJ\r\n,oncoprodDF_12_SP_MG\r\n,oncoprodDF_17_AC_AL_GO_MS_MT_PA_RR\r\n,oncoprodDF_17_DF\r\n,oncoprodDF_17_GO\r\n,oncoprodDF_175_RO\r\n,oncoprodDF_18_AM_AP_BA_CE_MA_MG_PB_PI_RN_SE_TO_SP\r\n,oncoprodDF_20_RJ\r\n,oncoprodES_12_SP_MG\r\n,oncoprodES_17_ES\r\n,oncoprodES_18_SP\r\n,oncoprodES_20_RJ\r\n,pf_0\r\n,pf_12\r\n,pf_17\r\n,pf_175\r\n,pf_18\r\n,pf_20\r\n,PMC_0\r\n,PMC_12\r\n,PMC_17\r\n,PMC_175\r\n,PMC_18\r\n,PMC_20\r\n,indicacao\r\n  FROM [ksTabelaPrecoOncoprod_v5] (nolock)";
            IEnumerable<TabelaPrecoOncoprod> tabelaPrecoOncoprods; //connection.QueryMultiple(sql).Read<TabelaPrecoOncoprod>();
            Paged<TabelaPrecoOncoprod> paged = new Paged<TabelaPrecoOncoprod>()
            {
               // List = tabelaPrecoOncoprods
            };
            connection.Close();
            return paged;
        }

        public TabelaPrecoOncoprod ObterPorIdTabela(int id)
        {
            string sql = string.Format("SELECT id\r\n,codigo\r\n,dataAlteracao\r\n,margemMinima\r\n,margemVenda\r\n,descricao\r\n,apresentacaoQualidade\r\n,nomeQuimico\r\n,laboratorio\r\n,ean\r\n,registro\r\n,ncm\r\n,lista\r\n,categoria\r\n,tipoArmazenamento\r\n,produtoControlado\r\n,exclusivoHospitalar\r\n,classificacaofiscal\r\n,nacionalImportado\r\n,ufLaboratorio\r\n,observacao\r\n,nivel\r\n,aumento\r\n,oncoProdRS_17_SC\r\n,oncoProdRS_175_RS\r\n,oncoProdRS_18_PR\r\n,oncoProdPE_17_AL\r\n,oncoProdPE_18_BA_CE_MA_PB_PE_PI_RN_SE\r\n,oncoprodSP_12_SP_MG\r\n,oncoprodSP_17_AC_AL_GO_MS_MT_PA_RR\r\n,oncoprodSP_175_RO\r\n,oncoprodSP_18_AM_AP_BA_CE_MA_MG_PB_PI_RN_SE_TO\r\n,oncoprodSP_18_SP\r\n,oncoprodSP_20_RJ\r\n,oncoprodDF_12_SP_MG\r\n,oncoprodDF_17_AC_AL_GO_MS_MT_PA_RR\r\n,oncoprodDF_17_DF\r\n,oncoprodDF_17_GO\r\n,oncoprodDF_175_RO\r\n,oncoprodDF_18_AM_AP_BA_CE_MA_MG_PB_PI_RN_SE_TO_SP\r\n,oncoprodDF_20_RJ\r\n,oncoprodES_12_SP_MG\r\n,oncoprodES_17_ES\r\n,oncoprodES_18_SP\r\n,oncoprodES_20_RJ\r\n,pf_0\r\n,pf_12\r\n,pf_17\r\n,pf_175\r\n,pf_18\r\n,pf_20\r\n,PMC_0\r\n,PMC_12\r\n,PMC_17\r\n,PMC_175\r\n,PMC_18\r\n,PMC_20\r\n,indicacao\r\n  FROM [ksTabelaPrecoOncoprod_v5] (nolock)\r\n  WHERE codigo = '{0}'", id.ToString().PadLeft(5, '0'));


            TabelaPrecoOncoprod tabelaPrecoOncoprod1 =
                this.Db.Database.Connection.QueryMultiple(sql
                       ).Read<TabelaPrecoOncoprod>().FirstOrDefault<TabelaPrecoOncoprod>();
            TabelaPrecoOncoprod tabelaPrecoOncoprod2 = new TabelaPrecoOncoprod();
            return tabelaPrecoOncoprod1;
        }
    }
}
