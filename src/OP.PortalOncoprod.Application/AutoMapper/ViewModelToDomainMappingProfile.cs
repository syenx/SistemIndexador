using AutoMapper;
using SistemaIndexador.Application.ViewModels;
using SistemaIndexador.Domain.Entities;

namespace SistemaIndexador.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<UsuarioTabelaPrecoViewModel,UsuarioTabelaPreco>();
            CreateMap<GrupoSistemaTabelaPrecoViewModel, GrupoSistemaTabelaPreco>();
            CreateMap<TabelaPrecoOncoprodViewModel, TabelaPrecoOncoprod>();
            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<PerfilAcessoViewModel, PerfilAcesso>();
        }
    }
}