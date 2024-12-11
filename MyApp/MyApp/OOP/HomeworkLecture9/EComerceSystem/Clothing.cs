namespace MyApp.OOP.HomeworkLecture9.EComerceSystem
{
    public class Clothing : Product
    {
        public override double GetDiscountedPrice()
        {
            double discountedPrice = Price * 0.8;
            return discountedPrice;
        }
    }
}
