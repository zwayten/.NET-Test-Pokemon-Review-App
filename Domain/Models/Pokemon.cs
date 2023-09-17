using System.Collections.ObjectModel;

namespace Domain.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Review>? Reviews { get; set; }

        //public Pokemon()
        //{
        //    Reviews = new Collection<Review>();
        //    Console.WriteLine($"{Reviews.Count}");
        //}
        //public ICollection<PokemonOwner> PokemonOwners { get; set; }
        //public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
