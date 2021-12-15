namespace Algorithms
{
    /**
    * An algorithm that takes an array of integers, 
    * separates them by value (positive/negative) and prints out results
    */
    public class PositiveNegative_Algo : Exercise
    {
        public void calculate()
        {
            List<string> input = null;
            this.getInputString(ref input);
            if (input.Count < 1)
            {
                return;
            }
            List<int> inputList = new List<int> { };
            this.translateInputToIntegers(ref input, ref inputList);

            List<int> positiveArray = new List<int> { };
            List<int> negativeArray = new List<int> { };
            this.populateLists(ref positiveArray, ref negativeArray, ref inputList);
            this.printOutput(ref positiveArray, ref negativeArray);
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
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        private void translateInputToIntegers(ref List<string> inputStrings, ref List<int> inputList) {
            foreach (string el in inputStrings)
            {
                try
                {
                    inputList.Add(Int32.Parse(el));
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(el + " is not a number. \n " + exception.Message);
                }
            }
        }
        private void populateLists(ref List<int> positiveArray, ref List<int> negativeArray, ref List<int> inputList) {
            foreach (int element in inputList)
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
        private void printOutput(ref List<int> positiveArray, ref List<int> negativeArray) {
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
    }
}