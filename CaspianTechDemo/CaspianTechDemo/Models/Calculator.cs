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
    }
}
