
namespace MyApp.OOP.HomeworkLecture9.AdvancedLibraryManagementSystem
{
    public class Book : LibraryItem, IBorrowable
    {
        public string Author { get; set; }

        public Book(string title, string author) : base (title)
        {
            Author = author;
        }

        public void Borrow(string borrower, DateTime dueDate)
        {
            Borrower = borrower;
            DueDate = dueDate;
            IsBorrowed = true;
            Console.WriteLine($"Book '{Title}' by {Author} borrowed by {Borrower}, due on {DueDate.Value.ToString("dd/MM/yyyy")}\n");
        }

        public void Return()
        {
            Console.WriteLine($"{Borrower} returns book '{Title}' by {Author}\n");
            IsBorrowed = false;
            Borrower = "";
            DueDate = null;
        }
    }
}
