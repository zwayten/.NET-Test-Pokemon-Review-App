using Data.Repositories;
using Domain.Models;
using Infrastructure.ServiceFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ReviewerServiceImpl : ServiceBaseImpl<Reviewer> , IReviewerService
    {
        public ReviewerServiceImpl(IReviewerRepository repository): base(repository)
        { 

        }
    }
}
