namespace Domain.Dto
{
    public class PokemonDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<ReviewDto> Reviews { get; set; }
        public ICollection<PokemonOwnerDto> PokemonOwners { get; set; }
        public ICollection<PokemonCategoryDto> PokemonCategories { get; set; }
    }
}
