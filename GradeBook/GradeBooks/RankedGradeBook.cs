using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {

        public RankedGradeBook(string name, bool IsWeight) : base(name,IsWeight)
        {
            this.Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
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
            else if (averageGrade > 60 && averageGrade <= 80)
            {
                return 'B';
            }
            else
            {
                return 'A';
            }
        }
        public override void CalculateStatistics()
        { 
          if(Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else { 
            base.CalculateStatistics();
                 } 
        }
    }
}
