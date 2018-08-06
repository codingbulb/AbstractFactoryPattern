using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory.AbstractFactory
{
    public class PorscheFactory : ICarFactory
    {
        public IBrand Brand()
        {
            return new Porsche();
        }

        public IDoor Door()
        {
            return new ScissorDoor();
        }

        public ISeat Seat()
        {
            return new LeatherSeat();
        }
    }
}
