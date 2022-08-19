using Portfolio.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain
{
    public static class MovieRegister
    {
        public static List<Movie> MovieList = new List<Movie>()
        {
            new Movie("Roundhay Garden Scene", 1888, Category.Documentário, Studio.RoundhayGardenScene),
            new Movie("A Viagem de Chihiro", 2001, Category.Infantil, Studio.StudioGhibli),
            new Movie("Animais Fantásticos e Onde Habitam", 2016, Category.Aventura, Studio.WarnerAnimationGroup),
            new Movie("Animais Fantásticos: Os Crimes de Grindelwald", 2018, Category.Aventura, Studio.WarnerAnimationGroup),
            new Movie("Animais Fantásticos: Os Segredos de Dumbledore", 2022, Category.Aventura, Studio.WarnerAnimationGroup),
            new Movie("Harry Potter e a Câmara Secreta", 2002, Category.Aventura, Studio.WarnerAnimationGroup),
            new Movie("Harry Potter e a Ordem da Fênix", 2007, Category.Aventura, Studio.WarnerAnimationGroup),
            new Movie("Harry Potter e a Pedra Filosofal", 2001, Category.Aventura, Studio.WarnerAnimationGroup),
            new Movie("Harry Potter e as Relíquias da Morte: Parte 1", 2010, Category.Aventura, Studio.WarnerAnimationGroup),
            new Movie("Harry Potter e as Relíquias da Morte: Parte 2", 2011, Category.Aventura, Studio.WarnerAnimationGroup),
            new Movie("Harry Potter e o Cálice de Fogo", 2005, Category.Aventura, Studio.WarnerAnimationGroup),
            new Movie("Harry Potter e o Enigma do Príncipe", 2009, Category.Aventura, Studio.WarnerAnimationGroup),
            new Movie("Harry Potter e o Prisioneiro de Azkaban", 2004, Category.Aventura, Studio.WarnerAnimationGroup),
            new Movie("Interstellar", 2014, Category.FicçãoCientífica, Studio.WarnerAnimationGroup),
            new Movie("Intocáveis", 2011, Category.Drama, Studio.Gaumont),
            new Movie("Kill Bill - Volume 1", 2003, Category.Máfia, Studio.MiramaxFilms),
            new Movie("Kill Bill - Volume 2", 2004, Category.Máfia, Studio.MiramaxFilms),
            new Movie("Meu Amigo Totoro", 1988, Category.Infantil, Studio.StudioGhibli),
            new Movie("O Fabuloso Destino de Amélie Poulain", 2001, Category.ComédiaRomântica, Studio.FoxFilm),
            new Movie("O Hobbit: A Batalha dos Cinco Exércitos", 2014, Category.Fantasia, Studio.ParamountBritish),
            new Movie("O Hobbit: A Desolação de Smaug", 2013, Category.Fantasia, Studio.ParamountBritish),
            new Movie("O Hobbit: Uma Jornada Inesperada", 2012, Category.Fantasia, Studio.ParamountBritish),
            new Movie("O Lobo de Wall Street", 2013, Category.Drama, Studio.ParamountBritish),
            new Movie("O Senhor dos Anéis: A Sociedade do Anel ", 2001, Category.Fantasia, Studio.NewLineCinema),
            new Movie("O Senhor dos Anéis: As Duas Torres", 2002, Category.Fantasia, Studio.NewLineCinema),
            new Movie("O Senhor dos Anéis: O Retorno do Rei", 2003, Category.Fantasia, Studio.NewLineCinema),
            new Movie("O Serviço de Entregas da Kiki", 1989, Category.Infantil, Studio.StudioGhibli),
            new Movie("Star Wars: Episódio I – A Ameaça Fantasma", 1999, Category.FicçãoCientífica, Studio.Lucasfilm),
            new Movie("Star Wars: Episódio II – Ataque dos Clones", 2002, Category.FicçãoCientífica, Studio.Lucasfilm),
            new Movie("Star Wars: Episódio III – A Vingança dos Sith", 2005, Category.FicçãoCientífica, Studio.Lucasfilm),
            new Movie("Star Wars: Episódio IV – Uma Nova Esperança", 1977, Category.FicçãoCientífica, Studio.Lucasfilm),
            new Movie("Star Wars: Episódio IX – A Ascensão Skywalker", 2019, Category.FicçãoCientífica, Studio.WaltDisneyStudios),
            new Movie("Star Wars: Episódio V – O Império Contra-Ataca", 1980, Category.FicçãoCientífica, Studio.Lucasfilm),
            new Movie("Star Wars: Episódio VI - O Retorno de Jedi", 1983, Category.FicçãoCientífica, Studio.Lucasfilm),
            new Movie("Star Wars: Episódio VII – O Despertar da Força", 2015, Category.FicçãoCientífica, Studio.WaltDisneyStudios),
            new Movie("Star Wars: Episódio VIII – Os Últimos Jedi", 2017, Category.FicçãoCientífica, Studio.WaltDisneyStudios),
            new Movie("Tropa de Elite", 2007, Category.Crime, Studio.UniversalPictures),
            new Movie("Tropa de Elite 2: O Inimigo Agora é Outro", 2012, Category.Crime, Studio.ZazenProduções)
        };
    }
}
