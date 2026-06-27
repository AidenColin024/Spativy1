using System;
using System.Collections.Generic;

namespace Spativy
{
    internal class Artiest
    {
        public String Naam { get; set; }
        public List<Album> Albums { get; set; }
        public List<Nummer> Nummers { get; set; }

        public Artiest(String naam, List<Album> albums, List<Nummer> nummers)
        {
            Naam = naam;
            Albums = albums;
            Nummers = nummers;
        }
    }
}