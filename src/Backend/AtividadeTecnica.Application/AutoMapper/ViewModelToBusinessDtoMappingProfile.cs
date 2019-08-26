using AutoMapper;
using AtividadeTecnica.Application.ViewModels;
using AtividadeTecnica.Domain.Business.Dto;

namespace AtividadeTecnica.Application.AutoMapper
{
    public class ViewModelToBusinessDtoMappingProfile : Profile
    {
        public ViewModelToBusinessDtoMappingProfile()
        {
            CreateMap<CarrinhoViewModel, CarrinhoDto>();                                
        }
    }
}