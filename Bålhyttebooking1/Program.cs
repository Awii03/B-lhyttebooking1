using Bålhyttebooking1;

class Program
{
    public static object Add { get; private set; }
    public object reservations { get; private set; }
    static void Main(string[] args)
    {

        Boernegruppe gruppe1 = new Boernegruppe("G1", "Gruppe 1", "pusling", 10);
        Boernegruppe gruppe2 = new Boernegruppe("G2", "Gruppe 2", "tumling", 15);

        Console.WriteLine(gruppe1.ToString());
        Console.WriteLine(gruppe2.ToString());

        Console.ReadLine();

       
        DateTime tids = new DateTime(2023, 05, 02);
        Reservation reservation1 = new Reservation();
        Reservation reservation2 = new Reservation();
        Reservation reservation3 = new Reservation();
        {

            reservation1 = new Reservation() {ID = 1, Tidspunkt = tids, Boernegruppe = new Boernegruppe() { ID = "1", Navn = "Awais", Aldersgruppe = "pusling" } };
            reservation2 = new Reservation() { ID = 2, Tidspunkt = tids, Boernegruppe = new Boernegruppe() { ID = "2", Navn = "Kurt", Aldersgruppe = "tumling" } };
            reservation1 = new Reservation() { ID = 1, Tidspunkt = tids, Boernegruppe = new Boernegruppe() { ID = "3", Navn = "Bo", Aldersgruppe = "Stjernerne" } };

        }
        
     
    }   
}
