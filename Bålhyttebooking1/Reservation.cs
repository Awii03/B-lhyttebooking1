using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bålhyttebooking1
{

    public class Reservation
    {
        internal Boernegruppe boernegruppe;

        public int ID { get; set; }
        public DateTime Tidspunkt { get; set; }
        public object Boernegruppe { get; set; }
        

        public override string ToString()
        {
            return $" ID = " + ID + " Tidspunkt " + Tidspunkt + "boernegruppe" + Boernegruppe;

        }



        public void Addreservation(Reservation reservation)

        {
            reservation.Add(int, reservation); 

        }

        public object GetReservations()
        {
            object reservation = null;
            return reservation;
        }

     
        public void PrintReservation(object reservations)
        {
            foreach (Reservation reservation in reservations)
            {
                Console.WriteLine(reservation);
            }

        }

        public void Removereservation(Reservation reservation)
        {
            reservation.Removereservation(reservation);
        }

        internal static void Add(Reservation reservation)
        {
            throw new NotImplementedException();
        }
    }
}
