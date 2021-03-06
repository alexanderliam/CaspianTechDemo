﻿using System.Collections.Generic;

namespace CaspianTechDemo.Models
{
    public interface ICalculator
    {
        double CalculatePrice(IEnumerable<OrderItem> orderItems);
        double CalculateServiceCharge(IEnumerable<OrderItem> orderItems);
    }
}
