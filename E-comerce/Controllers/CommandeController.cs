using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_comerce.Dbcontext;
using E_comerce.Entity;
using E_comerce.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_comerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandeController : ControllerBase
    {

        private readonly Datacontextcs _context;
        private CommandeService _commandeSer;



        public CommandeController(Datacontextcs context, CommandeService commandeService)
        {
            _context = context;
            _commandeSer = commandeService;

        }

        [HttpPost("ajoutC")]
        public IActionResult Ajout(Commandecs com)
        {
            try
            {
                _commandeSer.AddProduit(com);
                return Ok(com);
            }
            catch (DbUpdateConcurrencyException)
            {
                
                    return NotFound();
               

            }
         

        }


    }
}