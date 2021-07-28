using AutoMapper;
using ShoppincCard.Domain.Entities;
using static ShoppingCard.API.Dtos;

namespace ShoppingCard.API.Mapper
{
    public class DomainToDTO:Profile
    {
        public DomainToDTO()
        {
            CreateMap<Basket, BasketDTO>();
            CreateMap<BasketItem, BasketItemDTO>();
        }
    }
}
