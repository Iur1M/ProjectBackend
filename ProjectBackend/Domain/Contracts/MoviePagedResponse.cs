using ProjectBackend.Domain.Entities;

namespace ProjectBackend.Domain.Contracts
{
    public class MoviePagedResponse
    {
        public IEnumerable<Movie> Items { get; set; } = [];
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}