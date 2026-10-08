using ScrapeBot.Selenium.BrowserProvider;

namespace ScrapeBot.Selenium
{
    public class SeleniumEngine
    {
        public readonly SeleniumBrowserDriver BrowserDriver;
        public readonly SeleniumLocator Locator;

        public SeleniumEngine(BrowserProviderBase browserProvider)
        {
            BrowserDriver = new SeleniumBrowserDriver(browserProvider);
            Locator = new SeleniumLocator(BrowserDriver);
        }
    }
}