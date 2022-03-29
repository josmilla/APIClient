using Microsoft.AspNetCore.Mvc;
using APIClient.Infrastructure.Data.Entities;
using APIClient.Infrastructure.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace APIClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsignacionController : ControllerBase
    {
        private readonly IAsignacionRepository _asignacionRepository;
        public AsignacionController(IAsignacionRepository asignacionRepository)
        {
            _asignacionRepository = asignacionRepository;
        }

        // GET: api/<AsignacionController>
        [HttpGet]
        public async Task<IEnumerable<Asignacion>> GetAsignacionAsync()
        {
            return await _asignacionRepository.GetAsignacionAsync();
        }

        // GET api/<AsignacionController>/5

        [HttpGet("{id}", Name = "GetAsignacionAsync")]
        public async Task<ActionResult<Asignacion>> GetAsignacionByIdAsync(Guid id)
        {
            var clsasignacion = await _asignacionRepository.GetAsignacionByIdAsync(id);
           // return await _asignacionRepository.GetAsignacionByIdAsync(id);

            if (clsasignacion == null)
            {
                return NotFound();
            }

            return clsasignacion;
        }

     


        //// GET api/<AsignacionMatriculaController>/5
        //[HttpGet("{matricula}", Name = "GetMatricula")]
        //public async Task<Asignacion> GetMatriculaAsync( string matricula)
        //{
        //    return await _asignacionRepository.GetAsignacionByMatriculaAsync(matricula);
        //}


        // POST api/<AsignacionController>
        [HttpPost]
        //[Route("api/Asignacion/Create")]
        public async Task<IActionResult> PostAsync([FromBody] Asignacion asignacion)
        {
            var result = await _asignacionRepository.InsertAsync(asignacion);
            return CreatedAtRoute("GetAsignacionAsync", new { id = result.Id }, result);
        }

        // PUT api/<AsignacionController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(Guid id, [FromBody] Asignacion asignacion)
        {
            var result = await _asignacionRepository.UpdateAsync(id, asignacion);
            return Ok(result);
            //return RedirectToAction(nameof(Index));
        }

        // DELETE api/<AsignacionController>/5
        [HttpDelete("{id}")]
        //[Route("api/Asignacion/Delete/{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var result = await _asignacionRepository.DeleteAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            return NoContent();
        }


    }
}
