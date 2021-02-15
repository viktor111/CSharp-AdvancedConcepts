using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class Resturant
    {
        // Declare event
        public event EventHandler<Order> OrderSent;

        public string Name { get; set; }

        // Invoke event
        public bool SendOrder(Order order)
        {
            OrderSent?.Invoke(this, order);

            return true;
        }
    }
}
