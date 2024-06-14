using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastiksalssystemet
{
    public class Booking
    {
        private DateOnly _dato;
        private TimeOnly _starttidspunkt;
        private TimeOnly _sluttidspunkt;
        private Gruppe _gruppe;
        private int _halId;
        private int _id;
        private static int _idCount = 1;

        public Booking(DateOnly dato, TimeOnly starttidspunkt, TimeOnly sluttidspunkt, int halId, Gruppe gruppe)
        {
            _dato = dato;
            _starttidspunkt = starttidspunkt;
            _sluttidspunkt = sluttidspunkt;
            _halId = halId;
            _gruppe = gruppe;
            _id = _idCount++;
        }

        public DateOnly Dato
            { get { return _dato; } }

        public TimeOnly Starttidspunkt
        {  get { return _starttidspunkt; } }

        public TimeOnly Sluttidspunkt 
        { get { return _sluttidspunkt; } }

        public Gruppe Gruppe
        { get { return _gruppe; } }

        public int HalId
            { get { return _halId; } }

        public int Id
            { get { return _id; } }

        public string GetWeekday(DateOnly dato)
        {
            string day;
            day = dato.DayOfWeek.ToString();
            return day;
        }

        //public string GetGroupName(int Id)
        //{
        //    string gruppenavn = "";
        //
        //    foreach (Gruppe g in Gruppeliste.grupper)
        //    {
        //        if (g.Id == Id)
        //        {
        //          gruppenavn = g.Navn;
        //        }
        //
        //        return gruppenavn;
        //    }
        //    
        //    return gruppenavn;
        //}
    }
}
