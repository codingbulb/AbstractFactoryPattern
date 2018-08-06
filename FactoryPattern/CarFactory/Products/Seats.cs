using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory.AbstractFactory
{
    public class NormalSeat : ISeat
    {
        public string getSeat()
        {
            return CarOptions.Seat.Normal.ToString();
        }
    }

    public class LeatherSeat : ISeat
    {
        public string getSeat()
        {
            return CarOptions.Seat.Leather.ToString();
        }
    }
}
