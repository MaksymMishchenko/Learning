namespace CarApp
{
    class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? CarClassificationId { get; set; }
        public CarClassification CarClassification { get; set; }
    }
}
