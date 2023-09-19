using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    //Owner may own No pokemons
    //Owner must belong to a Country
    public class Owner
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gym { get; set; }
        public Country Country { get; set; }
        public ICollection<PokemonOwner>? PokemonOwners { get; set; }
    }
}
