namespace Azure.Pipelines.Data
{

    public class Task
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid BoardId { get; set; }
    }
}
