using OpenQA.Selenium;
public class insightsHomePage 
{
  private IWebDriver _driver;
  public insightsHomePage(IWebDriver driver) => this._driver = driver;

  private static readonly By PageUniqueIdentifier = By.CssSelector("input[type='submit']");

  private IWebElement _userId => _driver.FindElement(By.Id("UserId"));
  private IWebElement _usernameText => _driver.FindElement(By.CssSelector("input[type='text']"));
  private IWebElement _passwordText => _driver.FindElement(By.CssSelector("input[type='password']"));

  private IWebElement _submitButton => _driver.FindElement(By.CssSelector("input[type='submit']"));

  public IWebElement _forgotPassword=> _driver.FindElement(By.XPath("//a[@id=\"ForgotPassword\"]"));
  public string _forgotPasswordExpected = "Forgot Password";
}