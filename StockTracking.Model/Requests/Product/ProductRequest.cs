namespace StockTracking.Model.Requests.Product
{
    public class ProductRequest
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
    }
}
