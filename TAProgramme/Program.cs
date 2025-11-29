using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TAProgramme.Pages;

public class Program
{
    private static void Main(string[] args)
    {
     //Open Browser
      IWebDriver driver = new ChromeDriver();

        //Login page object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);
     

        // Home page object initialization and definition
        HomePage homePageObj = new HomePage();
        homePageObj.NavigateToTMpage(driver);

        // TM page object initialization and definition
        TMPage tmPage = new TMPage();
        tmPage.CreateTimeRecord(driver);

        // Edit Time Record
        tmPage.EditTimeRecord(driver);

        //Delete Time Record
        tmPage.DeleteTimeRecord(driver);











    }
}