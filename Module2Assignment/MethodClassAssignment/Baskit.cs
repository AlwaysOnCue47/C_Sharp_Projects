using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClassAssignment
{
    public class Baskit // creating new class called Baskit
    {
        public Baskit(int oranges, int baskits ) // method is void because it does not return a value it only carries out instructions. Here 2 math operations are performed and a writeline to the console. 
        {
            int remainder = oranges % baskits; // determines how many oranges will be left over after divided them equally into the baskits
            int perBaskit = oranges / baskits; // how many whole oranges  (no fractions) in each baskit
            Console.WriteLine($"Using {baskits} baskits, you can fit {perBaskit} oranges in each baskit with {remainder} extra"); // writes message and values to console. 
        }

    }
}
