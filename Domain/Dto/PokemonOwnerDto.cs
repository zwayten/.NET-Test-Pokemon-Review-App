namespace Domain.Dto
{
    public class PokemonOwnerDto
    {
        public int PokemonId { get; set; }
        public int OwnerId { get; set; }
        public PokemonDto Pokemon { get; set; }
        public OwnerDto Owner { get; set; }
    }
}
