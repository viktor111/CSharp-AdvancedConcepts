using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionExample
{
    public class User
    {
        public string Name { get; set; }    

        public void Register (string name, string password)
        {
            Console.WriteLine("User registered...");
        }
    }
}
