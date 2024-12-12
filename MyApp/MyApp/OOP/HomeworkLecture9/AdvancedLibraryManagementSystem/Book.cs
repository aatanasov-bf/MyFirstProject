
namespace MyApp.OOP.HomeworkLecture9.AdvancedLibraryManagementSystem
{
    public class Book : LibraryItem
    {
        public string Author { get; set; }

        public Book(string title, string author) : base (title)
        {
            Author = author;
        }

        protected override void OnBorrowedMessage()
        {
            Console.WriteLine($"Book '{Title}' by {Author} borrowed by {Borrower}, due on {DueDate.ToString("dd/MM/yyyy")}\n");
        }

        protected override void OnReturnedMessage()
        {
            Console.WriteLine($"{Borrower} returns book '{Title}' by {Author}\n");
        }
    }
}
