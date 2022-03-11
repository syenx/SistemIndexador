using SistemaIndexador.Application.ViewModels;
using System;

namespace SistemaIndexador.Application.Interfaces
{
    public interface ITabelaPrecoOncoprodAppService : IDisposable
    {
        TabelaPrecoOncoprodViewModel Adicionar(TabelaPrecoOncoprodViewModel tabelaPrecoOncoprodViewModel);
        TabelaPrecoOncoprodViewModel ObterPorId(int id);
        void ObterPorCodigo(string id);
        TabelaPrecoOncoprodViewModel ObterPorDescricao(string descricao);
        TabelaPrecoOncoprodViewModel ObterPorNomeQuimico(string nomeQuimico);
        TabelaPrecoOncoprodViewModel ObterPorLaboratorio(string laboratorio);
        PagedViewModel<TabelaPrecoOncoprodViewModel> ObterTodos(string descricao, int pageSize, int pageNumber);
        TabelaPrecoOncoprodViewModel Atualizar(TabelaPrecoOncoprodViewModel tabelaPrecoOncoprodViewModel);
        void ExcluirExcel();
        void Remover(int id);
        TabelaPrecoOncoprodViewModel ObterPorIdTabela(int value);
    }
}
