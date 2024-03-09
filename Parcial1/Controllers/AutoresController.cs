using Microsoft.AspNetCore.Mvc;
using Parcial1.Models;

namespace Parcial1.Controllers
{
    public class AutoresController : Controller
    {
        public Parcial1aContext _parcial1AContext1;
        public AutoresController(Parcial1aContext parcial1AContext)
        {
            _parcial1AContext1 = parcial1AContext;
        }

        [HttpGet]
        [Route("autores")]
        public IActionResult Index()
        {
            List<Autore> autores = (from e in _parcial1AContext1.Autores select e).ToList();

            if (autores.Count()==0)
            {
                return NotFound();

            }
            else
            {
                return Ok(autores);
            }
            
        }
    }
}
