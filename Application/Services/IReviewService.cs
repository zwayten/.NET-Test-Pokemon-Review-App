using Domain.Models;

namespace Application.Services
{
    public interface IReviewService
    {
        Task AddReview(Review entity);
    }
}
