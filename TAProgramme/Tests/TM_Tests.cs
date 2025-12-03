//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TAProgramme.Pages;
//using TAProgramme.Utilities;
//using static System.Net.Mime.MediaTypeNames;

//namespace TAProgramme.Tests
//{
//    [TestFixture]
//    public class TM_Tests : CommonDriver
//    {
//        [SetUp]
//        public void SetUpSteps()
//        {
//            //Open Browser
//            driver = new ChromeDriver();

//            //Login page object initialization and definition
//            LoginPage loginPageObj = new LoginPage();
//            loginPageObj.LoginActions(driver);


//            // Home page object initialization and definition
//            HomePage homePageObj = new HomePage();
//            homePageObj.NavigateToTMpage(driver);
//        }
//        [Test]
//        public void CreateTime_Test()
//        {
//            // TM page object initialization and definition
//            TMPage tmPageObj = new TMPage();
//            tmPageObj.CreateTimeRecord(driver);
//            //tmPage.CreateTimeRecord(driver);
//        }
//        [Test]
//        public void EditTime_Test()
//        {
//            // Edit Time Record
//            TMPage tmPage = new TMPage();
//            tmPage.EditTimeRecord(driver);
//        }
//        [Test]
//        public void DeleteTime_Test()
//        {
//            //Delete Time Record
//            TMPage tmPage = new TMPage();
//            tmPage.DeleteTimeRecord(driver);
//        }
//        [TearDown]
//        public void CloseTestrun()
//        {
//            driver.Quit(); 
//        }
//    }
//}
