using System;
using System.Collections.Generic;
using System.Text;

namespace Spativy
{
    internal class Client
    {
        public Nummer Nummer {  get; set; }


        public void SpeelNummer(Nummer nummer)
        {
            Console.WriteLine("Speelt: " + nummer.Titel + " Van " + nummer.Artiest + " Genre: " + nummer.Genre);
            Console.WriteLine();
        }
    }
}
