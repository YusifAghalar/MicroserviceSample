namespace ShoppincCard.Domain.Entities
{
    public class BasketItem
    {
        public BasketItem()
        {

        }
        public BasketItem(int quantity, string color, decimal price, string productId, string productName)
        {
            Quantity = quantity;
            Color = color;
            Price = price;
            ProductId = productId;
            ProductName = productName;
        }

        public int Quantity { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
