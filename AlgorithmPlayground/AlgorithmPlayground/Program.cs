using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting;

namespace AlgorithmPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>()
            {
                10, 7, 8, 9, 1, 5,5,7,3,2,2,2,2,2,2
            };

            SortEngine sortEng = new SortEngine(SortEngine.SortOptions.QuickSort);
            Console.Write("Before Sort: ");
            array.ForEach(i => Console.Write($"{i} "));

            Console.Write("\nSorted Array: ");
            sortEng.Run(array).ForEach(i => Console.Write($"{i} "));

            Console.ReadKey();
        }
    }
}
