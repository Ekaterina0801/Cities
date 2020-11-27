using System;
using System.Collections.Generic;
using System.Text;

namespace Cities
{
    class Class1
    {
        public bool FindCities(string a)
        {
            return Array.BinarySearch(ReadCities.citiesList, a) > 0;
        }
    }
}
