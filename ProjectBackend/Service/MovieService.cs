using DotnetAuth.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using ProjectBackend.Domain.Contracts;
using ProjectBackend.Domain.Entities;

namespace ProjectBackend.Service
{
    public class MovieService : IMovieService
    {
        private readonly ApplicationDbContext _context;

        public MovieService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<MoviePagedResponse> GetMovies(
            string? search,
            string? director,
            int? year,
            double? minRating,
            double? maxRating,
            string? sortBy,
            bool desc,
            int page,
            int pageSize)
        {
            IQueryable<Movie> query = _context.Movies;

            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(m => m.Title.Contains(search));

            if (!string.IsNullOrWhiteSpace(director))
                query = query.Where(m => m.Director.Contains(director));

            if (year.HasValue)
                query = query.Where(m => m.Year == year);

            if (minRating.HasValue)
                query = query.Where(m => m.Rating >= minRating);

            if (maxRating.HasValue)
                query = query.Where(m => m.Rating <= maxRating);

            query = sortBy switch
            {
                "rating" => desc
                    ? query.OrderByDescending(m => m.Rating)
                    : query.OrderBy(m => m.Rating),

                "year" => desc
                    ? query.OrderByDescending(m => m.Year)
                    : query.OrderBy(m => m.Year),

                _ => query.OrderBy(m => m.Title)
            };

            var totalCount = await query.CountAsync();

            var movies = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new MoviePagedResponse
            {
                Items = movies,
                TotalCount = totalCount,
                Page = page,
                PageSize = pageSize
            };
        }

        Task<IEnumerable<MovieDto>> IMovieService.GetMovies(string? search, string? director, int? year, double? minRating, double? maxRating, string? sortBy, bool desc, int page, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
