namespace workshop1_supermarket
{
    public class FixedPriceProduct : Product
    {
        public override decimal GetValeuToPay()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return base.ToString()+
            $"\n\tvalue......: {$"{(Price + (Price * (decimal)Tax)):C2}",13}";
        }

    }
}
