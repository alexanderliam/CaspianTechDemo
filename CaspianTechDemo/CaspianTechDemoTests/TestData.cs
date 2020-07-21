using CaspianTechDemo.Models;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace CaspianTechDemoTests
{
    public class TestData
    {
        public static IEnumerable TestCases
        {
            get
            {

                // Empty list test case (no exception should be thrown)
                yield return
                    new TestCaseData(
                        new List<OrderItem>
                        {
                        }
                    ).Returns(0.0d);

                // Single menu item should return price
                yield return
                    new TestCaseData(
                        new List<OrderItem>
                        {
                            MenuItem.Coffee
                        }
                    ).Returns(1.0d);

                // Multiple menu items should add price together
                yield return
                    new TestCaseData(
                        new List<OrderItem>
                        {
                            MenuItem.Coffee,
                            MenuItem.CheeseSandwich
                        }
                    ).Returns(3.0d);
            }
        }
    }
}
