using System.ComponentModel.DataAnnotations;

namespace API_ListaTarefas.Data.Dtos
{
    public class AlteraTarefaDto
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public bool Completed { get; set; }
    }
}
