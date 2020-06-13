using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_comerce.Dbcontext;
using E_comerce.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_comerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenteFController : ControllerBase
    {

        private readonly Datacontextcs _context;
        private IventeFlashcs _flash;

        public VenteFController(Datacontextcs context, IventeFlashcs flash)
        {
            this._context = context;
            this._flash = flash;
        }




        [HttpGet("getFlash")]
        public IActionResult Getalls()
        {
            var fla = _flash.GetAllS();
            return Ok(fla);
        }

    }
}