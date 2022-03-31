using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingImplicitExplicitOperatorOverloading.Models
{
    internal class Celsius
    {
        public double Celsi { get; set; }
        public Celsius(double cell)
        {
            Celsi = cell;
        }

        public static implicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Celsi*276);
        }
    }
}
