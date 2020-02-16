using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllegroTest
{
    class SetMethods
    {
        //Enter Text
        public static void EnterText(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "Id")
                driver.FindElement(By.Id(element)).SendKeys(value);

            if (elementType == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Click button
        public static void ClickButton(IWebDriver driver, string element, string elementType)
        {

            if (elementType == "Id")
                driver.FindElement(By.Id(element)).Click();



            if (elementType == "Name")
                driver.FindElement(By.Name(element)).Click();



            if (elementType == "ClassName")
                driver.FindElement(By.ClassName(element)).Click();




            if (elementType == "CSS")
                driver.FindElement(By.CssSelector(element)).Click();



            if (elementType == "Xpath")
                driver.FindElement(By.XPath(element)).Click();
        }



      
    }
}
