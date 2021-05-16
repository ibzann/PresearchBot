using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace PresearchBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(73, 25);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("------------------------------PresearchBot------------------------------");
            Console.WriteLine("---------------Please wait for PresearchBot to initialize---------------");
            Console.WriteLine("------------------------------------------------------------------------");
            string[] words = { "article", "meaning", "variety", "ask", "conclusion", "charismatic", "ministry", "understand", "brain", "inquiry", "convenience", "chase", "utter", "capital", "violation", "lunch", "gas", "shine", "valley", "resource", "equip", "thoughtful", "mislead", "To cast the first stone", "You look as if you've been dragged through a hedge backwards", "Loaf of bread", "No room to swing a cat", "Beck and call", "Sealed with a loving kiss", "The life of Riley", "license", "curve", "pile", "fisherman", "news", "small", "deputy", "sport", "easy", "moral", "brilliance", "slab", "minimum", "polish", "horizon", "amber", "remunerate", "blackmail", "punish", "jurisdiction", "hell", "needle", "myth", "burn", "battle", "artificial", "unit", "hear", "distant", "affair", "program", "infection", "ton", "resort", "finished", "warn", "grow", "organ", "origin", "lion", "twitch", "flex", "shot", "unaware", "species", "medieval", "laborer", "flesh", "staircase", "shark" };
            IWebDriver driver = new ChromeDriver();
            int x = 1;
            while (x <= 30)
            {
                driver.Navigate().GoToUrl("https://presearch.org");
                driver.FindElement(By.Name("term")).SendKeys(words[new Random().Next(0, words.Length)]);
                driver.FindElement(By.Name("term")).SendKeys(Keys.Enter);
                driver.Navigate().GoToUrl("https://presearch.org");
                x++;
            }
            driver.Quit();
            Console.ReadLine();
        }
    }
}			
