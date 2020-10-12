using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SortEngine
    {
        public enum SortOptions
        {
            QuickSort
        }

        private SortOptions _option;

        public SortEngine(SortOptions option)
        {
            _option = option;
        }

        public List<int> Run(List<int> array)
        {
            if (array == null || array.Count == 0)
                return array;


            List<int> _array = array;
            switch (_option)
            {
                case SortOptions.QuickSort:
                    QuickSort(ref _array, 0, _array.Count - 1);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return _array;
        }

        private void Swap(ref List<int> arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        /// <summary>
        /// Function to run quicksort on an array of integers
        /// l is the leftmost starting index, which begins at 0
        /// r is the rightmost starting index, which begins at array length - 1
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        private void QuickSort(ref List<int> arr, int l, int r)
        {
            // Base case: No need to sort arrays of length <= 1
            if (l >= r)
            {
                return;
            }

            // Choose pivot to be the last element in the subarray
            int pivot = arr[r];

            // Index indicating the "split" between elements smaller than pivot and 
            // elements greater than pivot
            int cnt = l;

            // Traverse through array from l to r
            for (int i = l; i <= r; i++)
            {
                // If an element less than or equal to the pivot is found...
                if (arr[i] <= pivot)
                {
                    // Then swap arr[cnt] and arr[i] so that the smaller element arr[i] 
                    // is to the left of all elements greater than pivot
                    Swap(ref arr, cnt,i);

                    // Make sure to increment cnt so we can keep track of what to swap
                    // arr[i] with
                    cnt++;
                }
            }

            // NOTE: cnt is currently at one plus the pivot's index 
            // (Hence, the cnt-2 when recursively sorting the left side of pivot)
            QuickSort(ref arr, l, cnt - 2); // Recursively sort the left side of pivot
            QuickSort(ref arr, cnt, r);   // Recursively sort the right side of pivot
        }
    }
}
