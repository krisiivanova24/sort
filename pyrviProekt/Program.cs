using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyrviProekt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 4, 2, 3, 5, 6, 9, 8, 1, 7 };
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int k = i;
                for (int j = i +1; j < arr.Length; j++)
                {
                    
                    if (arr[k] > arr[j])//razmqna
                    {
                        k = j;
                    }
                }
                    int x = arr[i];
                    arr[i] = arr[k];
                    arr[k] = x;
                
            }
            Console.WriteLine(string.Join("-", arr));
        }
    }
}
