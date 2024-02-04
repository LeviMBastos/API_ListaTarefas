using API_ListaTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace API_ListaTarefas.Data;

public class TarefaContext : DbContext
{
    public TarefaContext(DbContextOptions<TarefaContext> opts)
        : base(opts)
    {
        
    }

    public DbSet<Tarefa> Tarefas { get; set; }
}
