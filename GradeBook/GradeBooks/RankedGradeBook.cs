using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool IsWeighted) : base(name, IsWeighted) 
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            try
            {
                if(Students.Count < 5)
                {
                    throw new InvalidOperationException();
                }
                if (averageGrade <= 20)
                {
                    return 'F';
                }
                else if (averageGrade > 20 && averageGrade <= 40)
                {
                    return 'D';
                }
                else if (averageGrade > 40 && averageGrade <= 60)
                {
                    return 'C';
                }
                else if(averageGrade > 60 && averageGrade <= 80)
                {
                    return 'B';
                }
                else
                {
                    return 'A';
                }
            }
            catch(Exception e)
            {
                throw new InvalidOperationException();
            }
        }

        public override void CalculateStatistics()
        {
            if(Students.Count < 5)
            {
                Console.WriteLine($"Ranked grading requires at least 5 students.");
                return;
            }
            base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine($"Ranked grading requires at least 5 students.");
                return;
            }
            base.CalculateStudentStatistics(name);
        }
    }
}
