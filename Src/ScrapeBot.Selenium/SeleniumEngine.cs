using ScrapeBot.Core;
using ScrapeBot.Selenium.BrowserProvider;

namespace ScrapeBot.Selenium
{
    public class SeleniumEngine: IBrowserEngine
    {
        private readonly SeleniumBrowserDriver BrowserDriver;
        private readonly SeleniumLocator Locator;

        public SeleniumEngine(BrowserProviderBase browserProvider)
        {
            BrowserDriver = new SeleniumBrowserDriver(browserProvider);
            Locator = new SeleniumLocator(BrowserDriver);
        }

        public IBrowserDriver GetDriver()
        {
            throw new NotImplementedException();
        }

        public ILocator GetLocator()
        {
            throw new NotImplementedException();
        }
    }
}