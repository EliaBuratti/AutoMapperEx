using AutoMapperEx.Models;
using AutoMapper;
using System.Runtime.CompilerServices;

namespace AutoMapperEx
{

        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<Dog,DogDto>();

                CreateMap<Cat, CatDto>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Nato, opt => opt.MapFrom(src => src.Born))
                .ForMember(dest => dest.Peso, opt => opt.MapFrom(src => src.Weight))
                .ForMember(dest => dest.Dimensioni, opt => opt.MapFrom(src => src.Dimension))
                .ForMember(dest => dest.Tipologia, opt => opt.MapFrom(src => src.Kind))
                .ForMember(dest => dest.Indipendente, opt => opt.MapFrom(src => src.Indipendent));
        }

        }

}
