namespace WorkersApp.Models
{
    internal class WorkerProfile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int? WorkerId { get; set; }
        public Worker Worker { get; set; }
    }
}