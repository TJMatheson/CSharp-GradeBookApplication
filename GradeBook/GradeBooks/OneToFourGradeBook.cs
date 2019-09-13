
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class OneToFourGradeBook : BaseGradeBook
    {
        public OneToFourGradeBook(string name) : base(name)
        {
            Type = GradeBookType.OneToFour;
        }
    }
}
