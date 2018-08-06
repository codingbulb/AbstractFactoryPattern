using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory.AbstractFactory
{
    class Porsche : IBrand
    {
        public string getBrand()
        {
            return CarOptions.Brand.Porsche.ToString();
        }
    }
}
