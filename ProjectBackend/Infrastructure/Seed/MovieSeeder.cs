using Microsoft.EntityFrameworkCore;
using ProjectBackend.Domain.Entities;

namespace ProjectBackend.Infrastructure.Seed
{
    public class MovieSeeder
    {
        public static void SeedMovies(ModelBuilder builder)
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Title = "The Shawshank Redemption", Year = 1994, Rating = 9.3, Director = "Frank Darabont", PosterUrl = "https://m.media-amazon.com/images/I/51NiGlapXlL.jpg" },
                new Movie { Id = 2, Title = "The Godfather", Year = 1972, Rating = 9.2, Director = "Francis Ford Coppola", PosterUrl = "https://m.media-amazon.com/images/I/41+eK8zBwQL.jpg" },
                new Movie { Id = 3, Title = "The Dark Knight", Year = 2008, Rating = 9.0, Director = "Christopher Nolan", PosterUrl = "https://m.media-amazon.com/images/I/51k0qa6zH-L.jpg" },
                new Movie { Id = 4, Title = "Pulp Fiction", Year = 1994, Rating = 8.9, Director = "Quentin Tarantino", PosterUrl = "https://m.media-amazon.com/images/I/71c05lTE03L._AC_SL1024_.jpg" },
                new Movie { Id = 5, Title = "The Lord of the Rings: The Return of the King", Year = 2003, Rating = 8.9, Director = "Peter Jackson", PosterUrl = "https://m.media-amazon.com/images/I/51Qvs9i5a%2BL.jpg" },
                new Movie { Id = 6, Title = "Forrest Gump", Year = 1994, Rating = 8.8, Director = "Robert Zemeckis", PosterUrl = "https://m.media-amazon.com/images/I/61+Kz2Rk6JL._AC_SL1000_.jpg" },
                new Movie { Id = 7, Title = "Fight Club", Year = 1999, Rating = 8.8, Director = "David Fincher", PosterUrl = "https://m.media-amazon.com/images/I/71vV1SWnSUL._AC_SL1500_.jpg" },
                new Movie { Id = 8, Title = "Inception", Year = 2010, Rating = 8.7, Director = "Christopher Nolan", PosterUrl = "https://m.media-amazon.com/images/I/51vbF7DheLL.jpg" },
                new Movie { Id = 9, Title = "The Matrix", Year = 1999, Rating = 8.7, Director = "The Wachowskis", PosterUrl = "https://m.media-amazon.com/images/I/51EG732BV3L.jpg" },
                new Movie { Id = 10, Title = "Goodfellas", Year = 1990, Rating = 8.7, Director = "Martin Scorsese", PosterUrl = "https://m.media-amazon.com/images/I/51edC+FODKL.jpg" },
                new Movie { Id = 11, Title = "Seven", Year = 1995, Rating = 8.6, Director = "David Fincher", PosterUrl = "https://m.media-amazon.com/images/I/71rNJQ2g-QL._AC_SL1500_.jpg" },
                new Movie { Id = 12, Title = "Interstellar", Year = 2014, Rating = 8.6, Director = "Christopher Nolan", PosterUrl = "https://m.media-amazon.com/images/I/91kFYg4fX3L._AC_SL1500_.jpg" },
                new Movie { Id = 13, Title = "The Silence of the Lambs", Year = 1991, Rating = 8.6, Director = "Jonathan Demme", PosterUrl = "https://m.media-amazon.com/images/I/51WcRoWSQlL.jpg" },
                new Movie { Id = 14, Title = "Saving Private Ryan", Year = 1998, Rating = 8.6, Director = "Steven Spielberg", PosterUrl = "https://m.media-amazon.com/images/I/51P1n0Pp-rL.jpg" },
                new Movie { Id = 15, Title = "City of God", Year = 2002, Rating = 8.6, Director = "Fernando Meirelles", PosterUrl = "https://m.media-amazon.com/images/I/51hYwc3%2BcbL.jpg" },
                new Movie { Id = 16, Title = "The Green Mile", Year = 1999, Rating = 8.6, Director = "Frank Darabont", PosterUrl = "https://m.media-amazon.com/images/I/51k0qa6zH-L.jpg" },
                new Movie { Id = 17, Title = "Parasite", Year = 2019, Rating = 8.5, Director = "Bong Joon-ho", PosterUrl = "https://m.media-amazon.com/images/I/71cIkzdg86L._AC_SL1500_.jpg" },
                new Movie { Id = 18, Title = "Leon: The Professional", Year = 1994, Rating = 8.5, Director = "Luc Besson", PosterUrl = "https://m.media-amazon.com/images/I/51Vp5cv16fL.jpg" },
                new Movie { Id = 19, Title = "Gladiator", Year = 2000, Rating = 8.5, Director = "Ridley Scott", PosterUrl = "https://m.media-amazon.com/images/I/51A7Q6Qac7L.jpg" },
                new Movie { Id = 20, Title = "Whiplash", Year = 2014, Rating = 8.5, Director = "Damien Chazelle", PosterUrl = "https://m.media-amazon.com/images/I/81VStYnDGrL._AC_SL1500_.jpg" },
                new Movie { Id = 21, Title = "The Prestige", Year = 2006, Rating = 8.5, Director = "Christopher Nolan", PosterUrl = "https://m.media-amazon.com/images/I/51Y-8jb8eVL.jpg" },
                new Movie { Id = 22, Title = "The Departed", Year = 2006, Rating = 8.5, Director = "Martin Scorsese", PosterUrl = "https://m.media-amazon.com/images/I/51U1vgbuEoL.jpg" },
                new Movie { Id = 23, Title = "The Lion King", Year = 1994, Rating = 8.5, Director = "Roger Allers", PosterUrl = "https://m.media-amazon.com/images/I/51XX-7bb2YL.jpg" },
                new Movie { Id = 24, Title = "Terminator 2: Judgment Day", Year = 1991, Rating = 8.5, Director = "James Cameron", PosterUrl = "https://m.media-amazon.com/images/I/51FzPxPV6mL.jpg" },
                new Movie { Id = 25, Title = "Back to the Future", Year = 1985, Rating = 8.5, Director = "Robert Zemeckis", PosterUrl = "https://m.media-amazon.com/images/I/51T9V5W3uqL.jpg" },
                new Movie { Id = 26, Title = "Alien", Year = 1979, Rating = 8.5, Director = "Ridley Scott", PosterUrl = "https://m.media-amazon.com/images/I/71VmOAX-HcL._AC_SL1500_.jpg" },
                new Movie { Id = 27, Title = "The Pianist", Year = 2002, Rating = 8.5, Director = "Roman Polanski", PosterUrl = "https://m.media-amazon.com/images/I/51DGiokwbrL.jpg" },
                new Movie { Id = 28, Title = "American History X", Year = 1998, Rating = 8.5, Director = "Tony Kaye", PosterUrl = "https://m.media-amazon.com/images/I/51w0nggYJTL.jpg" },
                new Movie { Id = 29, Title = "The Usual Suspects", Year = 1995, Rating = 8.5, Director = "Bryan Singer", PosterUrl = "https://m.media-amazon.com/images/I/51G-5mwi0NL.jpg" },
                new Movie { Id = 30, Title = "Harakiri", Year = 1962, Rating = 8.6, Director = "Masaki Kobayashi", PosterUrl = "https://m.media-amazon.com/images/I/61tQbaO5j5L._AC_SL1000_.jpg" },
                new Movie { Id = 31, Title = "Psycho", Year = 1960, Rating = 8.5, Director = "Alfred Hitchcock", PosterUrl = "https://m.media-amazon.com/images/I/51P91GZmOkL.jpg" },
                new Movie { Id = 32, Title = "Joker", Year = 2019, Rating = 8.4, Director = "Todd Phillips", PosterUrl = "https://m.media-amazon.com/images/I/71wIuP89A9L._AC_SL1400_.jpg" },
                new Movie { Id = 33, Title = "Avengers: Infinity War", Year = 2018, Rating = 8.4, Director = "Russo Brothers", PosterUrl = "https://m.media-amazon.com/images/I/81ai6zx6eXL._AC_SL1500_.jpg" },
                new Movie { Id = 34, Title = "Avengers: Endgame", Year = 2019, Rating = 8.4, Director = "Russo Brothers", PosterUrl = "https://m.media-amazon.com/images/I/81ExhpBEbHL._AC_SL1500_.jpg" },
                new Movie { Id = 35, Title = "Braveheart", Year = 1995, Rating = 8.3, Director = "Mel Gibson", PosterUrl = "https://m.media-amazon.com/images/I/51qCZwSUXKL.jpg" },
                new Movie { Id = 36, Title = "The Wolf of Wall Street", Year = 2013, Rating = 8.2, Director = "Martin Scorsese", PosterUrl = "https://m.media-amazon.com/images/I/91K8M8XlC0L._AC_SL1500_.jpg" },
                new Movie { Id = 37, Title = "Django Unchained", Year = 2012, Rating = 8.4, Director = "Quentin Tarantino", PosterUrl = "https://m.media-amazon.com/images/I/81trWMMqEDL._AC_SL1500_.jpg" },
                new Movie { Id = 38, Title = "Inglourious Basterds", Year = 2009, Rating = 8.3, Director = "Quentin Tarantino", PosterUrl = "https://m.media-amazon.com/images/I/91lWvLmX48L._AC_SL1500_.jpg" },
                new Movie { Id = 39, Title = "Blade Runner 2049", Year = 2017, Rating = 8.0, Director = "Denis Villeneuve", PosterUrl = "https://m.media-amazon.com/images/I/71mazqZu%2BtL._AC_SL1500_.jpg" },
                new Movie { Id = 40, Title = "The Social Network", Year = 2010, Rating = 7.8, Director = "David Fincher", PosterUrl = "https://m.media-amazon.com/images/I/71mUet6xxuL._AC_SL1500_.jpg" },
                new Movie { Id = 41, Title = "The Revenant", Year = 2015, Rating = 8.0, Director = "Alejandro G. Iñárritu", PosterUrl = "https://m.media-amazon.com/images/I/81zMqrVwYpL._AC_SL1500_.jpg" },
                new Movie { Id = 42, Title = "A Beautiful Mind", Year = 2001, Rating = 8.2, Director = "Ron Howard", PosterUrl = "https://m.media-amazon.com/images/I/61DM9Rr1t5L._AC_SL1000_.jpg" },
                new Movie { Id = 43, Title = "Shutter Island", Year = 2010, Rating = 8.2, Director = "Martin Scorsese", PosterUrl = "https://m.media-amazon.com/images/I/81v%2B-FcVGlL._AC_SL1500_.jpg" },
                new Movie { Id = 44, Title = "The Dark Knight Rises", Year = 2012, Rating = 8.4, Director = "Christopher Nolan", PosterUrl = "https://m.media-amazon.com/images/I/81sDWcoH6tL._AC_SL1500_.jpg" },
                new Movie { Id = 45, Title = "Logan", Year = 2017, Rating = 8.1, Director = "James Mangold", PosterUrl = "https://m.media-amazon.com/images/I/91wxPvYBn6L._AC_SL1500_.jpg" },
                new Movie { Id = 46, Title = "Mad Max: Fury Road", Year = 2015, Rating = 8.1, Director = "George Miller", PosterUrl = "https://m.media-amazon.com/images/I/91oGtaqmO0L._AC_SL1500_.jpg" },
                new Movie { Id = 47, Title = "The Truman Show", Year = 1998, Rating = 8.2, Director = "Peter Weir", PosterUrl = "https://m.media-amazon.com/images/I/51K219VKHSL.jpg" },
                new Movie { Id = 48, Title = "The Social Network", Year = 2010, Rating = 7.8, Director = "David Fincher", PosterUrl = "https://m.media-amazon.com/images/I/71mUet6xxuL._AC_SL1500_.jpg" },
                new Movie { Id = 49, Title = "The Revenant", Year = 2015, Rating = 8.0, Director = "Alejandro G. Iñárritu", PosterUrl = "https://m.media-amazon.com/images/I/81zMqrVwYpL._AC_SL1500_.jpg" },
                new Movie { Id = 50, Title = "A Beautiful Mind", Year = 2001, Rating = 8.2, Director = "Ron Howard", PosterUrl = "https://m.media-amazon.com/images/I/61DM9Rr1t5L._AC_SL1000_.jpg" }



            };

            builder.Entity<Movie>().HasData(movies);
        }
    }
}
