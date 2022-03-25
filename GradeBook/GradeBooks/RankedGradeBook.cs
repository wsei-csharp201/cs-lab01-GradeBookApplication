using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name):base(name)
        {
            Name = name;
            Students = new List<Student>();
            Type = GradeBook.Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            int above = 0;
            int numberOfStudents = Students.Count;
            if(numberOfStudents < 5)
            {
                throw new InvalidOperationException("");
            }

            foreach(Student student in Students)
            {
                var list = new List<double>(student.Grades);
                var currentAverage = list.Average();
                if(currentAverage > averageGrade)
                {
                    above = above + 1;
                }
            }

            if (above < 0.2 * numberOfStudents)
                return 'A';
            else if (above < 0.4 * numberOfStudents)
                return 'B';
            else if (above < 0.6 * numberOfStudents)
                return 'C';
            else if (above < 0.8 * numberOfStudents)
                return 'D';
            else
                return 'F';
        }

        public override void CalculateStatistics()
        {
            if(Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStatistics();
            } 
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}
