using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private static void Main(string[] args)
    {
      IWebDriver driver = new ChromeDriver();
      driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
      driver.Manage().Window.Maximize();
      IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
      usernameTextbox.SendKeys("hari");
      Thread.Sleep(3);
      IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
      passwordTextbox.SendKeys("123123");
      IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
      loginbutton.Click();
      IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

        if (hellohari.Text == "Hello hari!")
        {
            Console.WriteLine("Login Successfully");

        }
        else
        {
            Console.WriteLine("login failed");
        }

        //CREATE A TIME AND MATERIAL RECORD

        IWebElement administrationtab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        administrationtab.Click();
        IWebElement timeandmaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        timeandmaterial.Click();
        IWebElement createnewbutton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        createnewbutton.Click();
        IWebElement typecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        typecodedropdown.Click();
        IWebElement timeoption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_option_selected\"]"));
        timeoption.Click();
    }
}