using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFinal6
{
    internal class A3
    {
        public void run() 
        {
            int size;
            int[] arr;
            int max, min, diff;
            try 
            {
                Console.Write("how many number :> ");
                size = int.Parse(Console.ReadLine());
                arr = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write("input data[" + (i + 1) + "] :> ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                max = Max(arr);
                min = Min(arr);
                diff = Diff(max, min);

                Console.WriteLine("\nMax is " + max);
                Console.WriteLine("Min is " + min);
                Console.WriteLine("Diff is " + diff);

                Console.ReadKey();
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int Max(int[] numbers) 
        {
            int max = 0;
            foreach (int n in numbers)
            {
                if (n > max) 
                { 
                    max = n;
                }
            }
            return max;
        }

        public int Min(int[] numbers)
        {   
            int min = numbers[0];
            foreach (int n in numbers)
            {
                if (n < min) 
                { 
                    min = n;
                }
            }
            return min;
        }

        public int Diff(int max, int min) 
        { 
            return max - min;
        }
    }
}
