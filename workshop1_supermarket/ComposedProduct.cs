namespace workshop1_supermarket
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public List<Product> Products { get; set; }

        public override decimal GetValeuToPay()
        {
            decimal des = 0;
            foreach (Product product in Products)
            {
                des += product.GetValeuToPay();
            };
            return des - (des * (decimal)Discount);
        }
        public override string ToString()
        {
            string asistent = "";
            foreach (Product product in Products)
            {
                asistent += product.Description + ", ";
            }
            return $"   {Id} {Description}" +
                   $"\n\tProducts...: {$"{asistent:C2}",13}" +
                   $"\n\tDiscount...: {$"{Discount:P2}",15}" +
                   $"\n\tvalue...:    {$"{GetValeuToPay():C2}",13}";
        }
    }
}
