using AutoMapper;
using SistemaIndexador.Application.Interfaces;
using SistemaIndexador.Application.ViewModels;
using SistemaIndexador.Domain.Entities;
using SistemaIndexador.Domain.Interfaces.Service;
using SistemaIndexador.Infra.Data.Interfaces;
using System;

namespace SistemaIndexador.Application
{
    public class TabelaPrecoOncoprodAppService : ApplicationService, ITabelaPrecoOncoprodAppService
    {
        private readonly ITabelaPrecoOncoprodService _tabelaPrecoOncoprodService;

        public TabelaPrecoOncoprodAppService(ITabelaPrecoOncoprodService tabelaPrecoOncoprodService, IUnitOfWork uow)
            : base(uow)
        {
            _tabelaPrecoOncoprodService = tabelaPrecoOncoprodService;
        }

        public TabelaPrecoOncoprodViewModel Adicionar(TabelaPrecoOncoprodViewModel tabelaPrecoOncoprodViewModel)
        {
            var tabelaPrecoOncoprod = Mapper.Map<TabelaPrecoOncoprod>(tabelaPrecoOncoprodViewModel);

            BeginTransaction();

            var TabelaPrecoOncoprodReturn = _tabelaPrecoOncoprodService.Adicionar(tabelaPrecoOncoprod);
            tabelaPrecoOncoprodViewModel = Mapper.Map<TabelaPrecoOncoprodViewModel>(TabelaPrecoOncoprodReturn);

            Commit();

            return tabelaPrecoOncoprodViewModel;
        }

        public TabelaPrecoOncoprodViewModel Atualizar(TabelaPrecoOncoprodViewModel tabelaPrecoOncoprodViewModel)
        {
            BeginTransaction();
            _tabelaPrecoOncoprodService.Atualizar(Mapper.Map<TabelaPrecoOncoprod>(tabelaPrecoOncoprodViewModel));
            Commit();
            return tabelaPrecoOncoprodViewModel;
        }

        public TabelaPrecoOncoprodViewModel ObterPorDescricao(string descricao)
        {
            return Mapper.Map<TabelaPrecoOncoprodViewModel>(_tabelaPrecoOncoprodService.ObterPorDescricao(descricao));
        }

        public TabelaPrecoOncoprodViewModel ObterPorId(int id)
        {
            return Mapper.Map<TabelaPrecoOncoprodViewModel>(_tabelaPrecoOncoprodService.ObterPorId(id));
        }

        public TabelaPrecoOncoprodViewModel ObterPorLaboratorio(string laboratorio)
        {
            return Mapper.Map<TabelaPrecoOncoprodViewModel>(_tabelaPrecoOncoprodService.ObterPorLaboratorio(laboratorio));
        }

        public TabelaPrecoOncoprodViewModel ObterPorNomeQuimico(string nomeQuimico)
        {
            return Mapper.Map<TabelaPrecoOncoprodViewModel>(_tabelaPrecoOncoprodService.ObterPorNomeQuimico(nomeQuimico));
        }

        public PagedViewModel<TabelaPrecoOncoprodViewModel> ObterTodos(string descricao, int pageSize, int pageNumber)
        {
            return Mapper.Map<PagedViewModel<TabelaPrecoOncoprodViewModel>>(_tabelaPrecoOncoprodService.ObterTodos(descricao, pageSize, pageNumber));
        }

        public void ObterPorCodigo(string id)
        {
          
            _tabelaPrecoOncoprodService.ObterPorCodigo(id);
           
        }

        public void ExcluirExcel()
        {
            BeginTransaction();
            _tabelaPrecoOncoprodService.ExcluirExcel();
            Commit();
        }
        public void Remover(int id)
        {
            BeginTransaction();
            _tabelaPrecoOncoprodService.Remover(id);
            Commit();
        }

        public void Dispose()
        {
            _tabelaPrecoOncoprodService.Dispose();
            GC.SuppressFinalize(this);
        }

        public TabelaPrecoOncoprodViewModel ObterPorIdTabela(int id)
        {
            return Mapper.Map<TabelaPrecoOncoprodViewModel>(_tabelaPrecoOncoprodService.ObterPorIdTabela(id));
        }
    }
}
