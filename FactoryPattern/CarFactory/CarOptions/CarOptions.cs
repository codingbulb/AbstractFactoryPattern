using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory.AbstractFactory
{
    public class CarOptions
    {
        public enum Brand
        {
            Audi,
            Porsche,
            VW
        }

        public enum Seat
        {
            Normal,
            Leather
        }

        public enum Door
        {
            Normal,
            Scissor,
            Butterfly
        }
    }
}
