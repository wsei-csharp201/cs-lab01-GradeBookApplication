using System;
using System.Collections.Generic;
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
    }
}
