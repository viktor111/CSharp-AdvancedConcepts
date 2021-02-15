using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDependancyInjection.Services
{
    public class CartService
    {
        int _random;

        public CartService()
        {
            _random = new Random().Next();
        }

        public void AddToCart()
        {
            Console.WriteLine(_random);
        }
    }
}
