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
    public class TechnologieController : ControllerBase
    {
        private Datacontextcs _context;
        private ITechnologieService _technologieService;

        public TechnologieController(Datacontextcs context, ITechnologieService technologieService)
        {
            _context = context;
            _technologieService = technologieService;
        }
        // GET: ALL (api/Technologie/affiche)
        [HttpGet("affiche")]
        public IActionResult GetAllTec()
        {
            var technologie = _technologieService.GetAllTec();
            return Ok(technologie);
        }
        // GET: by id  (api/Technologie/affiche/id)
        [HttpGet("afiche/{id}")]
        public IActionResult GetTecById(int id)
        {
            Technologie technologie = _technologieService.GetTecById(id);
            if (technologie == null)
            {
                return NotFound();
            }
            return Ok(technologie);
        }
        // GET: by type  (api/Technologie/affiche/idtype)
        [HttpGet("affichetype/{idtype}")]
        public IActionResult GetTecByType(TypeT idtype)
        {
            Technologie technologietype = _technologieService.GetTecByType(idtype);

            if (technologietype == null)
            {
                return NotFound();
            }

            return Ok(technologietype);
        }

        // POST: api/Technologie/ajouttechnologie
        //[AllowAnonymous]
        [HttpPost("ajouttechnologie")]
        public IActionResult AddTechnologie(Technologie technologie)
        {

            _technologieService.AddTechnologie(technologie);


            return Ok(technologie);
        }


        // PUT: api/Technologie/updatetechnologie/id
        //[AllowAnonymous]
        [HttpPut("updatetechnologie/{id}")]
        public IActionResult UpdateTechnologie(int id, Technologie technologieupdate)
        {
            //var produitid = _context.produits.FirstOrDefault(x => x.id_prod == id);
            if (id != technologieupdate.TechId)
            {
                return BadRequest();
            }

            try
            {
                _technologieService.UpdateTechnologie(technologieupdate);
                return Ok(technologieupdate);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_technologieService.technologieExist(id))
                {
                    return NotFound();
                }

            }

            return NoContent();
        }


        // DELETE: api/Technologie/delettechnologie/id
        //[AllowAnonymous]
        [HttpDelete("delettechnologie/{id}")]
        public ActionResult DeleteTechnologie(int id)
        {
            _technologieService.DeleteTechnologie(id);
            return Ok();
        }
    }
}
