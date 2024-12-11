namespace MyApp.OOP.HomeworkLecture9.EComerceSystem
{
    public class Electronics : Product
    {
        public override double GetDiscountedPrice()
        {
            double discountedPrice = Price * 0.9;
            return discountedPrice;
        }
    }
}
