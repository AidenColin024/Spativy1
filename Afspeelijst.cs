using System;
using System.Collections.Generic;
using System.Text;

namespace Spativy
{
    internal class Afspeelijst
    {
        public String TitelAfspeelijst {  get; set; }
        public String NaamGebruiker { get; set; }
        public List<Nummer> Nummers { get; set; }


        public Afspeelijst(String titelafspeelijst, String naamgebruiker, List<Nummer> nummers) 
        {
            TitelAfspeelijst = titelafspeelijst;
            NaamGebruiker = naamgebruiker;
            Nummers = nummers;
        
        }
    }
}
