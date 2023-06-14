using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bålhyttebooking1
{
    public class Reservatioer
    {
    
        public int ID { get; set; }

        public List<Reservation> reservations { get; set; }

        public Reservatioer()
        {
            DateTime tids = DateTime.Now;
            reservations = new List<Reservation>();
            Reservation.Add(new Reservation() { ID = 1, Tidspunkt = tids, boernegruppe = new Boernegruppe() { ID = "1", Navn = "Awais", Aldersgruppe = "20", AntalDeltagere = 25 } });

        }  

        public void Add(Reservation reservation)
        {
            reservations.Add(reservation);
        }

        public void Remove(Reservation reservation)
        {
            reservations.Remove(reservation);
        }

        public void Printreservation()
        {
            foreach (Reservation reservation in reservations)
            {
                Console.WriteLine(reservation);
            }
        }

        public Dictionary<int, Reservation> Reservationer { get; set; }

        


    }




}
