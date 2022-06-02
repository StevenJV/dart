using OpenQA.Selenium;
using Navex.QA.Nova;
using Navex.QA.Nova.PageObjects;

public class blogPage : PageObjectBase
{
    private static readonly By PageUniqueIdentifier = By.CssSelector("//h1[@id=\"site-title\"]");
    public blogPage(Browser browser) : base(browser, PageUniqueIdentifier) { }
    public IWebElement siteTitle => Browser.Driver.WebDriver.FindElement(By.XPath("//h1[@id=\"site-title\"]/a"));
    public string _titleExpected = "Steven's Notebook";
}