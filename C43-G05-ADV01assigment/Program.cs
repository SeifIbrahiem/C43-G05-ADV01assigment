using System.Collections;

namespace C43_G05_ADV01assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ex1
            //int[] data = { 64, 34, 25, 12, 22, 11, 90 };
            //Bubblesort.OptimizedBubbleSort(data);

            //Console.WriteLine("Sorted Array:");
            //foreach (int num in data)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine(); 
            #endregion

            #region ex3
            //ArrayList numbers = new ArrayList { 1, 2, 3, 4, 5 };
            //ReverseArrayListGeneric<int>.Reverse(numbers);

            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //} 
            #endregion

            #region ex4 evennumber
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = Evennumber.FindEvenNumbers(numbers);

            foreach (int even in evenNumbers)
            {
                Console.WriteLine(even);
            } 
            #endregion



        }

    }
}

