using ScrapeBot.Core;
using ScrapeBot.Selenium.BrowserProvider;

namespace ScrapeBot.Selenium;

public class SeleniumBrowserDriver : IBrowserDriver
{
    private BrowserProviderBase _browserProvider ;
    public SeleniumBrowserDriver(BrowserProviderBase browserProvider)
    {
        _browserProvider = browserProvider;
    }

    public void Open()
    {
        _browserProvider.LaunchBrowser();
    }

    public void Close()
    {
        _browserProvider.CloseBrowser();
    }

    public void Navigate(string url)
    {
        _browserProvider.Navigate(url);
    }
}
