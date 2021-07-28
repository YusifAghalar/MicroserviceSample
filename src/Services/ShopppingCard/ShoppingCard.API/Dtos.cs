using ShoppincCard.Domain.Entities;
using System.Collections.Generic;

namespace ShoppingCard.API
{
    public class Dtos 
    {
        public record BasketDTO(string Username, List<BasketItem> Items,decimal Total);
        public record BasketItemDTO(int Quantity, string Color, decimal Price, string ProductId, string ProductName);
    }
}
