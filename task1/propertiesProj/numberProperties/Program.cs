using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Inputs
            Console.WriteLine("Enter Numbers with Space Between");
            string readedLine = Console.ReadLine();

            // Split by Space

            string[] newArray = readedLine.Split(' ');

            int[] numbers = Array.ConvertAll(newArray, int.Parse);

            //Write to Console

            Console.WriteLine("The Biggest Number is:" + " " + findMax(numbers));
            Console.WriteLine("The Smallest Number is:" + " " + findMin(numbers));
            Console.WriteLine("Sum of the Numbers is:" + " " + findSum(numbers));

            //Reverse Array 

            int[] invertedArray = invertArray(numbers);

            foreach (int array in invertedArray)
            {
                Console.Write(array + " ");
            }
            Console.ReadLine();
        }


        // Methods

         static int findMax(int[] array)
        {
            if (array.Length > 0)
            {
                int biggest = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (biggest < array[i])
                    {
                        int tmp = biggest;
                        biggest = array[i];
                        array[i] = biggest;
                    }
                }
                return biggest;
            }else
             {
               return 0;
            }

        }

        static int findMin(int[] array)
        {
            if (array.Length > 0)
            {
                int smallest = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (smallest > array[i])
                    {
                        int tmp = smallest;
                        smallest = array[i];
                        array[i] = smallest;
                    }

                }
                return smallest;
            }
            else
            {
                return 0;
            }
        }

        static int findSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        static int[] invertArray(int[] array)
        {
            int[] tmp = array;
            Array.Reverse(tmp);
            return tmp;
        }
    }
}