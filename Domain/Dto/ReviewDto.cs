namespace Domain.Dto
{
    public class ReviewDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        public ReviewerDto Reviewer { get; set; }
        public PokemonDto Pokemon { get; set; }
    }
}
