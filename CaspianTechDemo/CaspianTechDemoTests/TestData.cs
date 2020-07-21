using CaspianTechDemo.Models;
using NUnit.Framework;
using System.Collections;

namespace CaspianTechDemoTests
{
    public class TestData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return
                    new TestCaseData(
                        MenuItems.Coffee
                    ).Returns(2.0d);
            
            }
        }
    }
}
