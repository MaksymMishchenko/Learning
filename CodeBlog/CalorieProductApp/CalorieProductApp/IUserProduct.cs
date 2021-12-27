namespace CalorieProductApp
{
    interface IUserProduct
    {
        void Add(string product, double kСal, double weight);
        void PrintFile();
        void Quit();
    }
}