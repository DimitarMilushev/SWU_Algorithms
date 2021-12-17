namespace Exercises
{
    /**
    * An algorithm that takes an array of integers, 
    * separates them by value (positive/negative) and prints out results
    */
    public class PositiveNegative : IExercise
    {
        private List<int> integerArray { get; set; }
        public PositiveNegative()
        {
            this.integerArray = new List<int> { };
        }
        public void init()
        {
            List<string> input = null;
            this.getInputString(ref input);
            if (input.Any())
            {
                return;
            }
            this.translateInputToIntegers(ref input);
        }
        public void calculate()
        {
            List<int> positiveArray = new List<int> { };
            List<int> negativeArray = new List<int> { };
            this.populateLists(ref positiveArray, ref negativeArray);
            this.printOutput(ref positiveArray, ref negativeArray);
        }

        private void translateInputToIntegers(ref List<string> inputStrings)
        {
            foreach (string el in inputStrings)
            {
                try
                {
                    this.integerArray.Add(Int32.Parse(el));
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
        private void populateLists(ref List<int> positiveArray, ref List<int> negativeArray)
        {
            foreach (int element in this.integerArray)
            {
                if (element >= 0)
                {
                    positiveArray.Add(element);
                }
                else if (element < 0)
                {
                    negativeArray.Add(element);
                }
            }
        }
        private void printOutput(ref List<int> positiveArray, ref List<int> negativeArray)
        {
            if (positiveArray.Count > 0)
            {
                Console.WriteLine("Positive numbers: [" + string.Join<int>(", ", positiveArray) + ']');
            }
            if (negativeArray.Count > 0)
            {
                Console.WriteLine("Negative numbers: [" + string.Join<int>(", ", negativeArray) + ']');
            }

            Console.WriteLine("\n Author: Dimitar Milushev \n Fn: 19251421043, IST");
        }
        private void getInputString(ref List<string> input)
        {
            while (input == null)
            {
                Console.WriteLine("Please enter an array of integers.");
                try
                {
                    input = Console.ReadLine().Trim().Split(' ').ToList();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}