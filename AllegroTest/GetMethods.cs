using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllegroTest
{
    class GetMethods
    {
        //Get Results
        public static bool GetResults(IWebDriver driver)
        {
            IList<IWebElement> resultsList = driver.FindElements(By.ClassName("ebc9be2"));
            for (int i = 0; i < resultsList.Count; i++)
            {
                if (resultsList[i].Text.ToUpper().Contains("TOSTER"))
                    Console.WriteLine(resultsList[i].Text);
                else
                { 
                    Console.WriteLine("Failed: {0}", resultsList[i].Text);
                    return false;
                    
                }
               
            }
            return true;
        }
        public static void CheckResults(IWebDriver driver, bool result)
        {
            if (result == false)
            {
                Assert.Fail("Not all results containing \"toster\"");
            }
        }

    


    }
}
