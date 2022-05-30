using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebPageParserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Parse();
        }

        static async void Parse()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = @"https://www.ukrinform.ua/";

            driver.FindElement(By.XPath("//a[contains(text(),'Останні новини')]")).Click();
            driver.FindElement(By.CssSelector("div[class='rest'] dl dd div a")).Click();
        }
    }
}
