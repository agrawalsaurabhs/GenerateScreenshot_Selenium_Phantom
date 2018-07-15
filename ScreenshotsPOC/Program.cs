using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Screenshots_Selenium_PhantomJs
{
    class Program
    {
        public static PhantomJSDriver driver;

        static void Main(string[] args)
        {
            driver = new PhantomJSDriver();
            driver.Manage().Window.Maximize();
            Console.WriteLine(driver.Manage().Window.Size);
            driver.Navigate().GoToUrl("https://google.com/");
            driver.GetScreenshot().SaveAsFile("screenshot.png", ImageFormat.Png);
            driver.Quit();
            Console.Read();
        }
    }
}
