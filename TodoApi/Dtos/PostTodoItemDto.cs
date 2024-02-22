using System.ComponentModel.DataAnnotations;

namespace TodoApi.Dtos
{
    public class PostTodoItemDto
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        public bool Done { get; set; }
    }
}
