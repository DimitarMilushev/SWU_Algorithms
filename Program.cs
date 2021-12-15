using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Algorithms // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Exercise positiveNegative = new PositiveNegative_Algo();
            positiveNegative.calculate(); 
        }
    }
}