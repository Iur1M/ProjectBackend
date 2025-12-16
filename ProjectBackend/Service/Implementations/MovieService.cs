using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using DotnetAuth.Infrastructure.Context;
using ProjectBackend.Domain.Contracts;
using ProjectBackend.Service;

namespace ProjectBackend.Service.Implementations
{
    public class MovieService : IMovieService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public MovieService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MovieDto>> GetMovies(
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
            var query = _context.Movies.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(m => m.Title.Contains(search));

            if (!string.IsNullOrWhiteSpace(director))
                query = query.Where(m => m.Director.Contains(director));

            if (year.HasValue)
                query = query.Where(m => m.Year == year.Value);

            if (minRating.HasValue)
                query = query.Where(m => m.Rating >= minRating.Value);

            if (maxRating.HasValue)
                query = query.Where(m => m.Rating <= maxRating.Value);

            query = sortBy?.ToLower() switch
            {
                "year" => desc ? query.OrderByDescending(m => m.Year) : query.OrderBy(m => m.Year),
                "rating" => desc ? query.OrderByDescending(m => m.Rating) : query.OrderBy(m => m.Rating),
                "title" => desc ? query.OrderByDescending(m => m.Title) : query.OrderBy(m => m.Title),
                _ => query.OrderBy(m => m.Id)
            };

            query = query.Skip((page - 1) * pageSize).Take(pageSize);

            return await query
                .ProjectTo<MovieDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
