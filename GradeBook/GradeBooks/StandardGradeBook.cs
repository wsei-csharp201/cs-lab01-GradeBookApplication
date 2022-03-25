using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name):base(name)
        {
            Name = name;
            Students = new List<Student>();
            Type = GradeBook.Enums.GradeBookType.Standard;
        }
    }
}
