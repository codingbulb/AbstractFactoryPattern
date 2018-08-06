using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory.AbstractFactory
{
    public interface ICarFactory
    {
        IBrand Brand();
        ISeat Seat();
        IDoor Door();
    }
}
