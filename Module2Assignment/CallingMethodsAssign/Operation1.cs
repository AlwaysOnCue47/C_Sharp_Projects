using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethodsAssign
{
    public class Operation1
    {
        public static decimal Kilogram(decimal lbs )
        {
            decimal inKg = lbs * 0.453592m;
            return inKg;
        }

        public static decimal Ounce(decimal lbs)
        {
            decimal inOz = lbs * 16m;
            return inOz;
        }

        public static decimal Grams(decimal lbs)
        {
            decimal inGram = lbs * 453.592m;
            return inGram;
        }


    }
}
