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


        public void InputGever(List<Nummer> nummers, List<Album> albums, List<Artiest> artiesten, List<Afspeelijst> afspeelijst, List<Gebruiker> gebruikers, Gebruiker hoofdgebruiker)
        {
            String input = "";

            while (input != "0")
            {
                Console.WriteLine("Welkom bij Spativy\n ");
                Console.WriteLine("Druk op 1 om een nummer af te spelen.\n");
                Console.WriteLine("Druk op 2 om een nummer te stoppen.\n");
                Console.WriteLine("Druk op 3 om een nummer over te slaan.\n");
                Console.WriteLine("Druk op 4 om albums in te zien.\n");
                Console.WriteLine("Druk op 5 om een album af te spelen.\n");
                Console.WriteLine("Druk op 6 om artiesten in te zien.\n");
                Console.WriteLine("Druk op 7 om een afspeelijst aan te maken.\n");
                Console.WriteLine("Druk op 8 om je afspeelijsten te zien.\n");
                Console.WriteLine("Druk op 9 om een nummer aan een lijst toe te voegen.\n");
                Console.WriteLine("Druk op 10 om een nummer te verwijderen.\n");
                Console.WriteLine("Druk op 11 om een afspeellijst af te spelen.\n");
                Console.WriteLine("Druk op 12 om andere gebruikers te zien.\n");
                Console.WriteLine("Druk op 13 om een gebruiker toe te voegen.\n");
                Console.WriteLine("Druk op 14 om een vriend te verwijderen\n");
                Console.WriteLine("Druk op 15 om je vriendenlijst te zien\n");
                Console.WriteLine("Druk op 0 om af te sluiten.\n");

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
                else if (input == "10")
                {
                    NummerVerwijderen(afspeelijst, nummers);
                }
                else if (input == "11")
                {
                    if (afspeelijst.Count > 0)
                    {
                        SpeelAfspeelijst(afspeelijst);
                    }
                    else
                    {
                        Console.WriteLine("Er zijn geen afspeellijsten.");
                    }
                }
                else if (input == "12")
                {
                    GebruikerInzien(gebruikers);
                }
                else if (input == "13")
                {
                    GebruikersToevoegen(gebruikers, hoofdgebruiker);
                }
                else if (input == "14")
                {
                    GebruikerVerwijderen(hoofdgebruiker);
                }
                else if (input == "15")
                {
                    VriendenInzien(hoofdgebruiker);
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

        public void NummerToevoegen(List<Afspeelijst> afspeellijsten, List<Nummer> nummers)
        {
            if (afspeellijsten.Count == 0)
            {
                Console.WriteLine("Er is geen lijst");
                return;
            }

            Console.WriteLine("Kies een lijst om een nummer aan toe te voegen:");

            for (int i = 0; i < afspeellijsten.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + afspeellijsten[i].TitelAfspeelijst);
            }

            int keuzeLijst = int.Parse(Console.ReadLine());

            Afspeelijst gekozenLijst = afspeellijsten[keuzeLijst - 1];

            Console.WriteLine("Kies een nummer:");

            for (int i = 0; i < nummers.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + nummers[i].Titel);
            }

            int keuzeNummer = int.Parse(Console.ReadLine());

            Nummer gekozenNummer = nummers[keuzeNummer - 1];

            gekozenLijst.Nummers.Add(gekozenNummer);

            Console.WriteLine("Nummer toegevoegd.");
        }

        public void NummerVerwijderen(List<Afspeelijst> afspeellijsten, List<Nummer> nummers)
        {
            if (afspeellijsten.Count == 0)
            {
                Console.WriteLine("Er zijn geen afspeellijsten.");
                return;
            }

            Console.WriteLine("Kies een lijst:");

            for (int i = 0; i < afspeellijsten.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + afspeellijsten[i].TitelAfspeelijst);
            }

            int keuzeLijst = int.Parse(Console.ReadLine());

            Afspeelijst gekozenLijst = afspeellijsten[keuzeLijst - 1];

            if (gekozenLijst.Nummers.Count == 0)
            {
                Console.WriteLine("Deze afspeellijst bevat geen nummers.");
                return;
            }

            Console.WriteLine("Kies een nummer om te verwijderen:");

            for (int i = 0; i < gekozenLijst.Nummers.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + gekozenLijst.Nummers[i].Titel);
            }

            int keuzeNummer = int.Parse(Console.ReadLine());

            Nummer gekozenNummer = gekozenLijst.Nummers[keuzeNummer - 1];

            gekozenLijst.Nummers.Remove(gekozenNummer);

            Console.WriteLine("Het nummer is verwijderd.");
        }
        public void SpeelAfspeelijst(List<Afspeelijst> afspeellijsten)
        {
            Console.WriteLine("Kies een lijst:");

            for (int i = 0; i < afspeellijsten.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + afspeellijsten[i].TitelAfspeelijst);
            }

            int keuze = int.Parse(Console.ReadLine());
            Afspeelijst gekozen = afspeellijsten[keuze - 1];

            if (gekozen.Nummers.Count == 0)
            {
                Console.WriteLine("De afspeellijst is leeg.");
                return;
            }

            foreach (Nummer nummer in gekozen.Nummers)
            {
                Console.WriteLine("Speelt: " + nummer.Titel +
                                  " Van " + nummer.Artiest +
                                  " Genre: " + nummer.Genre);

                Console.WriteLine("Druk op 2 om te stoppen.");
                Console.WriteLine("Druk op 3 om over te slaan.");

                String input = Console.ReadLine();

                if (input == "2")
                {
                    Console.WriteLine("Afspeellijst gestopt.");
                    return;
                }

                if (input == "3")
                {
                    continue;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Afspeellijst afgelopen.");
        }

        public void GebruikerInzien(List <Gebruiker> gebruikers)
        {
            if (gebruikers.Count == 0)
            {
                Console.WriteLine("Er zijn geen gebruikers.");
                return;
            }

            foreach (Gebruiker gebruiker in gebruikers)
            {
                Console.WriteLine("Gebruiker: " + gebruiker.NaamGebruiker);
            }

            Console.WriteLine();
        }

        public void GebruikersToevoegen(List<Gebruiker> gebruikers, Gebruiker hoofdgebruiker)
        {
            if (gebruikers.Count == 0)
            {
                Console.WriteLine("Er zijn geen gebruikers");
                return;
            }

            Console.WriteLine("Kies een gebruiker om toe te voegen:");

            for (int i = 0; i < gebruikers.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + gebruikers[i].NaamGebruiker);
            }

            int ToevoegenGebruiker = int.Parse(Console.ReadLine());

            Gebruiker gekozenGebruiker = gebruikers[ToevoegenGebruiker - 1];

            hoofdgebruiker.Vrienden.Add(gekozenGebruiker);

            Console.WriteLine("Gebruiker toegevoegd.");
        }

        public void GebruikerVerwijderen(Gebruiker hoofdgebruiker)
        {
            if (hoofdgebruiker.Vrienden.Count == 0)
            {
                Console.WriteLine("Er staan geen vriende in je vriendelijst.");
                return;
            }

            Console.WriteLine("Kies een vriend om te verwijderen:");

            for (int i = 0; i < hoofdgebruiker.Vrienden.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + hoofdgebruiker.Vrienden[i].NaamGebruiker);
            }

            int keuzeLijst = int.Parse(Console.ReadLine());

            Gebruiker gekozengebruiker = hoofdgebruiker.Vrienden[keuzeLijst - 1];

            hoofdgebruiker.Vrienden.Remove(gekozengebruiker);

            Console.WriteLine("Je vriend is verwijderd.");
        }

        public void VriendenInzien(Gebruiker hoofdgebruiker)
        {
            if (hoofdgebruiker.Vrienden.Count == 0)
            {
                Console.WriteLine("Je hebt geen vrienden.");
                return;
            }

            foreach (Gebruiker vriend in hoofdgebruiker.Vrienden)
            {
                Console.WriteLine("Je vriend: " + vriend.NaamGebruiker);
            }

            Console.WriteLine();
        }
    }

}