using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exo31032023
{
    public struct Celcius
    {
        public double Temperature;

        public Farhenheit  Convert ( )
        {
            Farhenheit f;
            f.Temperature = (Temperature * 1.8) + 32;
            return f;
        }
    }
}
