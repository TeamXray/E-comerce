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
    public class AutreController : ControllerBase
    {
        private Datacontextcs _context;
        private IAutreService _autreService;

        public AutreController(Datacontextcs context, IAutreService autreService)
        {
            _context = context;
            _autreService = autreService;
        }

        [HttpGet("affiche")]
        public IActionResult GetAll()
        {
            var autres = _autreService.GetAll();
            return Ok(autres);
        }

        [HttpGet("afiche/{id}")]
        public IActionResult GetAutreById(int id)
        {
            Autre autre = _autreService.GetAutreById(id);
            if (autre == null)
            {
                return NotFound();
            }
            return Ok(autre);
        }
        [HttpGet("affichetype/{idtype}")]
        public IActionResult GetVetByType(string autretype)
        {
            Autre autre = _autreService.GetAutreByType(autretype);

            if (autretype == null)
            {
                return NotFound();
            }

            return Ok(autre);
        }

        // POST: api/Autre/ajoutautre
        //[AllowAnonymous]
        [HttpPost("ajoutautre")]
        public IActionResult AddAutre(Autre autre)
        {

            _autreService.AddAutre(autre);


            return Ok(autre);
        }


        // PUT: api/Autre/updateautre/id
        //[AllowAnonymous]
        [HttpPut("updateautre/{id}")]
        public IActionResult UpdateAutre(int id, Autre autreupdate)
        {
            if (id != autreupdate.AutreId)
            {
                return BadRequest();
            }

            try
            {
                _autreService.UpdateAutre(autreupdate);
                return Ok(autreupdate);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_autreService.AutreExist(id))
                {
                    return NotFound();
                }

            }

            return NoContent();
        }


        // DELETE: api/Autre/deleteautre/id
        //[AllowAnonymous]
        [HttpDelete("deleteautre/{id}")]
        public ActionResult DeleteAutre(int id)
        {
            _autreService.DeleteAutre(id);
            return Ok();
        }
    }

}
