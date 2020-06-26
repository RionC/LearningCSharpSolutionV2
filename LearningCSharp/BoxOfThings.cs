using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    public class BoxOfThings<T>
    {
        private T[] stuff = new T[10];

        public T this[int t]
        {
            get { return stuff[t]; }
            set { stuff[t] = value; }
        }
    }
}
