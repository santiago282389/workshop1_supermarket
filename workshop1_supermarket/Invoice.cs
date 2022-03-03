namespace workshop1_supermarket

{
    public class Invoice : IPay
    {

        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);           
        }

        public decimal GetValeuToPay()
        {
            decimal sum = 0;
            foreach (Product product in _products)
            {
                sum += product.GetValeuToPay();
            };
            return sum;
        }     

        public override string ToString()
        {
            Console.WriteLine(" RECEIPT " +
                              "\n -------------------------------------------------");
            foreach (Product product in _products)
            {
                Console.WriteLine(product.ToString());
            }
            return $"              ====================" +
            $"\n TOTAL:    {$"{GetValeuToPay():C2}",23}";
        }
    }
}
