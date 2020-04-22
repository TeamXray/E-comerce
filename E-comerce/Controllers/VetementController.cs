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
    public class VetementController : ControllerBase
    {
        private  Datacontextcs _context;
        private IVetementService _vetementService;

        public VetementController(Datacontextcs context , IVetementService vetementService) 
        {
            _context = context;
            _vetementService = vetementService;
        }

        [HttpGet("affiche")]
        public IActionResult GetAll() 
        {
            var vetements = _vetementService.GetAll();
            return Ok(vetements);
        }

        [HttpGet("afiche/{id}")]
        public IActionResult GetVetById(int id)
        {
            Vetement vetement = _vetementService.GetVetById(id);
            if ( vetement == null)
            {
                return NotFound();
            }
            return Ok(vetement);
        }
        [HttpGet("affichetype/{idtype}")]
        public IActionResult GetVetByType (TypeV idtype)
        {
            Vetement vetementtype = _vetementService.GetVetByType(idtype);

            if (vetementtype == null)
            {
                return NotFound();
            }

            return Ok(vetementtype);
        }

        // POST: api/Vetement/ajoutvetement
        //[AllowAnonymous]
        [HttpPost("ajoutvetment")]
        public IActionResult AddVetement(Vetement vetement)
        {

            _vetementService.AddVetement(vetement);


            return Ok(vetement);
        }


        // PUT: api/Vetement/updatevetement/id
        //[AllowAnonymous]
        [HttpPut("updatevetement/{id}")]
        public IActionResult UpdateVetement(int id, Vetement vetementupdate)
        {
            if (id != vetementupdate.VetId)
            {
                return BadRequest();
            }

            try
            {
                _vetementService.UpdateVetement(vetementupdate);
                return Ok(vetementupdate);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_vetementService.VetementExist(id))
                {
                    return NotFound();
                }

            }

            return NoContent();
        }


        // DELETE: api/Vetement/deletevetment/id
        //[AllowAnonymous]
        [HttpDelete("deletevetement/{id}")]
        public ActionResult DeleteVetement(int id)
        {
            _vetementService.DeleteVetement(id);
            return Ok();
        }
    }
}