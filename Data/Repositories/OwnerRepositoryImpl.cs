using Domain.Models;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class OwnerRepositoryImpl : RepositoryBaseImpl<Owner>, IOwnerRepository
    {
        public OwnerRepositoryImpl(PokemonDbContext context) : base(context)
        {
        }
    }
}
