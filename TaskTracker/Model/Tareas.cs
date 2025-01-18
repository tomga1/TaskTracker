namespace TaskTracker.Model
{
    public class Tareas : EntityBase
    {
        
        public string? Estado { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaActualizacion { get; set; }

    }
}
