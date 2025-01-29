using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethodsAssign
{
    public class Operation1
    {
        public static double Kilogram(double  lbs )
        {
            double inKg = lbs * 0.453592;
            return inKg;
        }

        public static double Ounce(double lbs)
        {
            double inOz = lbs * 16;
            return inOz;
        }

        public static double Grams(double lbs)
        {
            double inGram = lbs * 453.592;
            return inGram;
        }


    }
}
