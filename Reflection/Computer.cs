using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ReflectionExample
{
    public class Computer
    {

        public User User { get; set; }

        public void Run()
        {
            Console.WriteLine("Computer starting...");
            Thread.Sleep(200);
            Console.WriteLine("Computer started");
        }

        public void LogIn(string password)
        {
            string correctPassword = "www123";

            if (password == correctPassword)
            {
                User = new User()
                {
                    Name = "Ivar"
                };
            }
            else
            {
                return;
            }
        }       
    }
}
