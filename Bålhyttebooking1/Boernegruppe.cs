using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bålhyttebooking1
{
    public class Boernegruppe
    {
        public string ID { get; set; }
        public string Navn { get; set; }
        public string Aldersgruppe { get; set; }
        public int AntalDeltagere { get; set; }


        public Boernegruppe(string id, string navn, string aldersgruppe, int antaldeltagere) 
            {
            ID = id;
            Navn = navn;
            Aldersgruppe= aldersgruppe;
            AntalDeltagere= antaldeltagere;
            }

        public Boernegruppe()
        {

        }

        public override string ToString()
        {
            return $" ID " + ID + " Navn " + Navn + "Aldersgruppe" + Aldersgruppe + "AntalDeltagere" + AntalDeltagere;
        }
    }  
    
}
