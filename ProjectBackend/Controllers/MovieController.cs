using Microsoft.AspNetCore.Mvc;
using ProjectBackend.Service;

namespace ProjectBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies(
            string? search,
            string? director,
            int? year,
            double? minRating,
            double? maxRating,
            string? sortBy,
            bool desc = false,
            int page = 1,
            int pageSize = 10)
        {
            var result = await _movieService.GetMovies(
                search,
                director,
                year,
                minRating,
                maxRating,
                sortBy,
                desc,
                page,
                pageSize);

            return Ok(result);
        }
    }
}
