using SistemaIndexador.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIndexador.Application.Interfaces
{
    public interface IGrupoSistemaTabelaPrecoAppService : IDisposable
    {
        GrupoSistemaTabelaPrecoViewModel Adicionar(GrupoSistemaTabelaPrecoViewModel grupoSistemaTabela);
        GrupoSistemaTabelaPrecoViewModel ObterPorId(int id);
        void ObterPorCodigo(int id);
        GrupoSistemaTabelaPrecoViewModel ObterPorDescricao(string descricao);
        PagedViewModel<GrupoSistemaTabelaPrecoViewModel> ObterTodos(string descricao, int pageSize, int pageNumber);
        GrupoSistemaTabelaPrecoViewModel Atualizar(GrupoSistemaTabelaPrecoViewModel grupoSistemaTabela);
        
        void Remover(int id);
    }
}
