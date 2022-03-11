﻿using AutoMapper;
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
    public class UsuarioTabelaAppService : ApplicationService, IUsuarioTabelaPrecoAppService
    {

        private readonly IUsuarioTabelaPrecoService _usuarioService;

        public UsuarioTabelaAppService(IUsuarioTabelaPrecoService usuarioService, IUnitOfWork uow)
            : base(uow)
        {
            _usuarioService = usuarioService;
        }

        public void Dispose()
        {
            _usuarioService.Dispose();
            GC.SuppressFinalize(this);
        }

        public UsuarioTabelaPrecoViewModel ObterPorUsuarioId(string usuarioId)
        {
            return Mapper.Map<UsuarioTabelaPrecoViewModel>(_usuarioService.ObterPorUsuarioId(usuarioId));
        }

    }
}
