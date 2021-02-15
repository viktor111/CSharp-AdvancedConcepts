using Events;
using System;

namespace CSharp_AdvancedConcepts
{
    public class EventCLI
    {
        /*
            - This example reaises an event when SendOrder method is called          
        */
        internal static void EventExample()
        {
            Order order = new Order
            {
                Price = 2.3M,
                ProductCount = 2,
                TableNumber = 10
            };

            Resturant resturant = new Resturant();

            resturant.Name = "Resturant111";

            resturant.OrderSent += Order_OrderSent;

            resturant.SendOrder(order);
        }

        // Event Handler
        private static void Order_OrderSent(object sender, Order e)
        {
            Console.WriteLine("Order sent");
            Console.WriteLine("With price: " + e.Price);
            Console.WriteLine("With table number: " + e.TableNumber);
            Console.WriteLine("With product count: " + e.ProductCount);
            Console.WriteLine("Sender: " + sender.ToString());
        }
    }
}
