using AutoMapper;
using SistemaIndexador.Application.ViewModels;
using SistemaIndexador.Domain.DTO;
using SistemaIndexador.Domain.Entities;

namespace SistemaIndexador.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<UsuarioTabelaPreco, UsuarioTabelaPrecoViewModel>();
            CreateMap<GrupoSistemaTabelaPreco, GrupoSistemaTabelaPrecoViewModel>();
            CreateMap<TabelaPrecoOncoprod, TabelaPrecoOncoprodViewModel>();
            CreateMap<Paged<TabelaPrecoOncoprod>, PagedViewModel<TabelaPrecoOncoprodViewModel>>();
            CreateMap<Paged<Usuario>, PagedViewModel<UsuarioViewModel>>();
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<PerfilAcesso, PerfilAcessoViewModel>();
        }
    }
}