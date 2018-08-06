using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory.AbstractFactory
{
    class NormalDoor : IDoor
    {
        public string getDoor()
        {
            return CarOptions.Door.Normal.ToString();
        }
    }

    class ScissorDoor : IDoor
    {
        public string getDoor()
        {
            return CarOptions.Door.Scissor.ToString();
        }
    }

    class ButterflyDoor : IDoor
    {
        public string getDoor()
        {
            return CarOptions.Door.Butterfly.ToString();
        }
    }
}
