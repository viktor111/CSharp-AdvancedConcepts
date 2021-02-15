using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDependancyInjection.Services
{
    public class UserService
    {
        ProductService _productService;

        public UserService(ProductService productService)
        {
            _productService = productService;
        }

        public void RegisterUser()
        {
            Console.WriteLine("User registered");
        }
    }
}
