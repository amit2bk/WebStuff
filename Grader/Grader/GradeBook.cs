using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grader
{
    class GradeBook
    {

        GradeStatistics stats;

        public GradeBook()
        {
            stats = new GradeStatistics();

            stats.HigestGrade = 0;
            stats.LowestGrade = float.MaxValue;
            stats.AverageGrade = 0;
            
        }

        public GradeStatistics ComputeStatistics(List<float> gs)
        {
            float sum = 0;
            foreach (float g in gs)
            {

                if (g > stats.HigestGrade)
                {
                    stats.HigestGrade = g;
                }

                if (g < stats.LowestGrade)
                {
                    stats.LowestGrade = g;
                }

                sum = sum + g;
            }

            stats.AverageGrade = sum / gs.Count;
            return stats;
        }
    }
}
