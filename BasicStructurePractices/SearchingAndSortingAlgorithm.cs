using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructurePractices;

public class SearchingAndSortingAlgorithm
{
    public static bool BinarySearch(int[] array, int value)
    {
        int left = 0, right = array.Length - 1, middle = 0;

        while (left <= right)
        {
            middle = (left + right) / 2;
            if (array[middle] == value)
                return true;
            else if (value < array[middle])
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return false;
    }
}
