using System;
using System.Collections.Generic;
using System.Text;

namespace Cities
{
    class Class1
    {
        public bool FindCities(string a)
        {
            return ReadCities.citiesList.Contains(a);
        }
    }
}
