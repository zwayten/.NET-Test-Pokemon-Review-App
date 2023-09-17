using AutoMapper;
using Domain.Dto;
using Domain.Models;

namespace Domain.Mapper
{
    public class Mapper : Profile
    {
        public Mapper() {
            

            //Category Mapper
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            //Country Mapper
            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();

            //Owner Mapper
            CreateMap<Owner, OwnerDto>();
            CreateMap<OwnerDto, Owner>();

            //Pokemmon Mapper
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<PokemonDto, Pokemon>();

            //Pokemmon-Catgory Mapper
            CreateMap<PokemonCategory, PokemonCategoryDto>();
            CreateMap<PokemonCategoryDto, PokemonCategory>();
            

            //Pokemmon-Owner Mapper
            CreateMap<PokemonOwner, PokemonOwnerDto>();
            CreateMap<PokemonOwnerDto, PokemonOwner>();

            //Review Mapper
            CreateMap<Review, ReviewDto>();
            CreateMap<ReviewDto, Review>();

            //Reviewer Mapper
            CreateMap<Reviewer,ReviewDto>();
            CreateMap<ReviewerDto,Reviewer>();

        }
    }
}
