using System.Threading.Tasks;

namespace CalorieProductApp
{
    interface IUserProduct
    {
        bool CreatesCatalog(string path);
        Task<bool> AddAsync(string product, double kСal, double weight);
        bool Add(string product, double kСal, double weight);
        Task<bool> PrintFileAsync();
        bool PrintFile();
        void Quit();
        
    }
}