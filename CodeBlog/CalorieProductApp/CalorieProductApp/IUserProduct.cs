namespace CalorieProductApp
{
    interface IUserProduct
    {
        bool CreatesCatalog(string path);
        void Add(string product, double kСal, double weight);
        void PrintFile();
        void Quit();
        
    }
}