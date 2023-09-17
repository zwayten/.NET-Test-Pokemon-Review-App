namespace Domain.Dto
{
    public class OwnerDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gym { get; set; }
        public CountryDto Country { get; set; }
        public ICollection<PokemonOwnerDto> PokemonOwners { get; set; }
    }
}
