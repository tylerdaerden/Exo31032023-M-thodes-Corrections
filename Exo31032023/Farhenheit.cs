using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Exo31032023
{
    public struct Farhenheit
    {
        public double Temperature;

        public Celcius Convert ( )
        {
            Celcius c;
            c.Temperature = (Temperature - 32) / 1.8;
            return c;
        }
    }
}
