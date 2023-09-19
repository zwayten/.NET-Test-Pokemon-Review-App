using Domain.Models;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ReviewerRepositoryImpl: RepositoryBaseImpl<Reviewer>, IReviewerRepository
    {
        public ReviewerRepositoryImpl(PokemonDbContext context) : base(context)
        {
        }    
    }
}
