namespace Domain.Dto
{
    public class PokemonCategoryDto
    {
        public int PokemonId { get; set; }
        public int CategoryId { get; set; }
        public PokemonDto Pokemon { get; set; }
        public CategoryDto Category { get; set; }
    }
}
