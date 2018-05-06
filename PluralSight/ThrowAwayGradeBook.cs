using System;
using System.Collections.Generic;
using System.Text;

namespace PluralSight
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public override GradedStatistics ComputeStatistics()
        {
            Console.WriteLine("hello");
        }
    }
}
