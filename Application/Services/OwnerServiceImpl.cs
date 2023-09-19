using Data.Repositories;
using Domain.Models;
using Infrastructure;
using Infrastructure.ServiceFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class OwnerServiceImpl: /*ServiceBaseImpl<Owner>,*/ IOwnerService
    {
        private readonly IOwnerRepository _ownerRepository;
        public OwnerServiceImpl(IOwnerRepository reposiorty)
        {
            _ownerRepository = reposiorty;   
        }

        public Owner AddOwner(Owner entity)
        {
             var owner = _ownerRepository.Add(entity);
            return owner;
        }

        public async Task<IEnumerable<Owner>> GetAllOwner()
        {
            return await _ownerRepository.GetAll();
        }
    }
}
