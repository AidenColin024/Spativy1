using Spativy;
using System.Collections.Generic;

Nummer nummer1 = new Nummer("HUMBLE.", "Kendrick Lamar", "Rap");
Nummer nummer2 = new Nummer("DNA.", "Kendrick Lamar", "Rap");


Afspeelijst afspeelijst = new Afspeelijst();

Album album = new Album(
   "DAMN.",
   "Kendrick Lamar",
   new List<Nummer> { nummer1, nummer2 });

List<Album> albums = new List<Album>();
albums.Add(album);

List<Artiest> artiesten = new List<Artiest>();
artiesten.Add(new Artiest("Kendrick Lamar"));

List<Afspeelijst> afspeellijsten = new List<Afspeelijst>();

Client client = new Client();

client.InputGever(nummer1, albums, artiesten, afspeellijsten);