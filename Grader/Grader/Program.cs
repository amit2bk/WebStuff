using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Grader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> grades = new List<float>();
            string path = args[0];

            List<string> lines = new List<string>();

            lines = File.ReadAllLines(path).ToList();

            foreach(string l in lines)
            {
                float grade = float.Parse(l);

                grades.Add(grade);

            }

            Program PROG = new Program();

            if (1 == int.Parse(args[1]))
            {

                Stopwatch watch = new Stopwatch();

                watch.Start();

                float high = PROG.HighestGrade(grades);
                float low = PROG.LowestGrade(grades);
                float avg = PROG.AverageGrade(grades);

                Console.WriteLine(high);
                Console.WriteLine(low);
                Console.WriteLine(avg);

                watch.Stop();

                Console.WriteLine("Time taken to execute is : " + watch.ElapsedTicks);
            }
            else
            {
                Stopwatch watch = new Stopwatch();

                watch.Start();

                GradeStatistics stats = new GradeStatistics();

                GradeBook book = new GradeBook();
                stats = book.ComputeStatistics(grades);

                Console.WriteLine(stats.AverageGrade);
                Console.WriteLine(stats.LowestGrade);
                Console.WriteLine(stats.HigestGrade);

                watch.Stop();

                Console.WriteLine("Time taken to execute is : " + watch.ElapsedTicks);
            }



        }

        public float HighestGrade(List<float> gs)
        {
            float HG = 0;

            foreach (float g in gs)
            {
                if (g > HG)
                {
                    HG = g;
                }
            }

            return HG;
        }

        public float LowestGrade(List<float> gs)
        {
            float LG = float.MaxValue;

            foreach(float g in gs)
            {
                if(g < LG)
                {
                    LG = g;
                }
            }

            return LG;
        }

        public float AverageGrade(List<float> gs)
        {
            float sum = 0;

            foreach(float g in gs)
            {
                sum = sum + g;
            }

            return sum/gs.Count;
        }

    }

        
}
 

