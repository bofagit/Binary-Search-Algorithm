using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search_alrgorithms
{
    internal class Program
    {
        static int Find_Midpoint(int a, int b)
        {
            int mid = (a + b) / 2;
            return mid;
        }
        public static object BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = Find_Midpoint(min, max);
                if (key == inputArray[mid])
                {
                    return ++mid - 1;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return "Nil";
        }

        static void Main(string[] args)
        {
            Random random_num = new Random();
            int [] random_arr = new int[20];
            int search = 0;
            bool handling = false;
            for (int i = 0; i < 20; i++)
            {
                random_arr[i] = random_num.Next(1, 100);
                
            }
            Array.Sort(random_arr);
            for (int i = 0; i < random_arr.Length; i++)
            {
                Console.WriteLine("Index {0} is = {1}", i, random_arr[i]);
            }
            Console.WriteLine("Enter a number to search the array with");
            while (handling == false)
            {
                try
                {
                    search = int.Parse(Console.ReadLine());
                    handling = true;
                }
                catch
                {
                    Console.WriteLine("Only input numbers into here.");
                }
            }
            Console.WriteLine("Your search was at index {0}", BinarySearchIterative(random_arr, search));
            Console.ReadLine();
            
    


        }
    }
}
