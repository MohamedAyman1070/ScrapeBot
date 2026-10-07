using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace ScrapeBot.Selenium.BrowserProvider.Providers
{
    public class EdgeProvider : BrowserProviderBase
    {
        private EdgeOptions options;
        
        public EdgeProvider()
        {
            options = new EdgeOptions();
        }

        public override IWebDriver CreateDriver()
        {
            ConfigureOptions(options, (opts,arg)=> opts.AddArgument(arg));
            return new EdgeDriver(options);
        }

    }
}