using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebPageParserApp
{
    class Finder
    {
        private Dictionary<string, string> _dict;
        private string _link;
        public Finder(string link)
        {
            _link = link;
            _dict = new Dictionary<string, string>();
        }

        public async void Parse()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = $"{_link}";
            //await Task.Delay(1000);

            var oldData = string.Empty;

            driver.FindElement(By.XPath("//a[contains(text(),'Останні новини')]")).Click();
            //await Task.Delay(2000);
            driver.FindElement(By.CssSelector("div[class='rest'] dl dd div a")).Click();

            var title = driver.FindElement(By.XPath("//h1[@class='newsTitle']")).GetAttribute("textContent");
            var content = driver.FindElement(By.CssSelector(".news")).GetAttribute("textContent");

            _dict[title] = content;

            //var oldDate = "//div[@class='restDay']//p[contains(text(),'24 лютого 2022')]";
            //var lastDate = "//div[@class='restDay']//p[contains(text(),'30 травня 2022')]";
            //
            //if (lastDate != lastDate)
            //{
            //   
            //}

            driver.Quit();
        }
    }
}
