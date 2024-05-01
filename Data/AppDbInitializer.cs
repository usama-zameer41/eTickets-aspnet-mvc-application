using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name="Cinema 1",
                            CinemaLogoURL="http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description="This is the description of Cinema 1"
                        },
                        new Cinema()
                        {
                            Name="Cinema 2",
                            CinemaLogoURL="http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description="This is the description of Cinema 2"
                        },
                        new Cinema()
                        {
                            Name="Cinema 3",
                            CinemaLogoURL="http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description="This is the description of Cinema 3"
                        },
                        new Cinema()
                        {
                            Name="Cinema 4",
                            CinemaLogoURL="http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description="This is the description of Cinema 4"
                        },
                        new Cinema()
                        {
                            Name="Cinema 5",
                            CinemaLogoURL="http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description="This is the description of Cinema 5"
                        },
                    });
                    context.SaveChanges();
                }

                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>() 
                    {
                        new Actor()
                        {
                            FullName="Actor 1",
                            Bio = "This is the Bio of Actor 1",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor()
                        {
                            FullName="Actor 2",
                            Bio = "This is the Bio of Actor 2",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName="Actor 3",
                            Bio = "This is the Bio of Actor 3",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName="Actor 4",
                            Bio = "This is the Bio of Actor 4",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName="Actor 5",
                            Bio = "This is the Bio of Actor 5",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName="Producer 1",
                            Bio = "This is the Bio of Producer 1",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Producer()
                        {
                            FullName="Producer 2",
                            Bio = "This is the Bio of Producer 2",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName="Producer 3",
                            Bio = "This is the Bio of Producer 3",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName="Producer 4",
                            Bio = "This is the Bio of Producer 4",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName="Producer 5",
                            Bio = "This is the Bio of Producer 5",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description="Life Movie description",
                            price= 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            MovieCategory = Enums.MovieCategory.Documentary,
                            CinemaId = 3,
                            ProducerId = 3
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "The Shawshank Redemption",
                            price = 29.9,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = Enums.MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "Ghost Description",
                            price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = Enums.MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "Race Movie Description",
                            price = 39.50,
                            ImageURL="http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = Enums.MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "Scoob movie dscription.",
                            price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = Enums.MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is Cold Soles description.",
                            price = 39.50,
                            ImageURL="http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = Enums.MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }

                //Actors_Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            MovieId = 1,
                            ActorId = 1,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 1,
                            ActorId = 3,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 2,
                            ActorId = 1,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 2,
                            ActorId = 4,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 3,
                            ActorId = 1,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 3,
                            ActorId = 2,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 3,
                            ActorId = 5,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 4,
                            ActorId = 2,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 4,
                            ActorId = 3,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 4,
                            ActorId = 4,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 5,
                            ActorId = 2,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 5,
                            ActorId = 3,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 5,
                            ActorId = 4,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 5,
                            ActorId = 5,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 6,
                            ActorId = 3,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 6,
                            ActorId = 4,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 6,
                            ActorId = 5,
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
