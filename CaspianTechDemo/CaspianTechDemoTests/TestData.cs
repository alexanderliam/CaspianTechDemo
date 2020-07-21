using CaspianTechDemo.Models;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace CaspianTechDemoTests
{
    public class TestData
    {
        public static IEnumerable CalculateTotal
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

        public static IEnumerable CalculateServiceCharge
        {
            get
            {

                // Empty list test case No service charge added
                yield return
                    new TestCaseData(
                        new List<OrderItem>
                        {
                        }
                    ).Returns(0.0d);

                // Single menu item drink, no charge
                yield return
                    new TestCaseData(
                        new List<OrderItem>
                        {
                            MenuItem.Coffee
                        }
                    ).Returns(0.0d);

                // Single Item any food, 10%
                yield return
                    new TestCaseData(
                        new List<OrderItem>
                        {
                            MenuItem.CheeseSandwich
                        }
                    ).Returns(MenuItem.CheeseSandwich.Price * 0.1f);

                // Single Item any hot food, 20%
                yield return
                    new TestCaseData(
                        new List<OrderItem>
                        {
                            MenuItem.SteakSandwich
                        }
                    ).Returns(MenuItem.SteakSandwich.Price * 0.2f);

                // Cap total service charge at £20
                yield return
                    new TestCaseData(
                        new List<OrderItem>
                        {
                            MenuItem.SteakSandwich // Lots of items to go over £20 service charge
                        }
                    ).Returns(20.0d);
            }
        }
    }
}
