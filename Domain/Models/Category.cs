using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    //Catagorie might have no pokemons
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<PokemonCategory>? PokemonCategories { get; set; }
    }
}
