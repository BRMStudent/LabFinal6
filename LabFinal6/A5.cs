using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFinal6
{
    internal class A5
    {
        public void run() {
            int size;
            int[] arr1;
            int[] arr2;
            int sumdp = 0;
            try 
            {
                Console.Write("how many number :> ");
                size = int.Parse(Console.ReadLine());
                arr1 = new int[size];
                arr2 = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write("input data1[" + (i + 1) + "] :> ");
                    arr1[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("\n----------------------------------------------");

                for (int i = 0; i < size; i++)
                {
                    Console.Write("input dat2[" + (i + 1) + "] :> ");
                    arr2[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                for (int i = 0; i < size; i++) 
                {
                    int dp = DiffPower(arr1[i], arr2[i]);
                    sumdp += dp;
                    Console.WriteLine("data1[" + arr1[i] + "] - data2[" + arr2[i] + "] = " + dp);
                }
                Console.WriteLine("----------------------------------------------\n");
                Console.WriteLine("Sum of Diff-Squre is {0}", sumdp);


                Console.ReadKey();
            } catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        private int DiffPower(int num1, int num2) {
            return (num1 - num2) * (num1 - num2);
        }
    }
}
