using System.Globalization;
using Teatr.Models;

namespace Teatr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";

            do
            {
                Console.Write("Choose Film: ");
                command = Console.ReadLine();
                if (command.ToLower().Equals("Choose Film: "))
                {
                    var Film = new Film
                    {
                        Id = 1,
                        Name="Titanic",
                        FilmeOnScreen = "until 22 aprel 2023",
                        FilmsLanguage = "English",
                        FilmFormat = "Aze subtitles",
                        FilmCountry = "USA,Mexico",
                        FilmDirector = "James Cameron",
                        FilmActors = "Leonardo DiCaprio, Kate Winslet, Billy Zane",
                        FilmGenre = "melodrama, history, thriller, drama",
                        FilmDuration ="210 minutes",
                        FilmAgeRestrictions = "12+",
                        FilmDescription = "{On the first and last voyage of the luxurious Titanic, two people meet.}+\n" +
                        "{Lower deck passenger Jack has won a card ticket, and wealthy heiress Rose is on her way to America to marry of convenience.}+\n",
                    };

                    var Film2 = new Film
                    {
                        Id = 2,
                        Name = "Avatar 2",
                        FilmeOnScreen = "until 15 february 2023",
                        FilmsLanguage = "English",
                        FilmFormat = "2D and Aze subtitles",
                        FilmCountry = "USA",
                        FilmDirector = "James Cameron",
                        FilmActors = "Mişel Yeo, Zoi Saldana, Keyt Uinslet",
                        FilmGenre = "fantasy, action, thriller",
                        FilmDuration = "210 minutes",
                        FilmAgeRestrictions = "12+",
                        FilmDescription = "{Jake Sully lives with his newfound family formed on the planet of Pandora.}+\n"+
                        "{Once a familiar threat returns to finish what was previously started, Jake must work with Neytiri and the army of the Na'vi race to protect their planet}+\n",
                    

                     };

                } 
            } while (command.ToLower() != "quit");


        }
     }
  }
                
               




