namespace workshop1_supermarket
    
{
    public class Invoice : IPay
    {
        private decimal _Products;

        public Invoice(decimal Products)
        {
            _Products = Products;
        }
        public string AddProducts()
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
