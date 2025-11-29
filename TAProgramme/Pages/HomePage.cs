using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAProgramme.Pages
{
    public class HomePage
    {
        public void NavigateToTMpage(IWebDriver driver)
        {
            //Navigate Time and Material Page
            IWebElement administrationtab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationtab.Click();
            IWebElement timeandmaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeandmaterial.Click();
        }
    }
}
