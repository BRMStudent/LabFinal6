using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFinal6
{
    internal class A2
    {
        public void run()
        {
            int size;
            double[] arr;
            double data;
            double sum = 0;
             
            try 
            {
                Console.Write("how many number :> ");
                size = int.Parse(Console.ReadLine());
                arr = new double[size];

                for (int i = 0; i < size; i++) 
                {
                    Console.Write("input data[" + (i+1) + "] :> ");
                    arr[i] = double.Parse(Console.ReadLine());
                }

                Console.Write("input data to search :> ");
                data = double.Parse(Console.ReadLine());
                Console.WriteLine("\nindex");
                for (int i = 0; i < size; i++) 
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine("\n");
                for (int i = 0; i < size; i++)
                {
                    Console.Write(arr[i] + "\t");
                }

                double[] res = Array.FindAll(arr, e => e == data);
                
                sum = res.Sum();
                //ArraySum(res);

                Console.WriteLine("\n\ndata\tsum");
                Console.WriteLine(data + "\t" + sum);
                Console.ReadKey();
                Array.IndexOf(arr, data, 1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        private double ArraySum(double[] data)
        {
            double sum = 0;
            foreach (double e in data)
            {
                sum += e;
            }
            return sum;
        }
    }
}
