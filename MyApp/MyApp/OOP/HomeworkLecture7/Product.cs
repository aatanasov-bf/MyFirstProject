namespace MyApp.OOP.HomeworkLecture7
{
    public class Product
    {
        public string Name;
        public decimal Price;
        public int Quantity;

        public Product()
        {
            this.Name = "Default";
            this.Price = 0;
            this.Quantity = 0;
        }

        public Product(string name, decimal price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public decimal CalculateTotalCost()
        {
            decimal totalCost = 0;
            totalCost = Price * Quantity;
            return totalCost;
        }
    }
}
