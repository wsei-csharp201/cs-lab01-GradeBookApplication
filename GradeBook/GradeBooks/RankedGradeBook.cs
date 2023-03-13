using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            this.Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (this.Students.Count < 5)
                throw new InvalidOperationException("There must be at least 5 students to calculate letter grades.");

            int percentageGroupSize = (this.Students.Count + 4) / 5;
            List<double> studentsGradesInDescendingOrder = (
                                       from student in this.Students
                                       orderby student.AverageGrade descending
                                       select student.AverageGrade
                                   ).ToList();

            if (studentsGradesInDescendingOrder.ElementAt((percentageGroupSize * 1) - 1) <= averageGrade)
                return 'A';
            else if (studentsGradesInDescendingOrder.ElementAt((percentageGroupSize * 2) - 1) <= averageGrade)
                return 'B';
            else if (studentsGradesInDescendingOrder.ElementAt((percentageGroupSize * 3) - 1) <= averageGrade)
                return 'C';
            else if (studentsGradesInDescendingOrder.ElementAt((percentageGroupSize * 4) - 1) <= averageGrade)
                return 'D';
            else
                return 'F';
        }
    }
}