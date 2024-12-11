namespace MyApp.OOP.HomeworkLecture9.EComerceSystem
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine("Product Details");
            Console.WriteLine($"Product name: {Name}");
            Console.WriteLine($"Product price {Price.ToString("0.00")}");
            Console.WriteLine($"Product discounted price: {GetDiscountedPrice().ToString("0.00")}");
        }
        public abstract double GetDiscountedPrice();
    }
}
