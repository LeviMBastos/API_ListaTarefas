using System.ComponentModel.DataAnnotations;

namespace API_ListaTarefas.Models;

public class Tarefa
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O titulo da tarefa é obrigatório")]
    public string Title { get; set; }
     
    [Required(ErrorMessage = "A descrição da tarefa é obrigatório")]
    public string Description { get; set; }

    public bool Completed { get; set; }
}
