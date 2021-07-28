using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppincCard.Domain.Entities;
using ShoppingCard.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using static ShoppingCard.API.Dtos;

namespace ShoppingCard.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ShoppingController : ControllerBase
    {
        private readonly IBasketRepository _repository;
        private readonly IMapper _mapper;

        public ShoppingController(IBasketRepository repository,IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper;
        }

        [HttpGet("{userName}", Name = "GetBasket")]
        [ProducesResponseType(typeof(Basket), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Basket>> GetBasket(string userName)
        {
            var basket = await _repository.GetBasket(userName);
           
            return Ok(_mapper.Map<BasketDTO>(basket) ?? new  BasketDTO(userName,null,0));
        }

        [HttpPost]
        [ProducesResponseType(typeof(Basket), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Basket>> UpdateBasket([FromBody] Basket basket)
        {
            return Ok(await _repository.UpdateBasket(basket));
        }

        [HttpDelete("{userName}", Name = "DeleteBasket")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteBasket(string userName)
        {
            await _repository.DeleteBasket(userName);
            return Ok();
        }


    }
}
