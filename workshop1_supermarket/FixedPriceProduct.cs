namespace workshop1_supermarket
{
    public class FixedPriceProduct : Product
    {
        public override decimal GetValeuToPay()
        {
            return Price + (Price * (decimal)Tax);
        }
        public override string ToString()
        {
            return base.ToString() +
            $"\n\tvalue......: {$"{GetValeuToPay():C2}",13}";
        }

    }
}
