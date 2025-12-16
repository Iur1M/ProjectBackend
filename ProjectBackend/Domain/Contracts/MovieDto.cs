namespace ProjectBackend.Domain.Contracts
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public double Rating { get; set; }
        public string Director { get; set; }
        public string PosterUrl { get; set; }
    }
}
