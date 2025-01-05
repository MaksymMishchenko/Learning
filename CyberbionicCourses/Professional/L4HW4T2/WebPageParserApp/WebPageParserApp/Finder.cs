using System.IO;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebPageParserApp
{
    class Finder
    {
        private string _link;

        public Finder(string link)
        {
            _link = link;
        }

        public void Parse()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = $"{_link}";

            driver.FindElement(By.XPath("//a[contains(text(),'Останні новини')]")).Click();
            driver.FindElement(By.CssSelector("div[class='rest'] dl dd div a")).Click();

            var content = driver.FindElement(By.CssSelector(".news")).GetAttribute("textContent");
            var result = content.Replace("\r", string.Empty).Replace("\n", string.Empty).TrimStart();

            using (var streamWriter = new StreamWriter("file.txt", false, Encoding.UTF8))
            {
                streamWriter.WriteLine(result);
            }

            driver.Quit();
        }
    }
}
