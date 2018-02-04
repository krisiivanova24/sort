using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 4, 2, 3, 5, 6, 9, 8, 1, 7 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int x = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = x;
                    }
                }
            }
            Console.WriteLine(string.Join("-", arr));
        }
    }
}
