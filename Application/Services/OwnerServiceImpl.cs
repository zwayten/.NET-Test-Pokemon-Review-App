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
    public class OwnerServiceImpl: ServiceBaseImpl<Owner>, IOwnerService
    {
        public OwnerServiceImpl(IOwnerRepository reposiorty) : base(reposiorty)
        {
            
        }
    }
}
