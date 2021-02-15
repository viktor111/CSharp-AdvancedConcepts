using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    public class CarWash
    {
        // Delegate func delcare
        public delegate void MentionDiscount(decimal sum);

        public List<Car> Cars { get; set; }

        // Recieves function
        public decimal TotalSum(MentionDiscount mentionDiscount)
        {
            decimal sum = Cars.Sum(c => c.MoneyPaid);

            // Calls function
            mentionDiscount(sum);

            if (sum > 100)
            {
                return sum * 0.80M;
            }
            else if (sum > 50)
            {
                return sum * 0.50M;
            }
            else if (sum > 10)
            {
                return sum * 0.90M;
            }

            return sum;
        }
    }
}
