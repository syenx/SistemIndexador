using SistemaIndexador.Domain.DTO;
using SistemaIndexador.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIndexador.Domain.Interfaces.Service
{
    public interface IUsuarioTabelaPrecoService : IDisposable
    {

        UsuarioTabelaPreco ObterPorUsuarioId(string usuarioId);

    }
}
