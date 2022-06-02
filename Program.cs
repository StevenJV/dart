using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]     
class Program {
     private IWebDriver driver {get; set;} = null!;
     private String _url = null!;         
 
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
    options.AddArguments("ignore-certificate-errors");
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
{
  _url = "https://dm1.in.navex-pe.com/";
  this.driver.Navigate().GoToUrl(this._url);           
  insightsHomePage insightsHome = new insightsHomePage(this.driver);
  Assert.AreEqual(insightsHome._forgotPasswordExpected, insightsHome._forgotPassword.Text);
     
}
[Test]
public void testInsightsBlog()
{   
    _url = "https://steven.vorefamily.net/"; 
  this.driver.Navigate().GoToUrl(this._url);           
  blogPage blog = new blogPage(this.driver);
  Assert.AreEqual(blog._titleExpected, blog.siteTitle.Text);

}
}
