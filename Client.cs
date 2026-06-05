using System;
using System.Collections.Generic;
using System.Text;

namespace Spativy
{
    internal class Client
    {
        public Nummer Nummer { get; set; }

        public void SpeelNummer(Nummer nummer)
        {
            Console.WriteLine("Speelt: " + nummer.Titel +
                              " Van " + nummer.Artiest +
                              " Genre: " + nummer.Genre +
                              " druk op 2 om het nummer te stoppen.");
            Console.WriteLine();

            String input = Console.ReadLine();

            if (input == "2")
            {
                StopNummer(nummer);
            }
        }

        public void StopNummer(Nummer nummer)
        {
            Console.WriteLine("Het nummer is gestopt");
            Console.WriteLine();
        }

        public void SlaOver(Nummer nummer)
        {
            SpeelNummer(nummer);
        }

        public void InputGever(Nummer nummer, List<Album> albums)
        {
            Console.WriteLine("Welkom bij Spativy ");
            Console.WriteLine("Druk op 1 om een nummer af te spelen.");
            Console.WriteLine("Druk op 2 om een nummer te stoppen.");
            Console.WriteLine("Druk op 3 om een nummer over te slaan.");
            Console.WriteLine("Druk op 4 om albums in te zien.");
            Console.WriteLine("Druk op 5 om een album af te spelen.");

            String input = Console.ReadLine();

            while (input != "1" &&
                   input != "2" &&
                   input != "3" &&
                   input != "4" &&
                   input != "5")
            {
                Console.WriteLine("druk op een geldige toets");
                input = Console.ReadLine();
            }

            if (input == "1")
            {
                SpeelNummer(nummer);
            }
            else if (input == "2")
            {
                StopNummer(nummer);
            }
            else if (input == "3")
            {
                SlaOver(nummer);
            }
            else if (input == "4")
            {
                InzienAlbum(albums);
            }
            else if (input == "5")
            {
                if (albums.Count > 0)
                {
                    SpeelAlbum(albums[0]);
                }
                else
                {
                    Console.WriteLine("Er zijn geen albums beschikbaar.");
                }
            }
        }

        public void InzienAlbum(List<Album> albums)
        {
            if (albums.Count == 0)
            {
                Console.WriteLine("Er zijn geen albums beschikbaar.");
                return;
            }

            foreach (Album album in albums)
            {
                Console.WriteLine("Album: " + album.Titel);
                Console.WriteLine("Artiest: " + album.Artiest);

                foreach (Nummer nummer in album.Nummers)
                {
                    Console.WriteLine("- " + nummer.Titel);
                }

                Console.WriteLine();
            }
        }

        public void SpeelAlbum(Album album)
        {
            if (album.Nummers.Count == 0)
            {
                Console.WriteLine("Dit album bevat geen nummers.");
                return;
            }

            Console.WriteLine("Album gestart: " + album.Titel);
            Console.WriteLine();

            foreach (Nummer nummer in album.Nummers)
            {
                Console.WriteLine("Speelt: " + nummer.Titel +
                                  " Van " + nummer.Artiest +
                                  " Genre: " + nummer.Genre);

                Console.WriteLine("Druk op 3 om dit nummer over te slaan.");
                String input = Console.ReadLine();

                if (input == "3")
                {
                    continue;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Album afgelopen.");
        }
    }
}