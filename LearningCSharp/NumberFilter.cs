using System;
using System.Collections.Generic;

namespace LearningCSharp
{
    // create a class that extends System.MultyCastDelegate
    // that can refer to any method that takes an int and returns a bool
    public delegate bool FilterMethod(int num);

    public class NumberFilter
    {
        public List<int> FilterOutEvens(List<int> numbers)
        {
            return Filter(numbers, n => n % 2 != 0);
        }

        public List<int> FilterOutOdds(List<int> numbers)
        {
            return Filter(numbers, IsEven);
        }

        private List<int> Filter(List<int> numbers, FilterMethod op)
        {
            var result = new List<int>();
            foreach (var num in numbers)
            {
                if (op(num))
                {
                    result.Add(num);
                }
            }
            return result;
        }

        private bool IsOdd(int num)
        {
            return num % 2 != 0;
        }

        private bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}