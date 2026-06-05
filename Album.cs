using System;
using System.Collections.Generic;

namespace Spativy
{
    internal class Album
    {
        public String Titel { get; set; }
        public String Artiest { get; set; }
        public List<Nummer> Nummers { get; set; }

        public Album(String titel, String artiest, List<Nummer> nummers)
        {
            Titel = titel;
            Artiest = artiest;
            Nummers = nummers;
        }
    }
}