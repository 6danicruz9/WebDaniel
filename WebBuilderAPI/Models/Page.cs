namespace WebBuilderAPI.Models
{
    public class Page
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        
        // Aquí almacenaremos el array del frontend (elements) serializado
        public string ElementsJson { get; set; } = "[]"; 
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}