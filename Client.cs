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
            Console.WriteLine("Speelt: " + nummer.Titel + " Van " + nummer.Artiest + " Genre: " + nummer.Genre + " druk op 2 om het nummer te stoppen.");
            Console.WriteLine();
            String input = Console.ReadLine();

            if (input == "2")
            {
                StopNummer(nummer);
            }
        }

        public void StopNummer (Nummer nummer)
        {
            Console.WriteLine("Het nummer is gestopt");
            Console.WriteLine();
        }

        public void SlaOver(Nummer nummer)
        {
            SpeelNummer(nummer);
        }

        public void InputGever(Nummer nummer)
        {
            Console.WriteLine("Welkom bij Spativy ");
            Console.WriteLine("Druk op 1 om een nummer af te spelen. Druk op 2 om een nummer te stoppen. Druk op 3 om een nummer over te slaan.");
            String input = Console.ReadLine();

            while(input != "1" && input != "2" && input != "3" )
            {
                Console.WriteLine("druk op een geldige toets");
                input = Console.ReadLine();
            }

            if (input == "1")
            {
                SpeelNummer(nummer);
            }
            else if (input == "2")
            {
                StopNummer(nummer);
            }
            else if (input == "3")
            {
                SlaOver(nummer);
            }
        }
    }
}
