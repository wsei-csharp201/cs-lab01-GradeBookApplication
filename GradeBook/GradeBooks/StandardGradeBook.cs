using System;
using System.Collections.Generic;
using System.Text;
using DocumentFormat.OpenXml.Math;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) :base(name)
        {
            this.Type = GradeBookType.Standard;
        }
    }
}
