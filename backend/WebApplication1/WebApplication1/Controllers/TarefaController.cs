using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services.Interfaces;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaService _tarefaService;

        public TarefaController(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [HttpGet]
        public ActionResult<List<Tarefa>> Get()
        {
            return _tarefaService.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Tarefa> Get(int id)
        {
            var tarefa = _tarefaService.GetById(id);
            if (tarefa == null)
            {
                return NotFound();
            }
            return tarefa;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Tarefa novaTarefa)
        {
            _tarefaService.Add(novaTarefa);
            return CreatedAtAction(nameof(Get), new { id = novaTarefa.Id }, novaTarefa);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Tarefa tarefaAtualizada)
        {
            var tarefaExistente = _tarefaService.GetById(id);
            if (tarefaExistente == null)
            {
                return NotFound();
            }
            _tarefaService.Update(tarefaAtualizada);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var tarefaExistente = _tarefaService.GetById(id);
            if (tarefaExistente == null)
            {
                return NotFound();
            }
            _tarefaService.Delete(id);
            return NoContent();
        }
    }
}
