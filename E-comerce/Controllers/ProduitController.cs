using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using E_comerce.Dbcontext;
using E_comerce.Entity;
using E_comerce.Services;
using E_comerce.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
namespace E_comerce.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProduitController : ControllerBase
    {
        private readonly Datacontextcs _context;
        private IProduitService _ProduitService;
        private IMapper _mapper;



        public ProduitController(Datacontextcs context, IProduitService produitService , IMapper mapper)
        {
            _context = context;
            _ProduitService = produitService;
            _mapper = mapper;

        }



        // GET: api/Produit/Affiche
        //[AllowAnonymous]
        [HttpGet("affiche")]

        public IActionResult Getall()
        {
            var produits = _ProduitService.GetAll();
            return Ok(produits);
        }




        // GET: api/Produit/Affiche/id
        //[AllowAnonymous]
        [HttpGet("affiche/{id}")]
        public IActionResult AfficheById(int id)
        {
            Produit produit = _ProduitService.GetProduitById(id);
            
            if (produit == null)
            {
                return NotFound();
            }

            return Ok(produit);
        }


        // POST: api/Produit/ajout
        // more details see https://aka.ms/RazorPagesCRUD.
        //[AllowAnonymous]
        [HttpPost("ajout")]
        public IActionResult Ajout(Produit produit )
        {
            
            _ProduitService.AddProduit(produit);


            return Ok();
        }


        // PUT: api/Produit/update/id
        // more details see https://aka.ms/RazorPagesCRUD.
        //[AllowAnonymous]
        [HttpPut("update/{id}")]
        public IActionResult PutProduit(int id, Produit produitupdate)
        {
            //var produitid = _context.produits.FirstOrDefault(x => x.id_prod == id);
            if (id != produitupdate.id_prod)
            {
                return BadRequest();
            }

            try
            {
                _ProduitService.UpdateProduit(produitupdate);
                return Ok(produitupdate);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_ProduitService.ProduitExists(id))
                {
                    return NotFound();
                }
                
            }

           return NoContent();
        }


        // DELETE: api/Produit/5
        //[AllowAnonymous]
        [HttpDelete("delete/{id}")]
        public ActionResult DeleteProduit(int id)
        {
            _ProduitService.DeleteProduit(id);
            return Ok();
        }

        
    }


}
