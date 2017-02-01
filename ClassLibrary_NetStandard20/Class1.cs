using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace ClassLibrary1
{
    public class Class1
    {
        public static IEnumerable<int> CreateData()
        {
            return new Bag<int> { 1, 2, 3 };
        }
    }
}
