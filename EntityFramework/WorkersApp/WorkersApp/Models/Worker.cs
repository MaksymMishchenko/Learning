namespace WorkersApp.Models
{
    internal class Worker
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public WorkerProfile WorkerProfile { get; set; }
    }
}
