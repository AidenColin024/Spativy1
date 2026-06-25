using System;
using System.Collections.Generic;
using System.Text;

namespace Spativy
{
    internal class Gebruiker
    {
        public String NaamGebruiker { get; set; }
        public List<Nummer> Nummers { get; set; }
        public List<Album> Albums { get; set; }
        public List<Afspeelijst> Afspeellijsten { get; set; }
    public Gebruiker(String naamgebruiker, List<Nummer> nummers, List<Album> albums, List<Afspeelijst> afspeellijsten)
        {
            NaamGebruiker = naamgebruiker;
            Nummers = nummers;
            Albums = albums;
            Afspeellijsten = afspeellijsten;


        }
    }
}
