using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/pessoa")]
    public class PessoaController : ControllerBase
    {
        private readonly DataContext _context;
        public PessoaController(DataContext context)
        {
            _context = context;
        }

        //POST: api/pessoa/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
            return Created("", pessoa);
        }

        //GET: api/pessoa/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Pessoas.ToList());


        // DELETE: api/pessoa/delete/Breno
        [HttpDelete]
        [Route("delete/{nome}")]
        public IActionResult Delete([FromRoute] string nome)
        {
            Pessoa pessoa = _context.Pessoas.FirstOrDefault
            (
                e => e.Nome == nome
            );
            if (pessoa == null)
            {
                return NotFound();
            }
            _context.Pessoas.Remove(pessoa);
            _context.SaveChanges();
            return Ok();
        }
    }
}