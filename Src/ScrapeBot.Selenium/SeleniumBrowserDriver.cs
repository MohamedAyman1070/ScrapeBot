using ScrapeBot.Core;
using ScrapeBot.Selenium.BrowserProvider;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium;

namespace ScrapeBot.Selenium;

public class SeleniumBrowserDriver : IBrowserDriver
{
    private BrowserProviderBase _browserProvider ;
    private IWebDriver? _driver;
    private IWebDriver Driver =>
        _driver ?? throw new InvalidOperationException("Call Open() before using the driver.");
    public SeleniumBrowserDriver(BrowserProviderBase browserProvider)
    {
        _browserProvider = browserProvider;
    }

    public void Open()
    {
        _driver = _driver ?? _browserProvider.CreateDriver();
    }

    
    public void Back()
    {
        Driver.Navigate().Back();
    }

    //close current window
    public void Close()
    {
        Driver.Close();
    }

    //terminate browser
    public void Quit()
    {
        Driver.Quit();
        Driver.Dispose();
    }

    public void Forward()
    {
        Driver.Navigate().Forward();
    }

    public string GetCurrentUrl()
    {
        return Driver.Url;
    }

    public string GetWindowTitle()
    {
        return Driver.Title;
    }


    public void Navigate(string url)
    {
        Driver.Navigate().GoToUrl(url);
    }

    public void Refresh()
    {
        Driver.Navigate().Refresh();
    }

    public byte[] TakeScreenshot()
    {
        return Driver.TakeScreenshot().AsByteArray;
    }

   
}
