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

        public override void LaunchBrowser()
        {
            ConfigureOptions(options, (opts,arg)=> opts.AddArgument(arg));
            driver = new EdgeDriver();
        }

    }
}