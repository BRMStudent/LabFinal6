using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFinal6
{
    internal class A1
    {
        public void run() {
            String option;

            while (true) {
                option = ShowMenu();
                switch (option) {
                    case "1":
                        DrawLine();
                        break;
                    case "2":
                        DrawRectangle();
                        break;
                    case "3":
                        DrawTriangle();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default: continue;
                }
            }
        }

        private String ShowMenu() {
            Console.WriteLine("\n  Menu");
            Console.WriteLine("1-Line\n2-Rectangle\n3-Triangle\n4-Exit");
            Console.WriteLine("-----------");
            Console.Write("menu :> ");
            return Console.ReadLine();
        }

        public void DrawLine() {
            int width;
            while (true) {
                Console.Write("\nInput length of line :> ");
                try {
                    width = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    for (int i = width-1; i >= 0; i--) { 
                        Console.Write(i);
                    }
                    Console.WriteLine();
                    break;
                } catch (Exception) {
                    continue;
                }
            }
            Console.ReadKey();
        }
        public void DrawRectangle() { 
            int width, height;
            while (true)
            {
                try
                {
                    Console.Write("\nInput length of line :> ");
                    width = int.Parse(Console.ReadLine());
                    Console.Write("Input number of line :> ");
                    height = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    for (int i = 1; i <= height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            Console.Write(i);
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                catch (Exception) { continue; }
            }
            Console.ReadKey();
        }
        public void DrawTriangle() 
        {
            int length;
            while (true)
            {
                try
                {
                    Console.Write("\nInput width of line :> ");
                    length = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    for (int i = 0; i < length; i++) {
                        for (int j = length-1; j >= i; j--) {
                            if (j == i)
                            {
                                Console.Write(length - j);
                            }
                            else 
                            { 
                                Console.Write("*"); 
                            }
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                catch (FormatException) 
                { 
                    continue; 
                }
            }
            Console.ReadKey();
        }
    }
}
