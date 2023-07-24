using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFinal6
{
    internal class A6
    {
        public void run()
        {

            int students, p = 0, t = 0;
            int[] propArr = new int[2];
            int[] proArr = new int[4];

            try
            {
                Console.Write("how many student :> ");
                students = int.Parse(Console.ReadLine());

                for (int i = 0; i < students; i++)
                {
                    Console.Write("Type of exam\t:");
                    string type = Console.ReadLine();
                    if (type.ToLower() != "t" && type.ToLower() != "p") 
                    {
                        Console.WriteLine("Input type of exam only P or T.");
                        Console.ReadKey();
                        return;
                    }
                    if (type.ToLower() == "t") t++;
                    if (type.ToLower() == "p") p++;
                    Console.Write("Exam score\t:");
                    int score = int.Parse(Console.ReadLine());
                    string result = GradeResult(type, score);
                    Console.WriteLine("Exam result\t:" + result + "\n");


                    switch (result.ToUpper())
                    {
                        case "S":
                            propArr[0]++;
                            break;
                        case "U":
                            propArr[1]++;
                            break;
                        case "A":
                            proArr[0]++;
                            break;
                        case "B":
                            proArr[1]++;
                            break;
                        case "C":
                            proArr[2]++;
                            break;
                        case "F":
                            proArr[3]++;
                            break;
                    }
                }

                Console.WriteLine("Proposal " + p + " students");
                Console.WriteLine("   S = " + propArr[0] + ", U = " + propArr[1]);
                Console.WriteLine("Project " + p + " students");
                Console.WriteLine("   A = " + proArr[0] + ", B = " + proArr[1] + ", C = " + proArr[2] + ", F = " + proArr[3]);

                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private string? GradeResult(string type, int score) 
        { 
            switch (type.ToLower())
            {
                case "p":
                    if (score >= 60) 
                    {
                        return "S";
                    }
                    return "U";

                case "t":
                    if (score >= 80)
                    {
                        return "A";
                    } else if (score >= 60)
                    {
                        return "B";
                    } else if (score >= 50) 
                    { 
                        return "C";
                    }
                    return "F";

                default: return null;
            }
        }
    }
}
