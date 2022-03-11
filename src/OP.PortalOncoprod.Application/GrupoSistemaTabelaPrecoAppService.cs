using SistemaIndexador.Application.Interfaces;
using SistemaIndexador.Application.ViewModels;
using SistemaIndexador.Domain.Interfaces.Service;
using SistemaIndexador.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIndexador.Application
{
    public class GrupoSistemaTabelaPrecoAppService : ApplicationService, IGrupoSistemaTabelaPrecoAppService
    {
        private readonly IGrupoSistemaTabelaPrecoService _grupoTabelaService;

        public GrupoSistemaTabelaPrecoAppService(IGrupoSistemaTabelaPrecoService grupoTabelaService, IUnitOfWork uow)
            : base(uow)
        {
            _grupoTabelaService = grupoTabelaService;
        }

        public GrupoSistemaTabelaPrecoViewModel Adicionar(GrupoSistemaTabelaPrecoViewModel grupoSistemaTabela)
        {
            throw new NotImplementedException();
        }

        public GrupoSistemaTabelaPrecoViewModel Atualizar(GrupoSistemaTabelaPrecoViewModel grupoSistemaTabela)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _grupoTabelaService.Dispose();
            GC.SuppressFinalize(this);
        }

        public void ObterPorCodigo(int id)
        {
            throw new NotImplementedException();
        }

        public GrupoSistemaTabelaPrecoViewModel ObterPorDescricao(string descricao)
        {
            throw new NotImplementedException();
        }

        public GrupoSistemaTabelaPrecoViewModel ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public PagedViewModel<GrupoSistemaTabelaPrecoViewModel> ObterTodos(string descricao, int pageSize, int pageNumber)
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
