namespace Pos2.entities
{
    public class Sale
    {
        public int Id { get; set; }
        public int TotalPrice { get; set; }
        public int Discount { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public List<Sale_Product> SalesProducts { get; set; }

    }
}
