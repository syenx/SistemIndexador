using SistemaIndexador.Application.ViewModels;

using System;
using System.Collections.Generic;

namespace SistemaIndexador.Application.Interfaces
{
    public interface IUsuarioTabelaPrecoAppService : IDisposable
    {
        UsuarioTabelaPrecoViewModel ObterPorUsuarioId(string usuarioId);
    }
}
