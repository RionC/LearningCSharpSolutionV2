using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    public static class Healpers
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
