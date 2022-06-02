using OpenQA.Selenium;
using Navex.QA.Nova;
using Navex.QA.Nova.PageObjects;

namespace dart;

public class insightsHomePage : PageObjectBase
{
    private static readonly By PageUniqueIdentifier = By.XPath("//div[@id=\"wrap\"]");
    public insightsHomePage(Browser browser) : base(browser, PageUniqueIdentifier) { }


    private IWebElement _userId => Browser.Driver.WebDriver.FindElement(By.Id("UserId"));
    private IWebElement _usernameText => Browser.Driver.WebDriver.FindElement(By.CssSelector("input[type='text']"));
    private IWebElement _passwordText => Browser.Driver.WebDriver.FindElement(By.CssSelector("input[type='password']"));

    private IWebElement _submitButton => Browser.Driver.WebDriver.FindElement(By.CssSelector("input[type='submit']"));

    public IWebElement _forgotPassword => Browser.Driver.WebDriver.FindElement(By.XPath("//a[@id=\"ForgotPassword\"]"));
    public string _forgotPasswordExpected = "Forgot password?";
}