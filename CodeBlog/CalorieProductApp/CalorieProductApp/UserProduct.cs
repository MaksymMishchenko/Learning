using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CalorieProductApp
{
    class UserProduct : IUserProduct, IDisposable
    {
       public bool CreatesCatalog(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (!dir.Exists)
            {
                dir.Create();
            }

            return true;
        }

        /// <summary>
        /// AddAsync() method which runs method Add()
        /// </summary>
        /// <param name="product"></param>
        /// <param name="kСal"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        public async Task<bool> AddAsync(string product, double kСal, double weight)
       {
           var result = await Task.Run(() => Add(product,  kСal, weight));
           return result;
       }

       public bool Add(string product, double kСal, double weight)
        {
            using (var sw = new StreamWriter(@"G:\CalorieProductApp\User\ProductLogs\ProductLog.txt", true, Encoding.UTF8))
            {
                sw.Write("Дата и время введенной записи: ");
                sw.Write(DateTime.Now);

                sw.Write("\n");

                sw.Write("Введенный продукт: ");
                sw.Write(product);

                sw.Write("\n");

                sw.Write("Калорийность продукта: ");
                sw.Write(kСal);

                sw.Write("\n");

                sw.Write("Количество употребленной пищи: ");
                sw.WriteLine(weight);

                sw.Write("\n");
            }
            Console.WriteLine("Продукт добавлен в файл!");
            return true;
        }

        public void PrintFile()
        {
            using (var sr = new StreamReader(@"G:\CalorieProductApp\User\ProductLogs\ProductLog.txt"))
            {
                var data = sr.ReadToEnd();
                Console.WriteLine("Информация о добавленном продукте:");
                Console.Write(data);
            }
        }

        public void Quit()
        {
            Dispose();
        }

        public void Dispose()
        {
            Console.WriteLine("Вы вышли из приложения!");
            Environment.Exit(-1);
        }
    }
}