
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class SixPointGradeBook : BaseGradeBook
    {
        public SixPointGradeBook(string name) : base(name, false)
        {
            Type = GradeBookType.SixPoint;
        }
    }
}
