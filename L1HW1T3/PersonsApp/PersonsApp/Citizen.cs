namespace PersonsApp
{
    abstract class Citizen
    {
         public abstract string Name { get; set; }
         public abstract long PassportId { get; set; }
         public abstract uint Age { get; set; }
    }
}
