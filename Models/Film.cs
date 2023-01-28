using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatr.Models
{
    public class Film:Entity
    {
        public Film[] Films { get; set; } = new Film[2];
        public string? FilmeOnScreen { get; set; }
        public string? FilmsLanguage { get; set; }
        public string? FilmFormat { get; set; }
        public string? FilmCountry { get; set; }
        public string? FilmDirector { get; set; }
        public string? FilmActors { get; set; }
        public string? FilmGenre { get; set; }
        public string FilmDuration { get; set; }
        public string FilmAgeRestrictions { get; set; }
        public string? FilmDescription { get; set; }

        public override string ToString()
        {
            return $"{Films[5]}{FilmeOnScreen}+\"n\" {FilmsLanguage}+\"n\"{FilmFormat}+\"n\"{FilmCountry}+\"n\"{FilmDirector}+\"n\"{FilmActors}+\"n\"{FilmGenre}+\"n\"{FilmDuration}+\"n\"{FilmAgeRestrictions}+\"n\"{FilmDescription}+\"n\"";
        }
    }
}
