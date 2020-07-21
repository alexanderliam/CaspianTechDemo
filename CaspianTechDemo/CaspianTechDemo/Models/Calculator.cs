using System.Collections.Generic;
using System.Linq;

namespace CaspianTechDemo.Models
{
    public static class Calculator
    {
        public static double CalculatePrice(IEnumerable<OrderItem> orderItems)
        {
            return orderItems.Sum(x => x.Price);
        }
    }
}
