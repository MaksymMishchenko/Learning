using MulTableApp.Model;

namespace MulTableApp
{
    internal class TableManager
    {
       public TableParams Analyzation(string[][] mulTab)
        {
            return new TableParams ()
            {
                Width = mulTab[0][0].Length, 

                Height = 12
            };
        }
    }
}