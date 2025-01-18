using System.ComponentModel.DataAnnotations;

namespace TaskTracker.Model
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public string? Descripcion { get; set; }
    }
}
