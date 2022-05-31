using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace VSCode {
[TestFixture]     
class Program {
     private IWebDriver driver {get; set;}
     //private String _url = "http://www.jtable.org/Demo/Filtering";         
     private String _url = "https://dna01.dev.insights.local";         
 
[SetUp]
public void SetupTest()
{                   
    //Configuration to Windows
    //  String driverPath = @"D:\Projetos\VsCode\SeleniumDotNetCore\bin\Debug\netcoreapp2.1";
    //  String driverExecutableFileName = "chromedriver.exe";         
    //  ChromeOptions options = new ChromeOptions();
    //  options.AddArguments("window-size=1200x600");      
    //Configuration to Linux - Container
    String driverPath = "/usr/bin";        
    String driverExecutableFileName = "chromedriver";
    ChromeOptions options = new ChromeOptions();
    options.AddArguments("headless");
    options.AddArguments("no-sandbox");        
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
public void testMethod()
{   
    try{
        this.driver.Navigate().GoToUrl(this._url);                                              
        IWebElement bodyElement = this.driver.FindElement(By.XPath("//div[contains(@class,'main-header')]/h2"));
        String strContent= bodyElement.GetAttribute("textContent");
        Assert.AreEqual("A JQuery plugin to create AJAX based CRUD tables." , strContent);
    
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.ToString());
    }        
}
}
}
