using API_ListaTarefas.Data;
using API_ListaTarefas.Data.Dtos;
using API_ListaTarefas.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_ListaTarefas.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TarefasController : ControllerBase
{
    private TarefaContext _context;

    public TarefasController(TarefaContext tarefasContext)
    {
        _context = tarefasContext;
    }

    [HttpPost]
    public IActionResult AdicionaTarefa([FromBody] CriaTarefaDto tarefaDto)
    {
        Tarefa tarefa = new Tarefa 
        { 
            Title = tarefaDto.Title,
            Description = tarefaDto.Description,
            Completed = tarefaDto.Completed,
        };

        try
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return Ok(tarefa);
    }

    [HttpGet]
    public IEnumerable<Tarefa> ListaTarefas()
    {
        return _context.Tarefas;
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaTarefa(int id, [FromBody] AlteraTarefaDto tarefaDto)
    {
        Tarefa? tarefa = _context.Tarefas.FirstOrDefault(t => t.Id == id);

        if(tarefa == null)
            return NotFound();

        tarefa.Title = tarefaDto.Title;
        tarefa.Description = tarefaDto.Description;
        tarefa.Completed = tarefaDto.Completed;

        try
        {
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult ExcluiTarefa(int id)
    {
        Tarefa? tarefa = _context.Tarefas.FirstOrDefault(t => t.Id == id);

        if (tarefa == null)
            return NotFound();

        try
        {
            _context.Remove(tarefa);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return NoContent();
    }
}

