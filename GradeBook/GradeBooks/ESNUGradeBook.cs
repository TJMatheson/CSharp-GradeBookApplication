
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class ESNUGradeBook : BaseGradeBook
    {
        public ESNUGradeBook(string name) : base(name, false)
        {
            Type = GradeBookType.ESNU;
        }
    }
}
