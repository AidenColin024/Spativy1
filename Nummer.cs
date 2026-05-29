using System;
using System.Collections.Generic;
using System.Text;

namespace Spativy
{
    internal class Nummer
    {
        public String Titel { get; set; }
        public String Artiest { get; set; }
        public String Genre { get; set; }


        public Nummer (String titel, String artiest, String genre)
        {
            Titel = titel;
            Artiest = artiest;
            Genre = genre;

        }
    }
}
