using ShoppingCard.API.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCard.API.Repository
{
    public interface IBasketRepository
    {
        Task<Basket> GetBasket(string userName);
        Task<Basket> UpdateBasket(Basket basket);
        Task DeleteBasket(string userName);
    }
}

