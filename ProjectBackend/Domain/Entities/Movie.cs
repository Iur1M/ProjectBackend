namespace ProjectBackend.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public double Rating { get; set; }
        public string Director { get; set; }
        public string PosterUrl { get; set; }
    }
}
