using CaspianTechDemo.Models;
using NUnit.Framework;

namespace CaspianTechDemoTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, TestCaseSource(typeof(TestData), "TestCases")]
        public double NewTestWithParams(OrderItem orderItem)
        {
            return orderItem.Price + 1;
        }

    }
}