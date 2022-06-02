using OpenQA.Selenium;
public class blogPage 
{
  private IWebDriver _driver;
  public blogPage(IWebDriver driver) => this._driver = driver;

  public IWebElement siteTitle => _driver.FindElement(By.XPath("//h1[@id=\"site-title\"]/a"));
  public string _titleExpected = "Steven's Notebook";
}