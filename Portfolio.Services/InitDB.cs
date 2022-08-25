using Portfolio.Domain;
using Portfolio.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;


namespace Portfolio.Services
{
    public static class InitDB
    {
        public static void NewUsers(IUserRepository userRepository)
        {
            User newUser1 = new("Luiza Campello", "luizacampello", DateTime.Parse("19/04/1996"), "123");
            userRepository.AddNewUser(newUser1);

            User newUser2 = new("Severo Snape", "halfBloodPrince", DateTime.Parse("09/01/1960"), "123");
            userRepository.AddNewUser(newUser2);

            User newUser3 = new("r", "r", DateTime.Parse("09/01/1960"), "1");
            userRepository.AddNewUser(newUser3);

        }

        public static void NewScores(IUserRepository userRepository, IPortfolioService portfolioService, IMovieRepository movieRepository)
        {

            Review newScore1 = new(movieRepository.GetMovie("Roundhay Garden Scene"), Star.Three);
            Review newScore2 = new(movieRepository.GetMovie("A Viagem de Chihiro"), Star.Four);
            Review newScore3 = new(movieRepository.GetMovie("Star Wars: Episódio VIII – Os Últimos Jedi"), Star.Four, "Nem é tão ruim assim, a galera reclama muito");
            
            User user1 = userRepository.GetUser("luizacampello");
            User user2 = userRepository.GetUser("halfBloodPrince");
            User user3 = userRepository.GetUser("r");

            portfolioService.AddReviewToPortfolio(user1, newScore1);
            portfolioService.AddReviewToPortfolio(user1, newScore2);
            portfolioService.AddReviewToPortfolio(user1, newScore3);
            portfolioService.AddReviewToPortfolio(user1, newScore3);
            portfolioService.AddReviewToPortfolio(user1, newScore1);
            portfolioService.AddReviewToPortfolio(user1, newScore2);
            portfolioService.AddReviewToPortfolio(user1, newScore3);
            portfolioService.AddReviewToPortfolio(user1, newScore3);

            portfolioService.AddReviewToPortfolio(user2, newScore1);
            portfolioService.AddReviewToPortfolio(user2, newScore2);

            portfolioService.AddReviewToPortfolio(user3, newScore1);
            portfolioService.AddReviewToPortfolio(user3, newScore2);
            portfolioService.AddReviewToPortfolio(user3, newScore3);

        }

        public static void AddMovies(IMovieRepository movieRepository)
        {
            movieRepository.AddMovie(new Movie("Roundhay Garden Scene", 1888, Category.Documentário, Studio.RoundhayGardenScene));
            movieRepository.AddMovie(new Movie("A Viagem de Chihiro", 2001, Category.Infantil, Studio.StudioGhibli));
            movieRepository.AddMovie(new Movie("Animais Fantásticos e Onde Habitam", 2016, Category.Aventura, Studio.WarnerAnimationGroup));
            movieRepository.AddMovie(new Movie("Animais Fantásticos: Os Crimes de Grindelwald", 2018, Category.Aventura, Studio.WarnerAnimationGroup));
            movieRepository.AddMovie(new Movie("Animais Fantásticos: Os Segredos de Dumbledore", 2022, Category.Aventura, Studio.WarnerAnimationGroup));
            movieRepository.AddMovie(new Movie("Harry Potter e a Câmara Secreta", 2002, Category.Aventura, Studio.WarnerAnimationGroup));
            movieRepository.AddMovie(new Movie("Harry Potter e a Ordem da Fênix", 2007, Category.Aventura, Studio.WarnerAnimationGroup));
            movieRepository.AddMovie(new Movie("Harry Potter e a Pedra Filosofal", 2001, Category.Aventura, Studio.WarnerAnimationGroup));
            movieRepository.AddMovie(new Movie("Harry Potter e as Relíquias da Morte: Parte 1", 2010, Category.Aventura, Studio.WarnerAnimationGroup));
            movieRepository.AddMovie(new Movie("Harry Potter e as Relíquias da Morte: Parte 2", 2011, Category.Aventura, Studio.WarnerAnimationGroup));
            movieRepository.AddMovie(new Movie("Harry Potter e o Cálice de Fogo", 2005, Category.Aventura, Studio.WarnerAnimationGroup));
            movieRepository.AddMovie(new Movie("Harry Potter e o Enigma do Príncipe", 2009, Category.Aventura, Studio.WarnerAnimationGroup));
            movieRepository.AddMovie(new Movie("Harry Potter e o Prisioneiro de Azkaban", 2004, Category.Aventura, Studio.WarnerAnimationGroup));
            movieRepository.AddMovie(new Movie("Interstellar", 2014, Category.FicçãoCientífica, Studio.WarnerAnimationGroup));
            movieRepository.AddMovie(new Movie("Intocáveis", 2011, Category.Drama, Studio.Gaumont));
            movieRepository.AddMovie(new Movie("Kill Bill - Volume 1", 2003, Category.Máfia, Studio.MiramaxFilms));
            movieRepository.AddMovie(new Movie("Kill Bill - Volume 2", 2004, Category.Máfia, Studio.MiramaxFilms));
            movieRepository.AddMovie(new Movie("Meu Amigo Totoro", 1988, Category.Infantil, Studio.StudioGhibli));
            movieRepository.AddMovie(new Movie("O Fabuloso Destino de Amélie Poulain", 2001, Category.ComédiaRomântica, Studio.FoxFilm));
            movieRepository.AddMovie(new Movie("O Hobbit: A Batalha dos Cinco Exércitos", 2014, Category.Fantasia, Studio.ParamountBritish));
            movieRepository.AddMovie(new Movie("O Hobbit: A Desolação de Smaug", 2013, Category.Fantasia, Studio.ParamountBritish));
            movieRepository.AddMovie(new Movie("O Hobbit: Uma Jornada Inesperada", 2012, Category.Fantasia, Studio.ParamountBritish));
            movieRepository.AddMovie(new Movie("O Lobo de Wall Street", 2013, Category.Drama, Studio.ParamountBritish));
            movieRepository.AddMovie(new Movie("O Senhor dos Anéis: A Sociedade do Anel ", 2001, Category.Fantasia, Studio.NewLineCinema));
            movieRepository.AddMovie(new Movie("O Senhor dos Anéis: As Duas Torres", 2002, Category.Fantasia, Studio.NewLineCinema));
            movieRepository.AddMovie(new Movie("O Senhor dos Anéis: O Retorno do Rei", 2003, Category.Fantasia, Studio.NewLineCinema));
            movieRepository.AddMovie(new Movie("O Serviço de Entregas da Kiki", 1989, Category.Infantil, Studio.StudioGhibli));
            movieRepository.AddMovie(new Movie("Star Wars: Episódio I – A Ameaça Fantasma", 1999, Category.FicçãoCientífica, Studio.Lucasfilm));
            movieRepository.AddMovie(new Movie("Star Wars: Episódio II – Ataque dos Clones", 2002, Category.FicçãoCientífica, Studio.Lucasfilm));
            movieRepository.AddMovie(new Movie("Star Wars: Episódio III – A Vingança dos Sith", 2005, Category.FicçãoCientífica, Studio.Lucasfilm));
            movieRepository.AddMovie(new Movie("Star Wars: Episódio IV – Uma Nova Esperança", 1977, Category.FicçãoCientífica, Studio.Lucasfilm));
            movieRepository.AddMovie(new Movie("Star Wars: Episódio IX – A Ascensão Skywalker", 2019, Category.FicçãoCientífica, Studio.WaltDisneyStudios));
            movieRepository.AddMovie(new Movie("Star Wars: Episódio V – O Império Contra-Ataca", 1980, Category.FicçãoCientífica, Studio.Lucasfilm));
            movieRepository.AddMovie(new Movie("Star Wars: Episódio VI - O Retorno de Jedi", 1983, Category.FicçãoCientífica, Studio.Lucasfilm));
            movieRepository.AddMovie(new Movie("Star Wars: Episódio VII – O Despertar da Força", 2015, Category.FicçãoCientífica, Studio.WaltDisneyStudios));
            movieRepository.AddMovie(new Movie("Star Wars: Episódio VIII – Os Últimos Jedi", 2017, Category.FicçãoCientífica, Studio.WaltDisneyStudios));
            movieRepository.AddMovie(new Movie("Tropa de Elite", 2007, Category.Crime, Studio.UniversalPictures));
            movieRepository.AddMovie(new Movie("Tropa de Elite 2: O Inimigo Agora é Outro", 2012, Category.Crime, Studio.ZazenProduções));
        }
    }
}
