using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastiksalssystemet
{
    public class BookingManager
    {
        private List<Booking> _bookings;

        public BookingManager() 
        { 
            _bookings = new List<Booking>();
        }

        public string ShowBookings()
        {
            string bookings;

            bookings = "Liste over bookinger:\n";

            if (_bookings != null)
            {
                foreach (Booking b in _bookings)
                {
                    bookings = bookings + $"Booking Id: {b.Id}\nGruppe: {b.Gruppe.Navn}({b.Gruppe.Id})\nTidspunkt: {b.GetWeekday(b.Dato)} d.{b.Dato} kl. {b.Starttidspunkt} - {b.Sluttidspunkt}" +
                        $"\nAntal Deltagere: {b.Gruppe.Deltagere}\n\n";
                }
            }
            if (bookings.Length < 25)
            {
                bookings = bookings + "Der er i øjeblikket ikke nogen bookinger";
            }

            return bookings;
        }

        public string AddBooking(DateOnly dato, TimeOnly starttidspunkt, int halId, Gruppe gruppe)
        {
            string bookingMessage = "";
            TimeOnly sluttid = starttidspunkt.AddHours(2);

            //foreach (Booking b in _bookings)
            //{
            //    if (b.Dato == dato && starttidspunkt.IsBetween(b.Starttidspunkt, b.Sluttidspunkt))
            //    {
            //        bookingMessage = bookingMessage + $"Booking kan ikke udføres tidsrum, prøv venligst igen\n";
            //    }
            //    
            //}

            if (dato.DayOfWeek != DayOfWeek.Sunday && starttidspunkt.IsBetween(new TimeOnly(8, 00), new TimeOnly(19, 00)))
            {
                _bookings.Add(new Booking(dato, starttidspunkt, sluttid, halId, gruppe));

                bookingMessage = bookingMessage + $"Din booking {dato.DayOfWeek.ToString()} d.{dato} kl{starttidspunkt} - {sluttid} er nu oprettet\n";
            }
            else if(dato.DayOfWeek is DayOfWeek.Sunday && starttidspunkt.IsBetween(new TimeOnly(10, 00), new TimeOnly(18, 00)))
            {
                _bookings.Add(new Booking(dato, starttidspunkt, sluttid, halId, gruppe));

                bookingMessage = bookingMessage + $"Din booking {dato.DayOfWeek.ToString()} d.{dato} kl{starttidspunkt} - {sluttid} er nu oprettet\n";
            }
            else
            {
                bookingMessage = bookingMessage + $"Booking kan ikke udføres tidsrum, prøv venligst igen\n";
            }

            return bookingMessage;
        }
    }
}
