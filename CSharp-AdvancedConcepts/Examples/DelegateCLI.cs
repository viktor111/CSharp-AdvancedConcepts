using Delegates;
using System;
using System.Collections.Generic;

namespace CSharp_AdvancedConcepts
{
    public class DelegateCLI
    {
        /*
         - This example passes delagate function to carWash.TotalSum method that displays the sum          
        */
        internal static void DelegateExample()
        {
            CarWash carWash = new CarWash();

            List<Car> cars = new List<Car>();

            cars.Add(new Car { MoneyPaid = 13 });
            cars.Add(new Car { MoneyPaid = 15 });
            cars.Add(new Car { MoneyPaid = 15 });

            carWash.Cars = cars;

            //Passes function
            Console.WriteLine(carWash.TotalSum(SumAlert));
        }

        private static void SumAlert(decimal sum)
        {
            Console.WriteLine($"The sum is {sum:C2}");
        }
    }
}
