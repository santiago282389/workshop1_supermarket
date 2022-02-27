namespace workshop1_supermarket
{
    public class Invoice : IPay
    {
        private string _Products;

        public Invoice(string Products)
        {
            _Products = Products;
        }
        public string AddProducts()
        {
            throw new NotImplementedException();
        }
        public Invoice()
        {
            throw new NotImplementedException();
        }

        public decimal GetValeuToPay()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
