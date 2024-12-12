
namespace MyApp.OOP.HomeworkLecture9.AdvancedLibraryManagementSystem
{
    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, int issueNumber) : base(title)
        {
            IssueNumber = issueNumber;
        }

        protected override void OnBorrowedMessage()
        {
            Console.WriteLine($"Magazine '{Title}' (Issue Number) {IssueNumber} borrowed by {Borrower}, due on {DueDate.ToString("dd/MM/yyyy")}\n");
        }

        protected override void OnReturnedMessage()
        {
            Console.WriteLine($"{Borrower} returns magazine '{Title}' (Issue Number) {IssueNumber}\n");
        }
    }
}
