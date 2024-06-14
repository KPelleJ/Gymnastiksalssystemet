using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastiksalssystemet
{
    public class Gruppe
    {
        private string _navn;
        private string _aldersgruppe;
        private int _deltagere;
        private int _id;
        private static int _idCount = 1;

        public Gruppe(string navn, string aldersgruppe, int deltagere)
        {
            _navn = navn;
            _aldersgruppe = aldersgruppe;
            _deltagere = deltagere;
            _id = _idCount++;
        }

        public string Navn
        { get { return _navn; } }

        public string Aldersgruppe
        { get { return _aldersgruppe; } }

        public int Deltagere
        { get { return _deltagere; } }

        public int Id
            { get { return _id; } }



    }
}
