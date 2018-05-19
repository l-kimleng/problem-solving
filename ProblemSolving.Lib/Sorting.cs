using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Lib
{
    public static class Sorting
    {
        public static int[] SelectionSort(int[] elements)
        {
            for (var i = 0; i < elements.Length; i++)
            {
                var minIndex = i;
                var minValue = elements[minIndex];
                for (var j = i + 1; j < elements.Length; j++)
                {
                    if (elements[j] < minValue)
                    {
                        minIndex = j;
                        minValue = elements[j];
                    }
                }

                Swap(elements, i, minIndex);
            }

            return elements;
        }

        public static int[] InsertionSort(int[] elements)
        {
            for (var i = 1; i < elements.Length; i++)
            {
                var j = i;
                while (j > 0 && elements[j] < elements[j-1])
                {
                    Swap(elements, j, j-1);
                    j--;
                }
            }
            return elements;
        }

        private static void Swap(int[] elements, int firstIndex, int secondIndex)
        {
            if (elements[firstIndex] != elements[secondIndex])
            {
                elements[firstIndex] = elements[firstIndex] + elements[secondIndex];
                elements[secondIndex] = elements[firstIndex] - elements[secondIndex];
                elements[firstIndex] = elements[firstIndex] - elements[secondIndex];
            }
        }
    }
}
