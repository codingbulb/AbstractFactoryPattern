using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory.AbstractFactory
{
    class VW : IBrand
    {
        public string getBrand()
        {
            return CarOptions.Brand.VW.ToString();
        }
    }
}
