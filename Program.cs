using NUnit.Framework;
using OpenQA.Selenium;
using Navex.QA.Nova;
using Navex.QA.Nova.TestClassBases;

[TestFixture]
class Program : SeleniumBrowserTestBase
{
    protected Program(Browser browser, bool quitBrowser = true) : base(browser, quitBrowser: quitBrowser)
    {
    }
    private IWebDriver driver { get; set; } = null!;
    private String _url = null!;

    [SetUp]
    public void SetupTest()
    {
        // this should all be handled by Nova now
        // String driverPath = "/usr/bin";        
        // String driverExecutableFileName = "chromedriver";
        // ChromeOptions options = new ChromeOptions();
        // //options.AddArguments("headless");
        // //options.AddArguments("no-sandbox");        
        // options.AddArguments("window-size=1920,1080");        
        // options.AddArguments("disable-dev-shm-usage");        
        // options.AddArguments("ignore-certificate-errors");
        // options.BinaryLocation = "/usr/bin/google-chrome-stable";            
        // ChromeDriverService service = ChromeDriverService.CreateDefaultService(driverPath,driverExecutableFileName);         
        // driver = new ChromeDriver(service,options,TimeSpan.FromSeconds(30));
        // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
        // driver.Manage().Window.Maximize();                        
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
        Browser.Driver.Visit(this._url);
        insightsHomePage insightsHome = new insightsHomePage(Browser);
        Assert.AreEqual(insightsHome._forgotPasswordExpected, insightsHome._forgotPassword.Text);

    }
    [Test]
    public void testInsightsBlog()
    {
        _url = "https://steven.vorefamily.net/";
        Browser.Driver.Visit(this._url);
        blogPage blog = new blogPage(Browser);
        Assert.AreEqual(blog._titleExpected, blog.siteTitle.Text);

    }
}
