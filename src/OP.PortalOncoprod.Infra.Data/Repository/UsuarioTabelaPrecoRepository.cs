using Dapper;
using SistemaIndexador.Domain.DTO;
using SistemaIndexador.Domain.Entities;
using SistemaIndexador.Domain.Interfaces.Repository;
using SistemaIndexador.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIndexador.Infra.Data.Repository
{
    public class UsuarioTabelaPrecoRepository : Repository<UsuarioTabelaPreco>, IUsuarioTabelaPrecoRepository
    {
        public UsuarioTabelaPrecoRepository(PortalOncoprodContext context)
          : base(context)
        {
            

        }
      
        public List<UsuarioTabelaPreco> ObterPorUsuarioId(string usuarioId)
        {
            var cn = Db.Database.Connection;
            try
            {
               
                cn.Open();
                var sql = @"select a.grupoId, usuarioId 
                    from ksUsuarioTabelaPreco as a 
                        inner join KsGrupoSistemaTabelaPreco as b on  a.grupoId = b.grupoId
                    where a.usuarioId like '" + usuarioId + "'";

                var multi = cn.QueryMultiple(sql, new { codigo = usuarioId });
               
                return multi.Read<UsuarioTabelaPreco>().ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();

            }

            
           
        }

    }
}
