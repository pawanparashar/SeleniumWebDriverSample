using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace SeleniumWebDriverAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                string path = @"C:\chromedriver_win32";

                
                IWebDriver driver = new ChromeDriver(path);
                driver.Navigate().GoToUrl("http://gateway.wipro.com");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
