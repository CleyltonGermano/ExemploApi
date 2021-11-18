using AutoMapper;
using ExemploApi.Context.Dto;
using ExemploApi.Models;

namespace ExemploApi.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}
