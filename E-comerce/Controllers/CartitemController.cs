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
    public class CartitemController : ControllerBase
    {

        private readonly Datacontextcs _context;
        private cartItemServicecs _scartService;


        public CartitemController(Datacontextcs context, cartItemServicecs scartService)
        {
            this._context = context;
            this._scartService = scartService;
        }



        [HttpPost("additem")]
        public IActionResult Create([FromBody] Cartitem cart)
        {

            try
            {
                _scartService.creatcartitem(cart);

                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }


        [HttpDelete("deleteitem/{id}")]
        public ActionResult DeleteProduit(int id)
        {
            _scartService.DeleteItem(id);
            return Ok();
        }

    }
}