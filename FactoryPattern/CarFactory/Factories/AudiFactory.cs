using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory.AbstractFactory
{
    class AudiFactory : ICarFactory
    {
        public IBrand Brand()
        {
            return new Audi();
        }

        public IDoor Door()
        {
            return new NormalDoor();
        }

        public ISeat Seat()
        {
            return new LeatherSeat();
        }
    }
}
