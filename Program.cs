using System;

namespace arrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort
            int[] numberArray = { 23, 12, 4, 86, 72, 3, 11, 17 };
            Console.WriteLine("Unsorted List");
            foreach (int item in numberArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nSorted List");
            Array.Sort(numberArray);
            foreach (int item in numberArray)
            {
                Console.Write(item + " ");
            }

            //clear
            Console.WriteLine("\nCleaned List");
            Array.Clear(numberArray, 2, 3);
            foreach (int item in numberArray)
            {
                Console.Write(item + " ");
            }

            //reverse
            Console.WriteLine("\nReversed List");
            Array.Reverse(numberArray);
            foreach (int item in numberArray)
            {
                Console.Write(item + " ");
            }

            //indexOf
            Console.WriteLine("\nArray IndexOf");
            int indexOfNumber = Array.IndexOf(numberArray,23);
            Console.WriteLine("Sayının indexi : {0}",indexOfNumber);

            //Resize
            Console.WriteLine("\nArray Resize");
            Array.Resize<int>(ref numberArray,15);
            foreach (int item in numberArray)
            {
                Console.Write(item + " ");
            }           

        }//main end
    }
}
