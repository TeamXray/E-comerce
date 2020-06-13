using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_comerce.Dbcontext;
using E_comerce.Entity;
using E_comerce.Services;
using E_comerce.Setting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_comerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {

        private readonly Datacontextcs _context;
        private CardService _scartService;


         public CartController(Datacontextcs context, CardService scartService)
        {
            this._context = context;
            this._scartService = scartService;
        }




        [HttpGet("cart/{id}")]
        public IActionResult Getalls(int id)
        {
            var cart = _scartService.GetCart(id);
       
                return Ok(cart);
            
        }


        [HttpGet("cartuser/{id}")]
        public IActionResult GetcartUser(int id)
        {
            var cart = _scartService.GetCarte(id);

            return Ok(cart);

        }

        [HttpPost("addtoCarte")]
        public IActionResult Create([FromBody] Cart cart )
        {

            try
            {
                _scartService.creatcart(cart);

                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("update/{id}")]
        public IActionResult update(int  id)
        {

            var cart = _scartService.updateCart(id);

            return Ok(cart);
        }



    }
}