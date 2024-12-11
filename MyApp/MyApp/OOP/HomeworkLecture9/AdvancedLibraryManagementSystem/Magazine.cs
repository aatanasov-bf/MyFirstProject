
namespace MyApp.OOP.HomeworkLecture9.AdvancedLibraryManagementSystem
{
    public class Magazine : LibraryItem, IBorrowable
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, int issueNumber) : base(title)
        {
            IssueNumber = issueNumber;
        }

        public void Borrow(string borrower, DateTime dueDate)
        {
            IsBorrowed = true;
            Borrower = borrower;
            DueDate = dueDate;
            Console.WriteLine($"Magazine '{Title}' (Issue Number) {IssueNumber} borrowed by {Borrower}, due on {DueDate.Value.ToString("dd/MM/yyyy")}\n");
        }

        public void Return()
        {
            Console.WriteLine($"{Borrower} returns magazine '{Title}' (Issue Number) {IssueNumber}\n");
            IsBorrowed = false;
            Borrower = "";
            DueDate = null;
        }
    }
}
