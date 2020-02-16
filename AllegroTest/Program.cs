using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace AllegroTest
{
    class Program
    {

        static IWebDriver driver = new ChromeDriver();
        WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
        bool result;

        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://allegro.pl/");
            Console.WriteLine("Opened Url");
        }

        [Test]
        public void ExecuteTest()
        {

            try
            {
                SetMethods.ClickButton(driver, "/html/body/div[3]/div[8]/div/div[2]/div/div[2]/button[2]", "Xpath");
                SetMethods.EnterText(driver, "string", "toster", "Name");
                SetMethods.ClickButton(driver, "body > div.main-wrapper > div._fee54_2aeQx._fee54_2wG1k.headroom--top.headroom--not-bottom > nav > div > div._fee54_1qS-g.opbox-metrum-header__search-slot._fee54_3kwJ4._fee54_3kwJ4._fee54_3kwJ4 > div > div > form > button", "CSS");
                Thread.Sleep(2000);
                wait.Until(d => d.FindElement(By.ClassName("star-icon")));
                result = GetMethods.GetResults(driver);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        [TearDown]
        public void CleanUp()
        {
            try
            {
            GetMethods.CheckResults(driver, result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
