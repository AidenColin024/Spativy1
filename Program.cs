using Spativy;
using System.Collections.Generic;

Nummer nummer1 = new Nummer("HUMBLE.", "Kendrick Lamar", "Rap");
Nummer nummer2 = new Nummer("DNA.", "Kendrick Lamar", "Rap");
Nummer nummer3 = new Nummer("Stronger", "Kanye West", "Rap");
Nummer nummer4 = new Nummer("Flashing lights", "Kanye West", "Rap");

List<Nummer> nummers = new List<Nummer>();
nummers.Add(nummer1);
nummers.Add(nummer2);
nummers.Add(nummer3);
nummers.Add(nummer4);

Album album = new Album(
   "DAMN.",
   "Kendrick Lamar",
   new List<Nummer> { nummer1, nummer2 });

Album album2 = new Album(
    "Graduation",
    "Kanye West",
    new List<Nummer> { nummer3, nummer4 }
);

List<Album> albums = new List<Album>();
albums.Add(album);
albums.Add(album2);

List<Artiest> artiesten = new List<Artiest>();
artiesten.Add(new Artiest("Kendrick Lamar"));
artiesten.Add(new Artiest("Kanye West"));

Afspeelijst afspeelijst1 = new Afspeelijst(
    "Favorieten",
    "Hoofdgebruiker",
    new List<Nummer> { nummer1, nummer3 }
);

List<Afspeelijst> afspeellijsten = new List<Afspeelijst>();
afspeellijsten.Add(afspeelijst1);

Client client = new Client();

client.InputGever(nummers, albums, artiesten, afspeellijsten);