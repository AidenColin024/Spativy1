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
                              " druk op 2 om het nummer te stoppen. Druk op 3 om het nummer over te slaan.");
            Console.WriteLine();

            String input = Console.ReadLine();

            if (input == "2")
            {
                StopNummer(nummer);
            }
            else if (input == "3")
            {
                SlaOver(nummer);
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


        public void InputGever(List<Nummer> nummers, List<Album> albums, List<Artiest> artiesten, List<Afspeelijst> afspeelijst)
        {
            String input = "";

            while (input != "0")
            {
                Console.WriteLine("Welkom bij Spativy ");
                Console.WriteLine("Druk op 1 om een nummer af te spelen.");
                Console.WriteLine("Druk op 2 om een nummer te stoppen.");
                Console.WriteLine("Druk op 3 om een nummer over te slaan.");
                Console.WriteLine("Druk op 4 om albums in te zien.");
                Console.WriteLine("Druk op 5 om een album af te spelen.");
                Console.WriteLine("Druk op 6 om artiesten in te zien.");
                Console.WriteLine("Druk op 7 om een afspeelijst aan te maken.");
                Console.WriteLine("Druk op 8 om je afspeelijsten te zien.");
                Console.WriteLine("Druk op 9 om een nummer aan een lijst toe te voegen.");
                Console.WriteLine("Druk op 0 om af te sluiten.");

                input = Console.ReadLine();

                if (input == "1")
                {
                    SpeelNummer(nummers[0]);
                }
                else if (input == "2")
                {
                    StopNummer(nummers[0]);
                }
                else if (input == "3")
                {
                    SlaOver(nummers[0]);
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
                else if (input == "6")
                {
                    foreach (Artiest artiest in artiesten)
                    {
                        Console.WriteLine(artiest.Naam);
                    }
                }
                else if (input == "7")
                {
                    AfspeelijstAanmaken(afspeelijst);
                }
                else if (input == "8")
                {
                    AfspeelijstInzien(afspeelijst);
                }
                else if (input == "9")
                {
                    NummerToevoegen(afspeelijst, nummers);
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


        public void InzienArtiesten(List<Artiest> artiesten)
        {
            if (artiesten.Count == 0)
            {
                Console.WriteLine("Er zijn geen artiesten beschikbaar.");
                return;
            }

            foreach (Artiest artiest in artiesten)
            {
                Console.WriteLine("Artiest: " + artiest.Naam);
            }

            Console.WriteLine();
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

        public void AfspeelijstAanmaken(List<Afspeelijst> afspeellijsten)
        {
            Console.WriteLine("Maak een titel voor je afspeelijst.");
           String titelafspeelijst = Console.ReadLine();
            Console.WriteLine("Van wie is deze lijst?");
            String naamgebruiker = Console.ReadLine();
            Console.WriteLine("Je afspeelijst: "+ titelafspeelijst +" van "+ naamgebruiker + " is aangemaakt.");
            Afspeelijst nieuweAfspeelijst = new Afspeelijst(titelafspeelijst, naamgebruiker, new List<Nummer>());
            afspeellijsten.Add(nieuweAfspeelijst);
        }

        public void AfspeelijstInzien(List<Afspeelijst> afspeellijsten)
        {
            foreach (Afspeelijst afspeelijst in afspeellijsten)
            {
                Console.WriteLine("Afspeelijsten:\n " + afspeelijst.TitelAfspeelijst + " Van " + afspeelijst.NaamGebruiker);

                foreach (Nummer nummer in afspeelijst.Nummers)
                {
                    Console.WriteLine("- " + nummer.Titel);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void NummerToevoegen(List<Afspeelijst> afspeellijsten,List<Nummer> nummers)
        {
            if (afspeellijsten.Count == 0)
            {
                Console.WriteLine("Er is geen lijst");
                return;
            }

            Console.WriteLine("Kies een lijst om een nummer aan toe te voegen.");

            foreach (Afspeelijst afspeellijst in afspeellijsten)
            {
                Console.WriteLine(afspeellijst.TitelAfspeelijst);
            }

            string gekozenLijst = Console.ReadLine();

            foreach (Afspeelijst afspeellijst in afspeellijsten)
            {
                if (afspeellijst.TitelAfspeelijst == gekozenLijst)
                {
                    Console.WriteLine("Kies een nummer:");

                    foreach (Nummer nummer in nummers)
                    {
                        Console.WriteLine(nummer.Titel);
                    }

                    string gekozenNummer = Console.ReadLine();

                    foreach (Nummer nummer in nummers)
                    {
                        if (nummer.Titel == gekozenNummer)
                        {
                            afspeellijst.Nummers.Add(nummer);
                            Console.WriteLine("Nummer toegevoegd.");
                        }
                    }
                }
            }
        }
    }
}