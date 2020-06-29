using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class BuiltInDelegateTypes
    {
        [Fact]
        public void TheActionDelegateType()
        {
            Action doit = () => Console.Write("Doing it");
            doit();

            Action<string, int> doitWithParams = (string name, int numberOfTimes) =>
            {
                for (var t = 0; t < numberOfTimes; t++)
                {
                    Console.WriteLine(name);
                }
            };

            doitWithParams = SomeOtherMethod;

            doitWithParams("red", 5);
        }

        [Fact]
        public void Predicates()
        {
            Predicate<string> likePizzaTopping = (topping) =>
            {
                return topping == "cheese";
            };

            Assert.True(likePizzaTopping("cheese"));
        }

        [Fact]
        public void GettingFancy()
        {
            Func<int, int, int> mathOp;

            mathOp = (a, b) => a + b;
            Assert.Equal(12, mathOp(10, 2));

            mathOp = (a, b) => a - b;

            Assert.Equal(8, mathOp(10, 2));

            Func<int, int, string> concatenateNumbersAsString = (a, b) => a.ToString() + b.ToString();

            Assert.Equal("105", concatenateNumbersAsString(10, 5));

            var friends = new List<string> { "David", "Tim", "Sue", "Billy" };
        }

        public void SomeOtherMethod(string color, int size)
        {

        }
    }
}
