using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) :base(name)
        {
            Name = name;
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            int studentCount = Students.Count;
            int howMany = 0;
            if (studentCount < 5)
                throw new InvalidOperationException();

            foreach (var Student in Students)
            {
                if (Student.AverageGrade > averageGrade)
                    howMany++;
            }
            double avg = (howMany / studentCount) * 100;
            if (avg > 20)
            {
                return 'A';
            }
            else if (avg <= 20 && avg > 40)
            {
                return 'B';
            } else if(avg <= 40 && avg > 60)
            {
                return 'C';
            } else if(avg <= 60 && avg > 80)
            {
                return 'E';
            } else
            {
                return 'F';
            }


        }
    }
}
