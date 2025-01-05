namespace PersonsApp
{
    class Student : Citizen
    {
        public override string Name { get; set; }
        public override long PassportId { get; set; }
        public override uint Age { get; set; }
        public override string Type { get; set; }
    }
}
