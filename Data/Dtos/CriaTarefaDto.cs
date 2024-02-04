using System.ComponentModel.DataAnnotations;

namespace API_ListaTarefas.Data.Dtos
{
    public class CriaTarefaDto
    {
        [Required(ErrorMessage = "O titulo da tarefa é obrigatório")]
        public string Title { get;set; }

        [Required(ErrorMessage = "A descrição da tarefa é obrigatório")]
        public string Description { get;set; }

        public bool Completed { get; set; }
    }
}
