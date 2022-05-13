using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            String str = "Hello";
            Console.WriteLine(str);
            // var driver = new ChromeDriver();
            //var driver =  GetChromeDriver();
            //driver.Navigate().GoToUrl("https://ultimateqa.com/");

            //If ChromeDrive is in project itself and is attached 
            IWebDriver driver= new ChromeDriver();

            //IWebDriver driver = new ChromeDriver("C:\\Users\\ratneshwar.jha\\Downloads\\chromedriver_win32");
            driver.Navigate().GoToUrl("https://ultimateqa.com/");
            Assert.IsTrue(true);
            Console.WriteLine(driver.Title);
            Assert.AreEqual("Home | Ultimate QA", driver.Title);
            
        }

        /*private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }*/
    }
}
