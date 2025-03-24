using OpenQA.Selenium;

namespace WebTestingBaselineCSharp.Pages;

public class AboutPage(IWebDriver driver)
{
    private readonly IWebDriver driver = driver;

    public IWebElement AboutPageTitle => driver.FindElement(By.TagName("h1"));
}