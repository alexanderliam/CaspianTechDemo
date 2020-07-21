using System.Collections.Generic;
using System.Linq;

namespace CaspianTechDemo.Models
{
    public class Calculator: ICalculator
    {
        public double CalculatePrice(IEnumerable<OrderItem> orderItems)
        {
            return orderItems.Sum(x => x.Price);
        }

        public double CalculateServiceCharge(IEnumerable<OrderItem> orderItems)
        {
            return 0.0d;
        }

    }
}
