using PhoneListApp.PhoneBook;

namespace PhoneListApp
{
    internal class Program
    {
        public static void Main()
        {
            var friendsPhoneList = new PhoneList<Friend>();
            friendsPhoneList.AddItem(new Friend("Maks", "1111-2222", true));
            friendsPhoneList.AddItem(new Friend("Peter", "2222-3333", false));
            friendsPhoneList.AddItem(new Friend("Boris", "3333-4444", true));

            Console.WriteLine("You are welcome to PhoneBook!");

            try
            {
                var contact = friendsPhoneList.FindByName("Boris");
                Console.WriteLine($"Name: {contact.Name}, Number: {contact.Number}");

                if (contact.IsWorkNumber)
                {
                    Console.WriteLine($"Contact {contact.Name} is work number");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Contact not found");
            }

            Console.WriteLine();

            var suppliersPhoneList = new PhoneList<Supplier>();
            suppliersPhoneList.AddItem(new Supplier("Global Connections Group", "5555-6666"));
            suppliersPhoneList.AddItem(new Supplier("Network DC", "6666-7777"));
            suppliersPhoneList.AddItem(new Supplier("Connection People Group", "7777-8888"));

            try
            {
                var contact = suppliersPhoneList.FindByPhone("6666-7777");
                Console.WriteLine($"Supplier: {contact.Name}, Number: {contact.Number} ");
            }
            catch (Exception)
            {
                Console.WriteLine("Contact not found");
            }
        }
    }
}