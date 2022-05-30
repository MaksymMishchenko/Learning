using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebPageParserApp
{
    class Program
    {
        public Dictionary<string, string> _dic;
        static void Main(string[] args)
        {
            var finder = new Finder("https://www.ukrinform.ua/");
            finder.Parse();
        }
    }
}
