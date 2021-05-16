using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace PresearchBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(72, 10);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("------------------------------PresearchBot------------------------------");
            Console.WriteLine("---------------------------Made by Ibzan#0286---------------------------");
            Console.WriteLine("------------------------------------------------------------------------");
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://google.com");
            Console.ReadLine();
        }
    }
}
