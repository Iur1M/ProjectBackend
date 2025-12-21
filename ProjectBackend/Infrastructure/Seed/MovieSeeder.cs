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
                new Movie { Id = 1, Title = "The Shawshank Redemption", Year = 1994, Rating = 9.3, Director = "Frank Darabont", PosterUrl = "https://image.tmdb.org/t/p/w500/q6y0Go1tsGEsmtFryDOJo3dEmqu.jpg" },
                new Movie { Id = 2, Title = "The Godfather", Year = 1972, Rating = 9.2, Director = "Francis Ford Coppola", PosterUrl = "https://image.tmdb.org/t/p/w500/3bhkrj58Vtu7enYsRolD1fZdja1.jpg" },
                new Movie { Id = 3, Title = "The Dark Knight", Year = 2008, Rating = 9.0, Director = "Christopher Nolan", PosterUrl = "https://image.tmdb.org/t/p/w500/qJ2tW6WMUDux911r6m7haRef0WH.jpg" },
                new Movie { Id = 4, Title = "Pulp Fiction", Year = 1994, Rating = 8.9, Director = "Quentin Tarantino", PosterUrl = "https://image.tmdb.org/t/p/w500/fIE3lAGcZDV1G6XM5KmuWnNsPp1.jpg" },
                new Movie { Id = 5, Title = "The Lord of the Rings: The Return of the King", Year = 2003, Rating = 8.9, Director = "Peter Jackson", PosterUrl = "https://image.tmdb.org/t/p/w500/rCzpDGLbOoPwLjy3OAm5NUPOTrC.jpg" },

                new Movie { Id = 6, Title = "Forrest Gump", Year = 1994, Rating = 8.8, Director = "Robert Zemeckis", PosterUrl = "https://image.tmdb.org/t/p/w500/saHP97rTPS5eLmrLQEcANmKrsFl.jpg" },
                new Movie { Id = 7, Title = "Fight Club", Year = 1999, Rating = 8.8, Director = "David Fincher", PosterUrl = "https://image.tmdb.org/t/p/w500/bptfVGEQuv6vDTIMVCHjJ9Dz8PX.jpg" },
                new Movie { Id = 8, Title = "Inception", Year = 2010, Rating = 8.7, Director = "Christopher Nolan", PosterUrl = "https://image.tmdb.org/t/p/w500/9gk7adHYeDvHkCSEqAvQNLV5Uge.jpg" },
                new Movie { Id = 9, Title = "The Matrix", Year = 1999, Rating = 8.7, Director = "The Wachowskis", PosterUrl = "https://image.tmdb.org/t/p/w500/f89U3ADr1oiB1s9GkdPOEpXUk5H.jpg" },
                new Movie { Id = 10, Title = "Goodfellas", Year = 1990, Rating = 8.7, Director = "Martin Scorsese", PosterUrl = "https://image.tmdb.org/t/p/w500/aKuFiU82s5ISJpGZp7YkIr3kCUd.jpg" },

                new Movie { Id = 11, Title = "Se7en", Year = 1995, Rating = 8.6, Director = "David Fincher", PosterUrl = "https://image.tmdb.org/t/p/w500/6yoghtyTpznpBik8EngEmJskVUO.jpg" },
                new Movie { Id = 12, Title = "Interstellar", Year = 2014, Rating = 8.6, Director = "Christopher Nolan", PosterUrl = "https://image.tmdb.org/t/p/w500/gEU2QniE6E77NI6lCU6MxlNBvIx.jpg" },
                new Movie { Id = 13, Title = "The Silence of the Lambs", Year = 1991, Rating = 8.6, Director = "Jonathan Demme", PosterUrl = "https://image.tmdb.org/t/p/w500/uS9m8OBk1A8eM9I042bx8XXpqAq.jpg" },
                new Movie { Id = 14, Title = "Saving Private Ryan", Year = 1998, Rating = 8.6, Director = "Steven Spielberg", PosterUrl = "https://image.tmdb.org/t/p/w500/uqx37cS8cpHg8U35f9U5IBlrCV3.jpg" },
                new Movie { Id = 15, Title = "City of God", Year = 2002, Rating = 8.6, Director = "Fernando Meirelles", PosterUrl = "https://image.tmdb.org/t/p/w500/k7eYdWvhYQyRQoU2TB2A2Xu2TfD.jpg" },

                new Movie { Id = 16, Title = "The Green Mile", Year = 1999, Rating = 8.6, Director = "Frank Darabont", PosterUrl = "https://image.tmdb.org/t/p/w500/o0lO84GI7qrG6XFvtsPOSV7CTNa.jpg" },
                new Movie { Id = 17, Title = "Parasite", Year = 2019, Rating = 8.5, Director = "Bong Joon-ho", PosterUrl = "https://image.tmdb.org/t/p/w500/7IiTTgloJzvGI1TAYymCfbfl3vT.jpg" },
                new Movie { Id = 18, Title = "Léon: The Professional", Year = 1994, Rating = 8.5, Director = "Luc Besson", PosterUrl = "https://image.tmdb.org/t/p/w500/yI6X2cCM5YPJtxMhUd3dPGqDAhw.jpg" },
                new Movie { Id = 19, Title = "Gladiator", Year = 2000, Rating = 8.5, Director = "Ridley Scott", PosterUrl = "https://image.tmdb.org/t/p/w500/ty8TGRuvJLPUmAR1H1nRIsgwvim.jpg" },
                new Movie { Id = 20, Title = "Whiplash", Year = 2014, Rating = 8.5, Director = "Damien Chazelle", PosterUrl = "https://image.tmdb.org/t/p/w500/6uSPcdGJAkF6P5kP1K9z5i2nV8p.jpg" },

                new Movie { Id = 21, Title = "The Prestige", Year = 2006, Rating = 8.5, Director = "Christopher Nolan", PosterUrl = "https://image.tmdb.org/t/p/w500/5MXyQfz8xUP3dIFPTubhTsbFY6N.jpg" },
                new Movie { Id = 22, Title = "The Departed", Year = 2006, Rating = 8.5, Director = "Martin Scorsese", PosterUrl = "https://image.tmdb.org/t/p/w500/nT97ifVT2J1yMQmeq20Qblg61T.jpg" },
                new Movie { Id = 23, Title = "The Lion King", Year = 1994, Rating = 8.5, Director = "Roger Allers", PosterUrl = "https://image.tmdb.org/t/p/w500/sKCr78MXSLixwmZ8DyJLrpMsd15.jpg" },
                new Movie { Id = 24, Title = "Terminator 2: Judgment Day", Year = 1991, Rating = 8.5, Director = "James Cameron", PosterUrl = "https://image.tmdb.org/t/p/w500/5M0j0B18abtBI5gi2RhfjjurTqb.jpg" },
                new Movie { Id = 25, Title = "Back to the Future", Year = 1985, Rating = 8.5, Director = "Robert Zemeckis", PosterUrl = "https://image.tmdb.org/t/p/w500/pTpxQB1N0waaSc3OSn0e9oc8kx9.jpg" },

                new Movie { Id = 26, Title = "Alien", Year = 1979, Rating = 8.5, Director = "Ridley Scott", PosterUrl = "https://image.tmdb.org/t/p/w500/vfrQk5IPloGg1v9Rzbh2Eg3VGyM.jpg" },
                new Movie { Id = 27, Title = "The Pianist", Year = 2002, Rating = 8.5, Director = "Roman Polanski", PosterUrl = "https://image.tmdb.org/t/p/w500/2hFvxCCWrTmCYwfy7yum0GKRi3Y.jpg" },
                new Movie { Id = 28, Title = "American History X", Year = 1998, Rating = 8.5, Director = "Tony Kaye", PosterUrl = "https://image.tmdb.org/t/p/w500/c2gsmSQ2Cqv8zosqKOCwRS0GFBS.jpg" },
                new Movie { Id = 29, Title = "The Usual Suspects", Year = 1995, Rating = 8.5, Director = "Bryan Singer", PosterUrl = "https://image.tmdb.org/t/p/w500/bUPmtQzrRhzqYySeiMpv7GurAfm.jpg" },
                new Movie { Id = 30, Title = "Harakiri", Year = 1962, Rating = 8.6, Director = "Masaki Kobayashi", PosterUrl = "https://image.tmdb.org/t/p/w500/5konZnIbcAxZjP616Cz5o9bKEfW.jpg" },

                new Movie { Id = 31, Title = "Psycho", Year = 1960, Rating = 8.5, Director = "Alfred Hitchcock", PosterUrl = "https://image.tmdb.org/t/p/w500/81d8oyEFgj7FlxJqSDXWr8JH8kV.jpg" },
                new Movie { Id = 32, Title = "Joker", Year = 2019, Rating = 8.4, Director = "Todd Phillips", PosterUrl = "https://image.tmdb.org/t/p/w500/udDclJoHjfjb8Ekgsd4FDteOkCU.jpg" },
                new Movie { Id = 33, Title = "Avengers: Infinity War", Year = 2018, Rating = 8.4, Director = "Russo Brothers", PosterUrl = "https://image.tmdb.org/t/p/w500/7WsyChQLEftFiDOVTGkv3hFpyyt.jpg" },
                new Movie { Id = 34, Title = "Avengers: Endgame", Year = 2019, Rating = 8.4, Director = "Russo Brothers", PosterUrl = "https://image.tmdb.org/t/p/w500/or06FN3Dka5tukK1e9sl16pB3iy.jpg" },
                new Movie { Id = 35, Title = "Braveheart", Year = 1995, Rating = 8.3, Director = "Mel Gibson", PosterUrl = "https://image.tmdb.org/t/p/w500/or1gBugydmjToAEq7OZY0owwFk.jpg" },

                new Movie { Id = 36, Title = "The Wolf of Wall Street", Year = 2013, Rating = 8.2, Director = "Martin Scorsese", PosterUrl = "https://image.tmdb.org/t/p/w500/pWHf4khOloNVfCxscsXFj3jj6gP.jpg" },
                new Movie { Id = 37, Title = "Django Unchained", Year = 2012, Rating = 8.4, Director = "Quentin Tarantino", PosterUrl = "https://image.tmdb.org/t/p/w500/7oWY8VDWW7thTzWh3OKYRkWUlD5.jpg" },
                new Movie { Id = 38, Title = "Inglourious Basterds", Year = 2009, Rating = 8.3, Director = "Quentin Tarantino", PosterUrl = "https://image.tmdb.org/t/p/w500/7sfbEnaARXDDhKm0CZ7D7uc2sbo.jpg" },
                new Movie { Id = 39, Title = "Blade Runner 2049", Year = 2017, Rating = 8.0, Director = "Denis Villeneuve", PosterUrl = "https://image.tmdb.org/t/p/w500/gajva2L0rPYkEWjzgFlBXCAVBE5.jpg" },
                new Movie { Id = 40, Title = "The Social Network", Year = 2010, Rating = 7.8, Director = "David Fincher", PosterUrl = "https://image.tmdb.org/t/p/w500/n0ybibhJtQ5icDqTp8eRytcIHJx.jpg" },

                new Movie { Id = 41, Title = "The Revenant", Year = 2015, Rating = 8.0, Director = "Alejandro G. Iñárritu", PosterUrl = "https://image.tmdb.org/t/p/w500/oXUWEc5i3wYyFnL1Ycu8ppxxPvs.jpg" },
                new Movie { Id = 42, Title = "A Beautiful Mind", Year = 2001, Rating = 8.2, Director = "Ron Howard", PosterUrl = "https://image.tmdb.org/t/p/w500/zwzWCmH72OSC9NA0ipoqw5Zjya8.jpg" },
                new Movie { Id = 43, Title = "Shutter Island", Year = 2010, Rating = 8.2, Director = "Martin Scorsese", PosterUrl = "https://image.tmdb.org/t/p/w500/kve20tXwUZpu4GUX8l6X7Z4jmL6.jpg" },
                new Movie { Id = 44, Title = "The Dark Knight Rises", Year = 2012, Rating = 8.4, Director = "Christopher Nolan", PosterUrl = "https://image.tmdb.org/t/p/w500/hr0L2aueqlP2BYUblTTjmtn0hw4.jpg" },
                new Movie { Id = 45, Title = "Logan", Year = 2017, Rating = 8.1, Director = "James Mangold", PosterUrl = "https://image.tmdb.org/t/p/w500/fnbjcRDYn6YviCcePDnGdyAkYsB.jpg" },

                new Movie { Id = 46, Title = "Mad Max: Fury Road", Year = 2015, Rating = 8.1, Director = "George Miller", PosterUrl = "https://image.tmdb.org/t/p/w500/8tZYtuWezp8JbcsvHYO0O46tFbo.jpg" },
                new Movie { Id = 47, Title = "The Truman Show", Year = 1998, Rating = 8.2, Director = "Peter Weir", PosterUrl = "https://image.tmdb.org/t/p/w500/vt1u0lHk3O2Yp6u7p9p6ZxQ5ZbM.jpg" },
                new Movie { Id = 48, Title = "The Big Lebowski", Year = 1998, Rating = 8.1, Director = "Coen Brothers", PosterUrl = "https://image.tmdb.org/t/p/w500/5DxkT6yWEYyFjPZtxe2F0KxL5T4.jpg" },
                new Movie { Id = 49, Title = "No Country for Old Men", Year = 2007, Rating = 8.1, Director = "Coen Brothers", PosterUrl = "https://image.tmdb.org/t/p/w500/6o0fQX0uTzE3C8f6TRf0wK6n6Qx.jpg" },
                new Movie { Id = 50, Title = "There Will Be Blood", Year = 2007, Rating = 8.2, Director = "Paul Thomas Anderson", PosterUrl = "https://image.tmdb.org/t/p/w500/fa0RDkAlCec0STeMNAhPaF89q6C.jpg" }



            };

            builder.Entity<Movie>().HasData(movies);
        }
    }
}
