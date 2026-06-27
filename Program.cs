using Spativy;
using System.Collections.Generic;

Nummer nummer1 = new Nummer("HUMBLE.", "Kendrick Lamar", "Rap");
Nummer nummer2 = new Nummer("DNA.", "Kendrick Lamar", "Rap");
Nummer nummer3 = new Nummer("Stronger", "Kanye West", "Rap");
Nummer nummer4 = new Nummer("Flashing lights", "Kanye West", "Rap");
Nummer nummer5 = new Nummer("Skeletons", "Travis Scott", "Trap");
Nummer nummer6 = new Nummer("Sicko Mode", "Travis Scott", "Trap");
Nummer nummer7 = new Nummer("Ensalada", "Freddie Gibbs & The alchemist", "Soulfull hip-hop");
Nummer nummer8 = new Nummer("Skinny Suge 2", "Freddie Gibbs & The alchemist", "Soulfull hip-hop");
Nummer nummer9 = new Nummer("Not like us", "Kendrick Lamar", "Rap");
Nummer nummer10 = new Nummer("Mercy", "Kanye West", "Rap");

List<Nummer> nummers = new List<Nummer>();
nummers.Add(nummer1);
nummers.Add(nummer2);
nummers.Add(nummer3);
nummers.Add(nummer4);
nummers.Add(nummer5);
nummers.Add(nummer6);
nummers.Add(nummer7);
nummers.Add(nummer8);
nummers.Add(nummer9);
nummers.Add(nummer10);

Album album = new Album(
   "DAMN.",
   "Kendrick Lamar",
   new List<Nummer> { nummer1, nummer2 });

Album album2 = new Album(
    "Graduation",
    "Kanye West",
    new List<Nummer> { nummer3, nummer4 });

Album album3 = new Album(
    "AstroWorld",
    "Travis Scott",
    new List<Nummer> {nummer5, nummer6 });
Album album4 = new Album(
    "Alfredo 2",
    "Freddie Gibbs & The alchemist",
    new List<Nummer> { nummer7, nummer8 });

List<Album> albums = new List<Album>();
albums.Add(album);
albums.Add(album2);
albums.Add(album3);
albums.Add(album4);

List<Artiest> artiesten = new List<Artiest>();
artiesten.Add(new Artiest("Kendrick Lamar", new List<Album> { album }, new List<Nummer> { nummer9 }));
artiesten.Add(new Artiest("Kanye West", new List<Album> { album2 }, new List<Nummer> { nummer10 }));
artiesten.Add(new Artiest("Travis Scott", new List<Album> { album3 }, new List<Nummer>()));
artiesten.Add(new Artiest("Freddie Gibbs & The alchemist", new List<Album> { album4 }, new List<Nummer>()));

List<Afspeelijst> afspeellijsten = new List<Afspeelijst>();

Gebruiker gebruiker1 = new Gebruiker("test gebruiker", nummers, albums, afspeellijsten);
Gebruiker gebruiker2 = new Gebruiker("Aleks", nummers, albums, new List<Afspeelijst>());
Gebruiker gebruiker3 = new Gebruiker("Tester3", nummers, albums, new List<Afspeelijst>());


Gebruiker hoofdgebruiker = gebruiker1;
List<Gebruiker> gebruikers = new List<Gebruiker>();
gebruikers.Add(gebruiker1);
gebruikers.Add(gebruiker2);
gebruikers.Add(gebruiker3);
Afspeelijst afspeelijstAleks = new Afspeelijst("Aleks zijn lijst", gebruiker2.NaamGebruiker, new List<Nummer> { nummer3, nummer4 });
gebruiker2.Afspeellijsten.Add(afspeelijstAleks);
Afspeelijst afspeelijstTester3 = new Afspeelijst("Good vibes", gebruiker3.NaamGebruiker, new List<Nummer> { nummer1, nummer2});
gebruiker3.Afspeellijsten.Add(afspeelijstTester3);
Client client = new Client();

client.InputGever(nummers, albums, artiesten, afspeellijsten, gebruikers, hoofdgebruiker);