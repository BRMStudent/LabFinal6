using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFinal6
{
    internal class A4
    {
        public void run() 
        {
            A3 a3 = new A3();
            List<int> votes = new List<int>();
            int vote, i = 0;
            int[] applycants = new int[10];
            try
            {
                while (true)
                {
                    Console.Write("input data[" + (i + 1) + "] :> ");
                    vote = int.Parse(Console.ReadLine());
                    if (vote == 0) break;
                    votes.Add(vote);
                    applycants[vote]++;
                    i++;

                }
                Console.WriteLine("\n\ndata from villager : ");
                foreach (int v in votes)
                {
                    Console.Write(v + " ");
                }
                Console.WriteLine("\nscore of each applycant : ");
                for (int v = 1; v <= applycants.Length - 1; v++)
                {
                    Console.Write(applycants[v] + " ");
                }
                int headVote = a3.Max(TwoMaxVote(applycants));
                int head = Array.IndexOf(applycants, headVote);
                Console.WriteLine("\nHead is number " + head + "\t\tvote_score is " + headVote);
                int assistantVote = a3.Min(TwoMaxVote(applycants));
                int assistant = Array.IndexOf(applycants, assistantVote);

                if (headVote == assistantVote)
                {
                    var indexs = FindIndexesOfValue(applycants, headVote);
                    assistant = indexs[1];
                }
                Console.WriteLine("Assistant is number " + assistant + "\t\tvote_score is " + assistantVote);
                Console.ReadKey();
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            


            
        }

        private int[] FindIndexesOfValue(int[] array, int value)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    count++;
            }

            int[] indexes = new int[count];
            int currentIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    indexes[currentIndex] = i;
                    currentIndex++;
                }
            }

            return indexes;
        }

        private int[] TwoMaxVote(int[] votes) 
        {
            int max1 = 0, max2 = 0;
            foreach (int v in votes)
            {
                if (v > max1)
                {
                    max2 = max1;
                    max1 = v;
                }
                else if (v > max2) 
                { 
                    max2 = v;
                }
            }

            return new int[] { max1, max2 };
        }
    }
}
