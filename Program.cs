namespace Gymnastiksalssystemet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gruppe a = new Gruppe("Håndbold Pigerne", "9-11år", 15);
            Gruppe b = new Gruppe("Floorball Rollinger", "7-9år", 10);
            Gruppe c = new Gruppe("Fodbold Fyrene", "11-13år", 14);

            BookingManager manager = new BookingManager();


            Console.WriteLine(manager.AddBooking(new DateOnly(2024, 6, 15), new TimeOnly(8, 00),1, a));
            Console.WriteLine(manager.AddBooking(new DateOnly(2024, 6, 15), new TimeOnly(10, 00), 2, b));
            Console.WriteLine(manager.AddBooking(new DateOnly(2024, 6, 19), new TimeOnly(13, 00), 1, c));
            Console.WriteLine(manager.AddBooking(new DateOnly(2024,6,16),new TimeOnly(8,00),1,b));
            Console.WriteLine(manager.AddBooking(new DateOnly(2024, 6, 16), new TimeOnly(11, 00), 1, b));
            //manager.AddBooking(new DateOnly(2024,6,15),new TimeOnly(8,00),new TimeOnly(9, 00),1,a);
            //manager.AddBooking(new DateOnly(2024, 6, 15), new TimeOnly(10,00), new TimeOnly(11, 00), 2, b);
            //manager.AddBooking(new DateOnly(2024, 6, 19), new TimeOnly(13, 00), new TimeOnly(14, 00), 1, c);


            Console.WriteLine(manager.ShowBookings());
        }
    }
}
