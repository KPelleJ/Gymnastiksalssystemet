using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastiksalssystemet
{
    public class Gruppeliste
    {
        public List<Gruppe> grupper;

        public Gruppeliste()
        { 
            grupper = new List<Gruppe>();
            grupper.Add(new Gruppe("Håndbold Pigerne","9-11år",15));
            grupper.Add(new Gruppe("Gynmastik Rollinger", "7-9år",10));
            grupper.Add(new Gruppe("Fodbold Fyrene","11-13år",14));
        }
        
        
    }
}
