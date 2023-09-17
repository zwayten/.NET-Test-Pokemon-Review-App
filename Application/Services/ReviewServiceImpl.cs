using Data.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ReviewServiceImpl : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        public ReviewServiceImpl(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }
        public async Task AddReview(Review entity)
        {
            await _reviewRepository.Add(entity);
        }
    }
}
