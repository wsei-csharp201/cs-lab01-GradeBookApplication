using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook (string name) : base(name)
        {
            Name = name;
            Type = GradeBookType.Standard;
        }
    }
}
