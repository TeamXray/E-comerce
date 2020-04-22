using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_comerce.Dbcontext;
using E_comerce.Entity;
using E_comerce.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_comerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorieController : ControllerBase
    {
        private readonly Datacontextcs _context;
        private ICategorieService _CategorieService;

        public CategorieController (Datacontextcs context , ICategorieService categorieService) 
        {
            _context = context;
            _CategorieService = categorieService;
        }

        [HttpGet("allcateg")]
        public IActionResult Getall()
        {
            var categorie = _CategorieService.GetAll();
            return Ok(categorie);

        }


    }
}