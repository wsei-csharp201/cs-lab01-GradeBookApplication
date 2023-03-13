using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook: BaseGradeBook
    {
        public RankedGradeBook( string name): base(name) 
        {
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            try
            {
                if(Students.Count < 5) 
                {
                    throw new InvalidOperationException();
                }
                if (averageGrade <= 20)
                {
                    return 'F';
                }
                else if (averageGrade > 20 && averageGrade <= 40)
                {
                    return 'D';
                }
                else if (averageGrade > 40 && averageGrade <= 60)
                {
                    return 'C';
                }
                else if (averageGrade > 60 && averageGrade <= 80)
                {
                    return 'B';
                }
                else
                {
                    return 'A';
                }

            }catch(Exception ex)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
