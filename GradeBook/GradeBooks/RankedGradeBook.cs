using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            var allStudents = Students.Count;

            if (allStudents < 5)
            {
                throw new InvalidOperationException();
            }

            var studentsWithHigherAverageGrade = 0;

            foreach(Student student in Students)
            {
                if (student.AverageGrade >= averageGrade) studentsWithHigherAverageGrade++;
            }

            var percentageOfStudentsWithHigherAverage = Decimal.Divide(studentsWithHigherAverageGrade, allStudents) * 100;
            var studentsPercentage = (100 - percentageOfStudentsWithHigherAverage);

            switch (studentsPercentage)
            {
                case decimal percentage when (studentsPercentage >= 80):
                    return 'A';
                case decimal percentage when (studentsPercentage < 80 && studentsPercentage >= 60):
                    return 'B';
                case decimal percentage when (studentsPercentage < 60 && studentsPercentage >= 40):
                    return 'C';
                case decimal percentage when (studentsPercentage < 40 && studentsPercentage >= 20):
                    return 'D';
                default:
                    return 'F';
            }
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
                return;
            }

            base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
                return;
            }

            base.CalculateStudentStatistics(name);
        }
    }
}