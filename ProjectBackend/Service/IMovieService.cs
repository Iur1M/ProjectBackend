using ProjectBackend.Domain.Contracts;

namespace ProjectBackend.Service
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieDto>> GetMovies(
            string? search,
            string? director,
            int? year,
            double? minRating,
            double? maxRating,
            string? sortBy,
            bool desc,
            int page,
            int pageSize);
    }
}
