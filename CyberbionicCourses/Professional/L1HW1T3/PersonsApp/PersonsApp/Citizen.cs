namespace PersonsApp
{
    abstract class Citizen
    {
        public abstract string Name { get; set; }
        public abstract long PassportId { get; set; }
        public abstract uint Age { get; set; }
        public abstract string Type { get; set; }

        public override string ToString()
        {
            return string.Format($"Citizen type: {Type}, Name: {Name}, Passport Id: {PassportId}, Age: {Age}");
        }
    }
}
