namespace workshop1_supermarket
   
{
    public class ComposedProduct : Product
 
    {
        public float Discount { get; set; }

        public int Products { get; set; }

        public override decimal GetValeuToPay()
        {

            throw new NotImplementedException();
        }
        public override string ToString() 
        {
            return $"   {Id} Ancheta #1" +
                   $"\n\tProducts...: {$"{0:C2}",13}" +
                   $"\n\tDiscount...: {$"{Discount:P2}",15}" ;
                  // $"\n\tvalue......: {$"{product1 + product2 + product3 + product4:C2}",13}";

        }

    }
}
