using SistemaIndexador.Domain.DTO;
using SistemaIndexador.Domain.Entities;
using SistemaIndexador.Domain.Interfaces.Repository;
using SistemaIndexador.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;

namespace SistemaIndexador.Domain.Services
{
    public class UsuarioTabelaPrecoService : IUsuarioTabelaPrecoService
    {
        private readonly IUsuarioTabelaPrecoRepository _usuario;

        public UsuarioTabelaPrecoService(IUsuarioTabelaPrecoRepository usuario)
        {
            _usuario = usuario;
        }

        public void Dispose()
        {
            _usuario.Dispose();
            GC.SuppressFinalize(this);
        }

        public UsuarioTabelaPreco ObterPorUsuarioId(string usuarioId)
        {
            UsuarioTabelaPreco users = new UsuarioTabelaPreco();
            users.listaUsuarioTabela = _usuario.ObterPorUsuarioId(usuarioId);
            return users;
        }

    }
}

