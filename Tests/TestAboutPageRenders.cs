using OpenQA.Selenium.Chrome;
using WebTestingBaselineCSharp.Tasks;
using WebTestingBaselineCSharp.Pages;

namespace WebTestingBaselineCSharp.Tests;

/// <summary>
/// NUnit tests and assertions.
/// </summary>
public class Tests
{
    private readonly ChromeDriver driver = new();
    private MainTasks Actions => new(driver);
    private MainPage MainPage => new(driver);
    private AboutDropdownMenu AboutDropdownMenu => new(driver);
    private AboutPage AboutPage => new(driver);

    [SetUp]
    public void Setup()
    {           
        driver.Navigate().GoToUrl("https://selenium.dev");
    }

    [Test]
    public void TestAboutPageRenders()
    {
        Actions.ClickAction(MainPage.AboutMenu);
        Actions.ClickAction(AboutDropdownMenu.AboutSelenium);
        var result = Actions.AssertTextExists(AboutPage.AboutPageTitle, "About Selenium");
        Assert.That(result, Is.True);
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}