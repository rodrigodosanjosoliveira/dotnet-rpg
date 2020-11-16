using AutoMapper;
using DotnetRpg.Dtos.Character;
using DotnetRpg.Models;

namespace DotnetRpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}