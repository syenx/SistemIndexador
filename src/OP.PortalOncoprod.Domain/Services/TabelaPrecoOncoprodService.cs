using SistemaIndexador.Domain.Interfaces.Repository;
using SistemaIndexador.Domain.Interfaces.Service;
using SistemaIndexador.Domain.Entities;
using System;
using SistemaIndexador.Domain.DTO;

namespace SistemaIndexador.Domain.Services
{
    public class TabelaPrecoOncoprodService : ITabelaPrecoOncoprodService
    {
        private readonly ITabelaPrecoOncoprodRepository _tabelaPrecoOncoprodRepository;

        public TabelaPrecoOncoprodService(ITabelaPrecoOncoprodRepository tabelaPrecoOncoprodRepository)
        {
            _tabelaPrecoOncoprodRepository = tabelaPrecoOncoprodRepository;
        }

        public TabelaPrecoOncoprod Adicionar(TabelaPrecoOncoprod tabelaPrecoOncoprod)
        {
            return _tabelaPrecoOncoprodRepository.Adicionar(tabelaPrecoOncoprod);
        }

        public TabelaPrecoOncoprod Atualizar(TabelaPrecoOncoprod tabelaPrecoOncoprod)
        {
            return _tabelaPrecoOncoprodRepository.Atualizar(tabelaPrecoOncoprod);
        }
    
        public TabelaPrecoOncoprod ObterPorDescricao(string descricao)
        {
            return _tabelaPrecoOncoprodRepository.ObterPorDescricao(descricao);
        }

        public TabelaPrecoOncoprod ObterPorId(int id)
        {
            return _tabelaPrecoOncoprodRepository.ObterPorId(id);
        }

        public TabelaPrecoOncoprod ObterPorLaboratorio(string laboratorio)
        {
            return _tabelaPrecoOncoprodRepository.ObterPorLaboratorio(laboratorio);
        }

        public TabelaPrecoOncoprod ObterPorNomeQuimico(string nomeQuimico)
        {
            return _tabelaPrecoOncoprodRepository.ObterPorNomeQuimico(nomeQuimico);
        }

        public Paged<TabelaPrecoOncoprod> ObterTodos(string nome, int pageSize, int pageNumber)
        {
            return _tabelaPrecoOncoprodRepository.ObterTodos(nome, pageSize, pageNumber);
        }

        public void ObterPorCodigo(string codigo)
        {
             _tabelaPrecoOncoprodRepository.ObterPorCodigo(codigo);
        }

        public void ExcluirExcel()
        {
            _tabelaPrecoOncoprodRepository.ExcluirExcel();
        }
        public void Remover(int id)
        {
            _tabelaPrecoOncoprodRepository.Remover(id);
        }

        public void Dispose()
        {
            _tabelaPrecoOncoprodRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public TabelaPrecoOncoprod ObterPorIdTabela(int id)
        {
            return _tabelaPrecoOncoprodRepository.ObterPorIdTabela(id);
        }
    }
}
