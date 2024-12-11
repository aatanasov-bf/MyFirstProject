namespace MyApp.OOP.HomeworkLecture9.AdvancedLibraryManagementSystem
{
    public abstract class LibraryItem
    {
        public string Title { get; set; }
        public bool IsBorrowed { get; set; }
        public string Borrower {  get; set; }
        public DateTime? DueDate { get; set; }

        public LibraryItem(string title)
        {
            Title = title;
        }

        public void CheckStatus()
        {
            if (IsBorrowed)
                Console.WriteLine($"Title: {Title}, Borrowed by {Borrower}, Due on {DueDate.Value.ToString("dd/MM/yyyy")}");
            else
                Console.WriteLine($"Title: {Title}, Available for borrowing");
        }
        
        public void ExtendDueDate(int days)
        {
            if (IsBorrowed)
                DueDate = DueDate.Value.AddDays(days);
            else
                Console.WriteLine("The books is not borrowed!\n");
        }
    }
}
