using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private static void Main(string[] args)
    {
     //Open Browser
      IWebDriver driver = new ChromeDriver();

      //Launch portal
      driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
      driver.Manage().Window.Maximize();
      Thread.Sleep(3);
    
     //Identify Username
      IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
      usernameTextbox.SendKeys("hari");
      
     //Identify Password
      IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
      passwordTextbox.SendKeys("123123");

    //identify login button
      IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
      loginbutton.Click();
      IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

     //Check user logged succesfully

        if (hellohari.Text == "Hello hari!")
        {
            Console.WriteLine("Login Successfully");

        }
        else
        {
            Console.WriteLine("login failed");
        }

        //CREATE A TIME AND MATERIAL RECORD
        //Navigate Time and Material Page
        IWebElement administrationtab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        administrationtab.Click();
        IWebElement timeandmaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        timeandmaterial.Click();

        //Click on create new button
        IWebElement createnewbutton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        createnewbutton.Click();

        //Select Time from dropdown
        IWebElement typecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        typecodedropdown.Click();
        IWebElement timeoption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
        timeoption.Click();

        //Type code into text box
        IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
        codeTextbox.SendKeys("TA Programme");

        //Type description into textbox
        IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
        descriptionTextbox.SendKeys("This is a Description");

        //Type price into pricetextbox
        IWebElement priceTagoverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        priceTagoverlap.Click();

        IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
        priceTextbox.SendKeys("13");

        //Click on save Button
        IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        saveButton.Click();
        Thread.Sleep(3000);

        //Check if Time Record has been created successfully
        IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        goToLastPageButton.Click();

        IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

        if (newCode.Text == "TA Programme")
        {
            Console.WriteLine("Time Record Created");
        }
        else
        {
            Console.WriteLine("Not created");
        }








    }
}