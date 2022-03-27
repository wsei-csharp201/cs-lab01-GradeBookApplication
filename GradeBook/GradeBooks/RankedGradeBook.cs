using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(String name, bool isWeighted) : base(name, isWeighted)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if(Students.Count < 5) 
                throw new InvalidOperationException("There is less than 5 students.");

            double rank = Students.Count(student => student.AverageGrade > averageGrade) / Students.Count;
            Console.WriteLine(rank);

            if (rank < 0.2)
                return 'A';
            if (rank >= 0.2 && rank < 0.4)
                return 'B';
            if (rank >= 0.4 && rank < 0.6)
                return 'C';
            if (rank >= 0.6 && rank < 0.8)
                return 'D';
            else
                return 'F';

        }
        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else
                base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else
                base.CalculateStudentStatistics(name);
        }
    }
}
