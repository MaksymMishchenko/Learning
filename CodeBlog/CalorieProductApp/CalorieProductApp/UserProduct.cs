﻿using System;
using System.IO;
using System.Text;

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

        public void Add(string product, double kСal, double weight)
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