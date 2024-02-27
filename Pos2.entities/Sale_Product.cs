namespace Pos2.entities
{
    public class Sale_Product
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Sale Sale { get; set; }
    }
}
