using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Enum
{
    public enum Category
    {
        [Description("Ação")] Ação,
        [Description("Aventura")] Aventura,
        [Description("Biográfico")] Biográfico,
        [Description("Cinema de arte")] CinemaDearte,
        [Description("Comédia")] Comédia,
        [Description("Comédia dramática")] ComédiaDramática,
        [Description("Comédia romântica")] ComédiaRomântica,
        [Description("Crime")] Crime,
        [Description("Dança")] Dança,
        [Description("Documentário")] Documentário,
        [Description("Drama")] Drama,
        [Description("Espionagem")] Espionagem,
        [Description("Fantasia")] Fantasia,
        [Description("Fantasia científica")] FantasiaCientífica,
        [Description("Faroeste")] Faroeste,
        [Description("Ficção científica")] FicçãoCientífica,
        [Description("Filmes de guerra")] FilmesDeGuerra,
        [Description("Infantil")] Infantil,
        [Description("Máfia")] Máfia,
        [Description("Mistério")] Mistério,
        [Description("Musical")] Musical,
        [Description("Romance")] Romance,
        [Description("Suspense")] Suspense,
        [Description("Terror")] Terror
    }
}
