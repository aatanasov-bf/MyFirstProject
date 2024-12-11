namespace MyApp.OOP.HomeworkLecture9.AdvancedLibraryManagementSystem
{
    public interface IBorrowable
    {
        public void Borrow(string borrower, DateTime dueDate);
        void Return();
    }
}
