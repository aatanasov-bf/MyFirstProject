using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace MyApp.OOP.HomeworkLecture9.AdvancedLibraryManagementSystem
{
    public class Libray
    {
        List<LibraryItem> libraryItems = new List<LibraryItem>();
        Dictionary<string, int> borrowerItemsCount = new Dictionary<string, int>();
        const int BorrowLimit = 3;

        public void AddItemToLibrary(LibraryItem item)
        {
            libraryItems.Add(item);
        }

        public void BorrowItemFromLibrary(string title, string borrower, DateTime dueDate)
        {
            LibraryItem item = libraryItems.FirstOrDefault(x => x.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (item == null)
            {
                Console.WriteLine($"'{title}' not found in the library!");
                return;
            }

            if (!borrowerItemsCount.ContainsKey(borrower))
                borrowerItemsCount[borrower] = 0;

            if (borrowerItemsCount[borrower] >= BorrowLimit)
            {
                Console.WriteLine($"{borrower} reached the borrowing limit of {BorrowLimit} items");
                return;
            }

            if (item.IsBorrowed)
            {
                Console.WriteLine($"'{item.Title}' already borrowed by {item.Borrower} due on {item.DueDate.ToString("dd/MM/yyyy")}");
                return;
            }

            item.Borrow(borrower, dueDate);
            if (item.IsBorrowed && item.Borrower.Equals(borrower, StringComparison.OrdinalIgnoreCase))
                borrowerItemsCount[borrower]++;
        }

        public void ReturnItemToLibrary(string title)
        {
            LibraryItem item = libraryItems.FirstOrDefault(x => x.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (item == null)
            {
                Console.WriteLine($"'{title}' not found in the library!");
                return;
            }

            if (!item.IsBorrowed)
            {
                Console.WriteLine($"'{item.Title}' is already returned");
                return;
            }

            if (item.IsBorrowed)
            {
                string borrower = item.Borrower;
                item.Return();
                borrowerItemsCount[borrower]--;
            }
        }

        public void ExtendItemDueDate(string title, int days)
        {
            LibraryItem item = libraryItems.FirstOrDefault(x => x.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (item == null)
            {
                Console.WriteLine($"'{title}' not found in the library!");
                return;
            }

            if (item.IsBorrowed)
            {
                item.ExtendDueDate(days);
            }
        }

        public void DisplayLibrayItems()
        {
            Console.WriteLine("Library Items Status");

            foreach (LibraryItem item in libraryItems)
            {
                item.CheckStatus();
            }
            
            List<LibraryItem> overdueItems = new List<LibraryItem>();
            foreach (LibraryItem item in libraryItems)
            {
                if (item.IsBorrowed && item.DueDate < DateTime.Today)
                    overdueItems.Add(item);
            }

            Console.WriteLine("List of overdue items");
            if (overdueItems.Count == 0)
                Console.WriteLine("There are no overdue items");
            foreach(LibraryItem item in overdueItems)
                Console.WriteLine($"Overdue: {item.Title}, borrowed by {item.Borrower} was due on {item.DueDate.ToString("dd/MM/yyyy")}\n");
        }
    }
}
