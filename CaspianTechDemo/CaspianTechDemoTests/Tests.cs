using CaspianTechDemo.Controllers;
using CaspianTechDemo.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace CaspianTechDemoTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(TestData), "CalculateTotal")]
        public double CalculateTotal(IEnumerable<OrderItem> orderItems)
        {
            ICalculator calculator = new Calculator();

            return calculator.CalculatePrice(orderItems);
        }

        [Test, TestCaseSource(typeof(TestData), "CalculateServiceCharge")]
        public double CalculateServiceCharge(IEnumerable<OrderItem> orderItems)
        {
            ICalculator calculator = new Calculator();

            return calculator.CalculateServiceCharge(orderItems);
        }

    }
}