namespace workshop1_supermarket
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }

        public float Quantity { get; set; }

        public override decimal GetValeuToPay()
        {
            decimal PriceQuanty = Price * (decimal)Quantity;
            decimal PriceQuantyTax = PriceQuanty * (decimal)Tax;
            return PriceQuanty + PriceQuantyTax;
        }

        public override string ToString()
        {
            return $"   {Id} {Description}" +
                   $"\n\tMeasurement: {Measurement}" +
                   $"\n\tQuantity...: {$"{Quantity:N2}",13}" +
                   $"\n\tPrice......: {$"{Price:C2}",13}" +
                   $"\n\tTax........: {$"{Tax:P2}",15}" +
                   $"\n\tvalue......: {$"{GetValeuToPay():C2}",13}";
        }
    }
}
