using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_basics
{
    class Huur
    {
        public Movie Movie { get; set; }
        public int AantalDagen { get; set; }
        public Huur(Movie movie, int aantalDagen)
        {
            Movie = movie;
            AantalDagen = aantalDagen;
        }
        public double GetPrice()
        {
            return Movie.GetPrice(AantalDagen);
        }
    }
}
