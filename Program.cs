using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace VSCode {
[TestFixture]     
class Program {
     private IWebDriver driver {get; set;} = null!;
     private String _url = null!;         
     private String _search = null!;
     private String _expected = null!;
 
[SetUp]
public void SetupTest()
{                   
    String driverPath = "/usr/bin";        
    String driverExecutableFileName = "chromedriver";
    ChromeOptions options = new ChromeOptions();
    //options.AddArguments("headless");
    //options.AddArguments("no-sandbox");        
    options.AddArguments("window-size=1920,1080");        
    options.AddArguments("disable-dev-shm-usage");        
    //options.AddArguments("ignore-certificate-errors");
    options.BinaryLocation = "/usr/bin/google-chrome-stable";            
    ChromeDriverService service = ChromeDriverService.CreateDefaultService(driverPath,driverExecutableFileName);         
    driver = new ChromeDriver(service,options,TimeSpan.FromSeconds(30));
    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
    driver.Manage().Window.Maximize();                        
}
[TearDown]
public void TeardownTest()
{
    driver.Quit();
}
[Test]
public void testInsightsWobbly()
{   _url = "https://dm1.in.navex-pe.com/";    // wobbly     
    _search = "//a[@id=\"ForgotPassword\"]";
    _expected = "Forgot Password";
    try{
        this.driver.Navigate().GoToUrl(this._url);                                              
        IWebElement titleEl = this.driver.FindElement(By.XPath(_search));
        String title = titleEl.Text;
        Assert.AreEqual(_expected , title);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.ToString());
    }        
}
[Test]
public void testInsightsBlog()
{   
    _url = "https://steven.vorefamily.net/"; 
    _search = "//h1[@id=\"site-title\"]/a";
    _expected = "Steven's Notebook";
    try{
        this.driver.Navigate().GoToUrl(this._url);                                              
        IWebElement titleEl = this.driver.FindElement(By.XPath(_search));
        String title = titleEl.Text;
        Assert.AreEqual(_expected , title);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.ToString());
    }        
}
}
}
