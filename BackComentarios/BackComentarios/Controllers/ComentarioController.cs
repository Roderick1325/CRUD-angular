using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackComentarios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackComentarios.Controllers
{
    [Route("api/[controller]")]
    public class ComentarioController : Controller
    {
        private readonly AplicationDbContext _context;
        public ComentarioController(AplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/values
        [HttpGet]
        public ActionResult<List<Comentario>> Get()
        {
            try
            {
                var listComentario = _context.Comentario.ToList();
                return Ok(listComentario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Comentario> Get(int id)
        {
            try
            {
                var comentario = _context.Comentario.Find(id);
                if(comentario == null)
                {
                    return NotFound();
                }
                return Ok(comentario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Comentario comentario)
        {
            try
            {
                _context.Add(comentario);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Comentario comentario)
        {
            try
            {
                if(id != comentario.Id)
                {
                    return BadRequest();
                }
                else
                {
                    _context.Entry(comentario).State = EntityState.Modified;
                    _context.Update(comentario);
                    _context.SaveChanges();
                    return Ok();
                }  
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var comentario = _context.Comentario.Find(id);
                if(comentario == null)
                {
                    return NotFound();
                }
                else
                {
                    _context.Remove(comentario);
                    _context.SaveChanges();
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
