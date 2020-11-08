using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWighted) : base(name, isWighted)
        {
            Type = GradeBookType.Standard;
        }
    }
}
