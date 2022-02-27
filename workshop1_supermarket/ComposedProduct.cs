namespace workshop1_supermarket

{
    public class ComposedProduct : Product
    {       
        public float Discount { get; set; }

        public List<Product> Products { get; set; }

        public override decimal GetValeuToPay()
        {
            decimal descriptions = 0;
            decimal values = 0;
            foreach (Product product in Products)
            { 
            descriptions += product.GetValeuToPay();
            }
            values += descriptions - (descriptions * (decimal)Discount);
            return values;
        }

        private string asistent;
        public override string ToString()
           
        {
            foreach (Product product in Products)
            {
                asistent += product.Description + ", ";
            }
            return $"   {Id} Ancheta #1" +
                   $"\n\tProducts...: {$"{asistent:C2}",13}" +
                   $"\n\tDiscount...: {$"{Discount:P2}",15}";
                   //$"\n\tvalue...:    {$"{values:C2}",15}";

        }

    }
}
