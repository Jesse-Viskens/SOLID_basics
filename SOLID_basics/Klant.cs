using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_basics
{
    class Klant
    {
        List<Huur> movies = new List<Huur>();
        public string Naam { get; set; }
        public Klant(string naam)
        {
            Naam = naam;
        }

        public void AddMovie(Huur huur)
        {
            movies.Add(huur);
        }

        public string GetRekening()
        {
            double totalAmount = 0;

            string result = "Huur Record for " + Naam + "\n";

            foreach (Huur h in movies)
            {
                double thisAmount = 0;

                switch (h.Movie.PriceCode)
                {
                    case Movie.REGULAR:
                        thisAmount += 2;
                        if (h.AantalDagen > 2)
                        {
                            thisAmount += (h.AantalDagen - 2) * 1.5;
                        }
                        break;

                    case Movie.NEW_RELEASE:
                        thisAmount += h.AantalDagen * 3;
                        break;

                    case Movie.CHILDREN:
                        thisAmount += 1.5;
                        if (h.AantalDagen > 3)
                        {
                            thisAmount += (h.AantalDagen - 3) * 1.2;
                        }
                        break;
                }

                //Show figures for this rental 
                result += "\t" + h.Movie.Title + "\t" + thisAmount.ToString() + "\n";
                totalAmount += thisAmount;
            }

            //Add footer lines 
            result += "Amount owned is " + totalAmount.ToString() + "\n";

            return result;
        }
    }
}
