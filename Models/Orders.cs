namespace MUSbookingTask.Models
{
    public class Orders
    {

        public Orders Order { get; set; }

        public Guid Id { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public decimal Price { get; set; }

        public string Equipment { get; set; }
    }
}
