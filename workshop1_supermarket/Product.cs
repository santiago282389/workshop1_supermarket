namespace workshop1_supermarket
{
    public abstract class Product : IPay
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public float Tax { get; set; }

        public abstract decimal GetValeuToPay();

        public override string ToString()
        {
            return $"   {Id} {Description}" +
                   $"\n\tPrice......: {$"{Price:C2}",13}" +
                   $"\n\tTax........: {$"{Tax:P2}",15}";
        }
    }
}