using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(String name, bool isWeighted) : base(name, isWeighted)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
