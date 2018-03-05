using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class Program
    {
        public static void LeftRotate(int[] array, int items, int size)
        {
            int[] temp = new int[size];
            for (int i = 0; i < size; i++)
            {
               temp[i] = array[(i + items) % size];
            }
            for (int i = 0; i < size; i++)
            {
                array[i] = temp[i];               
            }            
        }

        public static void PrintArray(int[] array)
        {
            foreach (var t in array)
            {
                Console.Write(t + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7};
            int size = 7;
            int items = 2;
            LeftRotate(array, items, size);
            PrintArray(array);
            Console.ReadLine();
        }
    }
}
