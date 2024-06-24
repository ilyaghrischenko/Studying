namespace Lesson_5.Models.Product
{
    public class Book : Product
    {
        public uint ChapterCount { get; set; }
        public uint PagesCount { get; set; }

        public Book(string name, string developer, decimal price, uint chapterCount, uint pagesCount) : base(name, developer, price)
        {
            ChapterCount = chapterCount;
            PagesCount = pagesCount;
        }

        public override string ToString()
        {
            return base.ToString() + $", Chapter count: {ChapterCount}, PagesCount: {PagesCount}";
        }
    }
}
