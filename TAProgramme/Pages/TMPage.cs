//using NUnit.Framework;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TAProgramme.Pages
//{
//    public class TMPage
//    {
//        public void CreateTimeRecord(IWebDriver driver)
//        {
//            //Click on create new button
//            IWebElement createnewbutton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
//            createnewbutton.Click();

//            //Select Time from dropdown
//            //IWebElement typecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
//            //typecodedropdown.Click();
//            //IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
//            //timeOption.Click();

//            //Type code into text box
//            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
//            codeTextbox.SendKeys("TA Programme");

//            //Type description into textbox
//            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
//            descriptionTextbox.SendKeys("This is a Description");

//            //Type price into pricetextbox
//            IWebElement priceTagoverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
//            priceTagoverlap.Click();

//            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
//            priceTextbox.SendKeys("13");

//            //Click on save Button
//            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
//            saveButton.Click();
//            Thread.Sleep(3000);

//            //Check if Time Record has been created successfully
//            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
//            goToLastPageButton.Click();

//            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

//            Assert.That(newCode.Text == "TA Programme", "Not created");

//            //if (newCode.Text == "TA Programme")
//            //{
//            //  Assert.Pass("Record created")
//            //}
//            //else
//            //{
//            //   Assert.Fail("Not created");
//            //}
//        }

//        public void EditTimeRecord(IWebDriver driver)
//       {
//            Thread.Sleep(4000);
//            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[8]/td[5]/a[1]"));
//            editButton.Click();

//            //Edit the Price
//            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
//            priceTextbox.SendKeys("15");

//            //Click on save Button
//            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
//            saveButton.Click();
//            Thread.Sleep(3000);


//        }

//        public void DeleteTimeRecord(IWebDriver driver)
//        {

//        }
//    }
//}
