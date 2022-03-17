using SistemaIndexador.Domain.DTO;
using SistemaIndexador.Domain.Entities;

namespace SistemaIndexador.Domain.Interfaces.Repository
{
    public interface ITabelaPrecoOncoprodRepository : IRepository<TabelaRegrasDMS>
    {
        TabelaRegrasDMS ObterPorDescricao(string descricao);
        TabelaRegrasDMS ObterPorGrupoAutorizacao(string nomeQuimico);
        TabelaRegrasDMS ObterPorCodGrupo(string laboratorio);
        void ExcluirExcel();
        TabelaRegrasDMS ObterPorId(int id);
        void ObterPorCodigo(string Codigo);
        Paged<TabelaRegrasDMS> ObterTodos(string nome, int pageSize, int pageNumber);
        TabelaRegrasDMS ObterPorIdTabela(int id);
    }
}
