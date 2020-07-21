using System;
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
            if (orderItems.Any(x => x.IsFood))
            {
                var sum = CalculatePrice(orderItems);

                // If Any are hot => 20% charge max £20 else 10% no max
                if (orderItems.Any(x => x.IsHot))
                {
                    return Math.Min(sum * 0.2f, 20.0d);
                }
                else
                {
                    return Math.Round(sum * 0.1f, 2);
                }
            }
                
            // All items are drinks => 0 added service charge;
            return 0.0d;
        }

    }
}
