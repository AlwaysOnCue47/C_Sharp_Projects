using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClassAssignment
{
    public class Basket // creating new class called Baskit
    {
        public Basket(int oranges, int baskets ) // method is void because it does not return a value it only carries out instructions. Here 2 math operations are performed and a writeline to the console. 
        {
            int remainder = oranges % baskets; // determines how many oranges will be left over after divided them equally into the baskets
            int perBaskit = oranges / baskets; // how many whole oranges  (no fractions) in each basket
            Console.WriteLine($"Using {baskets} baskets, you can fit {perBaskit} oranges in each basket with {remainder} extra"); // writes message and values to console. 
        }

    }
}
