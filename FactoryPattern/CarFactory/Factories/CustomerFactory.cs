using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory.AbstractFactory
{
    public static class CustomerFactory
    {
        public static ICarFactory NewCustomerCar(decimal cash)
        {
            if (cash < 30000)
            {
                return new VWFactory();
            }
            else if (cash < 60000)
            {
                return new AudiFactory();
            }
            else
            {
                return new PorscheFactory();
            }
        }
    }
}
