using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Exercises;

namespace Algorithms // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IExercise positiveNegative = new PositiveNegative();
            positiveNegative.init();
            positiveNegative.calculate(); 
        }
    }
}