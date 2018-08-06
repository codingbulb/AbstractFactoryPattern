using FactoryPattern.Factory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerCar10k = CustomerFactory.NewCustomerCar(10000);
            Console.WriteLine("{0} {1} {2}", customerCar10k.Brand().getBrand(), customerCar10k.Door().getDoor(), customerCar10k.Seat().getSeat());

            var customerCar40k = CustomerFactory.NewCustomerCar(40000);
            Console.WriteLine("{0} {1} {2}", customerCar40k.Brand().getBrand(), customerCar40k.Door().getDoor(), customerCar40k.Seat().getSeat());

            var customerCar80k = CustomerFactory.NewCustomerCar(80000);
            Console.WriteLine("{0} {1} {2}", customerCar80k.Brand().getBrand(), customerCar80k.Door().getDoor(), customerCar80k.Seat().getSeat());
            Console.ReadKey();
        }
    }
}
