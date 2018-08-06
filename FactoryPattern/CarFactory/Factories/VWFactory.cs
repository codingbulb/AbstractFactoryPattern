using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory.AbstractFactory
{
    public class VWFactory : ICarFactory
    {
        public IBrand Brand()
        {
            return new VW();
        }

        public IDoor Door()
        {
            return new NormalDoor();
        }

        public ISeat Seat()
        {
            return new NormalSeat();
        }
    }
}
