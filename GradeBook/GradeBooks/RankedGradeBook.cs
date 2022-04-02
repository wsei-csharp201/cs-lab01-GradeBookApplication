﻿using System;
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
                if (Student.AverageGrade >= averageGrade)
                    howMany++;
            }
            double avg = (double)howMany / (double)studentCount;
            avg = avg * 100;
            if (avg <= 20)
                return 'A';
            if (avg <= 40)
                return 'B';
            if (avg <= 60)
                return 'C';
            if (avg <= 80)
                return 'D';
            return 'F';

            


        }
    }
}
