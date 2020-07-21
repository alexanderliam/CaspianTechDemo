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

        [Test, TestCaseSource(typeof(TestData), "TestCases")]
        public double CalculateMenuPrice(IEnumerable<OrderItem> orderItem)
        {
            ICalculator calculator = new Calculator();

            return calculator.CalculatePrice(orderItem);
        }

    }
}